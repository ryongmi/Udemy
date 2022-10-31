const path = require("path");
const express = require("express");
const bodyParser = require("body-parser");
// express 함수 및 로직을 받아옴
const app = express();

const adminRoutes = require("./routes/admin");
const shopRoutes = require("./routes/shop");

// use() : express 미들웨어
// app.use((req, res, next) => {
//   console.log("express start");

//   // next() 메서드를 사용해야 다음 미들웨어로 넘어감
//   next();
// });

// bodyParser.urlencoded() : req.body 값을 분석해서 알려줌
app.use(bodyParser.urlencoded({ extended: false }));

// 라우터안의 경로가 /admin으로 공통될때, 라우터 파일이 아닌, 호출할때 경로를 지정할 수 있음
// 이렇게 지정하게되면, /admin으로 경로가 시작되는 것들만 실행되게 할 수 있음
app.use("/admin", adminRoutes);
app.use(shopRoutes);

app.use((req, res, next) => {
  // 페이지를 못찾았을때, 상태를 404로 만들어 표시함
  res.status(404).sendFile(path.join(__dirname, "views", "404.html"));
});

// 요청 대기
app.listen(3000);
