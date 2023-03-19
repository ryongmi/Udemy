const express = require("express");
const app = express();
const bodyParser = require("body-parser");
const mongoose = require("mongoose");
const path = require("path");
const multer = require("multer");
const { v4: uuidv4 } = require("uuid");
const CORS = require("cors");

const feedRoutes = require("./routes/feed");
const authRoutes = require("./routes/auth");

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
  ) {
    cb(null, true);
  } else {
    cb(null, false);
  }
};

const MONGODB_URI =
  "mongodb+srv://User:231612@cluster0.10vyadb.mongodb.net/message?retryWrites=true";

//app.use(bodyParser.urlencoded()); // x-www-form-urlencoded <form>
//app.use(CORS());
app.use(bodyParser.json()); // application/json
app.use(
  multer({ storage: fileStorage, fileFilter: fileFilter }).single("image")
);
app.use("/images", express.static(path.join(__dirname, "images")));

app.use((req, res, next) => {
  // CORS 에러 방지하기 위한 구문
  // 클라이언트와 서버의 도메인(IP, 포트)가 다를때, 요청이나 응답을 보낼때 발생함
  res.setHeader("Access-Control-Allow-Origin", "*");
  res.setHeader(
    "Access-Control-Allow-Methods",
    "OPTIONS, GET, POST, PUT, PATCH, DELETE"
  );
  res.setHeader("Access-Control-Allow-Headers", "Content-Type, Authorization");
  next();
});

app.use("/feed", feedRoutes);
app.use("/auth", authRoutes);

app.use((error, res, req, next) => {
  console.log(error);
  const stauts = error.stautsCode || 500;
  const message = error.message;
  const data = error.data;
  res.stauts(stauts).json({ message: message, data: data });
});

mongoose
  .connect(MONGODB_URI)
  .then((result) => {
    const server = app.listen(8080);
    // const io = require("./socket");
    // const SocketIO = io(server, { path: "/socket.io" });
    // SocketIO.on("connection", (socket) => {
    //   console.log("Client connected");
    // });

    const io = require("./socket").init(server); // 프론트에서 transports: ["websocket"] 을 넣어줘야 CORS 에러가 발생하지 않음
    io.on("connection", (socket) => {
      console.log("Client connected");
    });
  })
  .catch((err) => console.log(err));
