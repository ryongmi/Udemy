const path = require("path");
const express = require("express");
const bodyParser = require("body-parser");
// express 함수 및 로직을 받아옴
const app = express();

const adminData = require("./routes/admin");
const shopRoutes = require("./routes/shop");

const expressHbs = require("express-handlebars");

// use() : express 미들웨어
// app.use((req, res, next) => {
//   console.log("express start");

//   // next() 메서드를 사용해야 다음 미들웨어로 넘어감
//   next();
// });

// express-handlebars에서 가져온 변수를 함수로 넣어, 엔진 추가함
app.engine(
  "hbs",
  // layoutsDir : 기본 폴더 설정 - pug와 목적 동일, defaultLayout : 기본 레이아웃 파일 설정, extname : 확장자명 설정(기본으로는 handlebars 확장자명을 찾음)
  expressHbs({
    layoutsDir: "views/layouts",
    defaultLayout: "main-layout",
    extname: "hbs",
  })
);
// 추가한 엔진을 사용하겠다고 설정함
// 설정한 이름으로 파일명을 만들어야함, 예) fileName.hbs
app.set("view engine", "hbs");

// 'pug' 라는 템플릿 엔진을 사용하겠다고 명시
// 내장 엔진이여서 set으로 함
//app.set("view engine", "pug");

// 템플릿 엔진의 기본 폴더를 설정
// views 폴더가 기본 폴더로 설정됨
app.set("views", "views");

// bodyParser.urlencoded() : req.body 값을 분석해서 알려줌
app.use(bodyParser.urlencoded({ extended: false }));

// 정적으로 파일의 경로를 지정
// 정적의미 : 다른 미들웨어를 거쳐서 처리되지 않고, 바로 파일 시스템에 포워딩됨
app.use(express.static(path.join(__dirname, "public")));

// 라우터안의 경로가 /admin으로 공통될때, 라우터 파일이 아닌, 호출할때 경로를 지정할 수 있음
// 이렇게 지정하게되면, /admin으로 경로가 시작되는 것들만 실행되게 할 수 있음
app.use("/admin", adminData.routes);
app.use(shopRoutes);

app.use((req, res, next) => {
  // 페이지를 못찾았을때, 상태를 404로 만들어 표시함
  //res.status(404).sendFile(path.join(__dirname, "views", "404.html"));
  res.status(404).render("404", { title: "Page Not Found" });
});

// 요청 대기
app.listen(3000);
