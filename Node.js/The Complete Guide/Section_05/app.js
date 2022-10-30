const http = require("http");

const express = require("express");

// express 함수 및 로직을 받아옴
const app = express();

// use() : express 미들웨어
app.use((res, req, next) => {
  console.log("express start");

  // next() 메서드를 사용해야 다음 미들웨어로 넘어감
  next();
});

app.use((res, req, next) => {
  console.log("express two start");
});

const server = http.createServer(app);

server.listen(3000);
