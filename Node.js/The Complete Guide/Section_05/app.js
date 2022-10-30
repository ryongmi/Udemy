const express = require("express");
const bodyParser = require("body-parser");
// express 함수 및 로직을 받아옴
const app = express();

// use() : express 미들웨어
// app.use((req, res, next) => {
//   console.log("express start");

//   // next() 메서드를 사용해야 다음 미들웨어로 넘어감
//   next();
// });

// bodyParser.urlencoded() : req.body 값을 분석해서 알려줌
app.use(bodyParser.urlencoded({ extended: false }));

// use('/add-product', (req, res, next) : use(경로, (데이터 매개변수)) : 경로를 설정하여 실행될 미들웨어를 선택할 수 있음
// 위에서 아래로 읽기 때문에 url에 /add-product이 붙어있으면 add-product 미들웨어가 실행된다
app.use("/add-product", (req, res, next) => {
  // send() : 응답값
  res.send(
    "<form action='/product' method='POST'><input type='text' name='title'><button type='submit'>Add product</button></input></form>"
  );
});

// post() : post 요청일때만 실행됨
// get() : get 요청일떄만 실행됨
// use() : post, get, 둘다 실행됨
app.post("/product", (req, res, next) => {
  console.log(req.body);

  // redirect() : 경로 재설정
  res.redirect("/");
});

app.use("/", (req, res, next) => {
  // send() : 응답값
  res.send("<h1>Hello from Express!</h1>");
});

// 요청 대기
app.listen(3000);
