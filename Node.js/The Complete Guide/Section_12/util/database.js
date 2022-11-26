const mongodb = require("mongodb");
const MongoClient = mongodb.MongoClient;

let _db;

const mongoConnect = (callback) => {
  // mongodb 연결
  MongoClient.connect(
    // UserId : User
    // PW : 231612
    // 연결하려는 DataBase : shop
    "mongodb+srv://User:231612@cluster0.10vyadb.mongodb.net/shop?retryWrites=true&w=majority"
  )
    // client : mongodb에 접속할 수 있는 클라이언트객체
    .then((client) => {
      console.log("Connected!");
      _db = client.db();
      callback();
    })
    .catch((err) => {
      console.log(err);
      throw err;
    });
};

const getDb = () => {
  if (_db) return _db;
  throw "Not DataBase Found";
};

exports.mongoConnect = mongoConnect;
exports.getDb = getDb;
