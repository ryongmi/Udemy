const path = require("path");

const express = require("express");

// 라우터 생성
const router = express.Router();

// use('/add-product', (req, res, next) : use(경로, (데이터 매개변수)) : 경로를 설정하여 실행될 미들웨어를 선택할 수 있음
// 위에서 아래로 읽기 때문에 url에 /add-product이 붙어있으면 add-product 미들웨어가 실행된다
router.get("/add-product", (req, res, next) => {
  // send() : 응답값
  // res.send(
  //   "<form action='/admin/add-product' method='POST'><input type='text' name='title'><button type='submit'>Add product</button></input></form>"
  // );
  res.sendFile(path.join(__dirname, "..", "views", "add-product.html"));
});

// post() : post 요청일때만 실행됨
// get() : get 요청일떄만 실행됨
// use() : post, get, 둘다 실행됨
router.post("/add-product", (req, res, next) => {
  console.log(req.body);

  // redirect() : 경로 재설정
  res.redirect("/");
});

module.exports = router;
