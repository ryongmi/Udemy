// require('파일명(경로)') : Node.js 내장 메서드
// 외부 파일을 참조함.
// './파일명' : 상대경로, '/파일명' : 절대경로
// http : Node.js 내장 메서드
const http = require("http");

// createServer() : 서버 생성 메서드
// 서버에 요청이 올때마다 Node.js가 실행함
// createServer() 메서드로 생성된 서버를 상수 server에 저장함
const server = http.createServer((req, res) => console.log(req));

// listen(x) : x번째 포트로 서버에 요청이 들어오는걸 대기함
// Control + c를 입력하면 종료됨
server.listen(3000);
