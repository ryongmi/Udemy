const path = require("path");
const express = require("express");
const bodyParser = require("body-parser");
const mongoose = require("mongoose");
const session = require("express-session");
const MongoDBStore = require("connect-mongodb-session")(session);
const csrf = require("csurf");
const flash = require("connect-flash");

const MONGODB_URI =
  "mongodb+srv://User:231612@cluster0.10vyadb.mongodb.net/shop";

// express 함수 및 로직을 받아옴
const app = express();

const csrfProtection = csrf();

const store = new MongoDBStore({
  uri: MONGODB_URI,
  collection: "sessions",
});

const errorController = require("./controllers/error");

const adminRoutes = require("./routes/admin");
const shopRoutes = require("./routes/shop");
const authRoutes = require("./routes/auth");

const User = require("./models/user");

// const User = require("./models/user");

// pug에서 image - src 같이 문자열로 넣어야 하는곳은 src="#{변수명}"으로 넣는것이 아니라 src=변수명 으로 넣으면 작동함

// 'pug' 라는 템플릿 엔진을 사용하겠다고 명시
// 내장 엔진이여서 set으로 함
app.set("view engine", "pug");

// 템플릿 엔진의 기본 폴더를 설정
// views 폴더가 기본 폴더로 설정됨
app.set("views", "views");

// bodyParser.urlencoded() : req.body 값을 분석해서 알려줌
app.use(bodyParser.urlencoded({ extended: false }));

// 정적으로 파일의 경로를 지정
// 정적의미 : 다른 미들웨어를 거쳐서 처리되지 않고, 바로 파일 시스템에 포워딩됨
app.use(express.static(path.join(__dirname, "public")));

// 세션 설정
app.use(
  session({
    secret: "my session",
    resave: false,
    saveUninitialized: false,
    store: store,
  })
);

app.use(csrfProtection);
app.use(flash());

app.use((req, res, next) => {
  res.locals.isAuthenticated = req.session.isLoggedIn;
  res.locals.csrfTotken = req.csrfToken();
  next();
});

app.use((req, res, next) => {
  // 동기식, 즉 callback 및 promise 외부에서 오류를 보내면,
  // 오류 처리 미들웨어로 보내짐
  //throw new Error("Sync Dummy");
  if (!req.session.user) {
    return next();
  }
  User.findById(req.session.user._id)
    .then((user) => {
      if (!user) {
        next();
      }
      req.user = user;
    })
    .catch((err) => {
      // 비동기식, 즉 callback 및 promise(then, catch) 내부에서 오류를 보내면,
      // 오류 처리 미들웨어로 보내지지 않아, next()를 사용해서 보내야함
      //throw new Error(err);
      next(new Error(err));
    });
});

// 라우터안의 경로가 /admin으로 공통될때, 라우터 파일이 아닌, 호출할때 경로를 지정할 수 있음
// 이렇게 지정하게되면, /admin으로 경로가 시작되는 것들만 실행되게 할 수 있음
app.use("/admin", adminRoutes);
app.use(shopRoutes);
app.use(authRoutes);
app.use("/500", errorController.get500);

app.use(errorController.get404);

// express에서 사용할 수 있는 특수한 미들웨어, 에러 처리 미들웨어라고 함
// error 인수를 포함한 4개의 인수를 가짐
// next()를 호출할때, 매개변수를 포함한다면, 다른 미들웨어를 무시하고 이 미들웨어를 실행함
app.use((error, req, res, next) => {
  //res.status(error.httpStatusCode).render(...); 에러가 발생했을때 httpStatusCode를 설정하면, 페이지 render()에서 사용할 수 있음
  // res.redirect("/500");
  res.status(500).render("500", {
    title: "Error!",
    path: "/500",
    isAuthenticated: req.session.isLoggedIn,
  });
});

mongoose
  .connect(MONGODB_URI)
  .then((result) => {
    app.listen(3000);
  })
  .catch((err) => {
    console.log(err);
  });
