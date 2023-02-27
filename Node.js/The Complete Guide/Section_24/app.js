const express = require("express");
const app = express();
const bodyParser = require("body-parser");
const mongoose = require("mongoose");
const path = require("path");
const multer = require("multer");
const { v4: uuidv4 } = require("uuid");

const feedRoutes = require("./routes/feed");

const fileStorage = multer.diskStorage({
  destination: (req, file, cb) => {
    cb(null, "images");
  },
  filename: (req, file, cb) => {
    cb(null, uuidv4());
  },
});

const fileFilter = (req, file, cb) => {
  if (
    file.mimetype === "image/png" ||
    file.mimetype === "image/jpg" ||
    file.mimetype === "image/jpeg"
  )
    cb(null, true);
  else cb(null, false);
};

const MONGODB_URI =
  "mongodb+srv://User:231612@cluster0.10vyadb.mongodb.net/message";

//app.use(bodyParser.urlencoded()); // x-www-form-urlencoded <form>
app.use(bodyParser.json()); // application/json
app.use(
  multer({ storage: fileStorage, fileFilter: fileFilter }).single("image")
);
app.use("/images", express.static(path.join(__dirname, "images")));

app.use((req, res, next) => {
  // CORS 에러 방지하기 위한 구문
  // 클라이언트와 서버의 도메인(IP, 포트)가 다를때, 요청이나 응답을 보낼때 발생함
  res.setHeader("Access-Control-Allow-Origin", "*");
  res.setHeader("Access-Control-Allow-Methods", "GET, POST, PUT, PATCH,DELETE");
  res.setHeader("Access-Control-Allow-Headers", "Content-Type, Authorization");
  next();
});

app.use("/feed", feedRoutes);
app.use((error, res, req, next) => {
  console.log(error);
  const stauts = error.stautsCode || 500;
  const message = error.message;
  res.stauts(stauts).json({ message: message });
});

mongoose
  .connect(MONGODB_URI)
  .then((result) => app.listen(8000))
  .catch((err) => console.log(err));

app.listen(8080);
