// const mysql = require("mysql2");

// const pool = mysql.createPool({
//   host: "localhost",
//   user: "root",
//   database: "node-complete",
//   password: "231612",
// });

// // promise() : 콜백을 피하고 비동기적으로 작업을 실행시켜줌
// module.exports = pool.promise();

// sequelize 사용, 위에 mysql2 모듈을 사용했을때, 커넥션풀을 exports한것과 동일한 값을 넘겨줌
const Sequelize = require("sequelize");
const sequelize = new Sequelize("node-complete", "root", "231612", {
  dialect: "mysql",
  host: "localhost",
});

module.exports = sequelize;
