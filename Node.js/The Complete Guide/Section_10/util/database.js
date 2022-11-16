const mysql = require("mysql2");

const pool = mysql.createPool({
  host: "localhost",
  user: "root",
  database: "node-complete",
  password: "231612",
});

// promise() : 콜백을 피하고 비동기적으로 작업을 실행시켜줌
module.exports = pool.promise();
