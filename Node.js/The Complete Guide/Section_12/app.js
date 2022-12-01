const path = require("path");
const express = require("express");
const bodyParser = require("body-parser");

// express 함수 및 로직을 받아옴
const app = express();

const errorController = require("./controllers/error");

const adminRoutes = require("./routes/admin");
const shopRoutes = require("./routes/shop");

const mongoConnect = require("./util/database").mongoConnect;
const User = require("./models/user");

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

app.use((req, res, next) => {
  User.findById("6387329774315774e6f97350")
    .then((user) => {
      req.user = new User(user.name, user.email, user.cart, user._id);
      next();
    })
    .catch((err) => console.log(err));
});

// 라우터안의 경로가 /admin으로 공통될때, 라우터 파일이 아닌, 호출할때 경로를 지정할 수 있음
// 이렇게 지정하게되면, /admin으로 경로가 시작되는 것들만 실행되게 할 수 있음
app.use("/admin", adminRoutes);
app.use(shopRoutes);

app.use(errorController.get404);

mongoConnect(() => {
  if (User.findById("6387329774315774e6f97350")) app.listen(3000);
});
