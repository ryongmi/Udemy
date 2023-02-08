const express = require("express");
const app = express();
const bodyParser = require("body-parser");
const feedRoutes = require("./routes/feed");

//app.use(bodyParser.urlencoded()); // x-www-form-urlencoded <form>
app.use(bodyParser.json()); // application/json

app.use((req, res, next) => {
  // CORS 에러 방지하기 위한 구문
  // 클라이언트와 서버의 도메인(IP, 포트)가 다를때, 요청이나 응답을 보낼때 발생함
  res.setHeader("Access-Control-Allow-Origin", "*");
  res.setHeader("Access-Control-Allow-Methods", "GET, POST, PUT, PATCH,DELETE");
  res.setHeader("Access-Control-Allow-Headers", "Content-Type, Authorization");
  next();
});

app.use("/feed", feedRoutes);

app.listen(8080);
