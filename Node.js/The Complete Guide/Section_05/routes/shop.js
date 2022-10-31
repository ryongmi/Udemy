// Node.js에서 지원, 코어 모듈
const path = require("path");

const express = require("express");

const router = express.Router();

router.get("/", (req, res, next) => {
  // sendFile() : 파일을 응답값으로 보냄, 절대경로만 사용해야함
  // 보내는 파일에 맞게 헤더가 자동으로 설정됨
  // __dirname : 절대경로를 이 프로젝트 폴더로 고정해주는 전역변수, 정확히는 __dirname가 사용된 shop.js 파일의 폴더(routes) 값을 가져옴
  // join으로 연결하는 이유 : 원영체제에 따라서 경로문자가 다를수가 있는데, 운영체제에 맞게 경로를 짜줌
  res.sendFile(path.join(__dirname, "..", "views", "shop.html"));
});

module.exports = router;
