// require('파일명(경로)') : Node.js 내장 메서드
// 외부 파일을 참조함.
// './파일명' : 상대경로, '/파일명' : 절대경로
// http : Node.js 내장 메서드
const http = require("http");

// routes파일에서 module.exports에 할당한 값을 가져옴
// createServer에 사용했던 함수가 담겨있음
// 읽기전용, 변경 및 할당을 할수없음
const routes = require("./routes");

// createServer() : 서버 생성 메서드
// 서버에 요청이 올때마다 Node.js가 실행함
// createServer() 메서드로 생성된 서버를 상수 server에 저장함
// routes.Handler : routes 파일에서 개체로 여러가지 데이터를 보냈기 때문에 함수를 찾아서 사용해야함
const server = http.createServer(routes.Handler);

// listen(x) : x번째 포트로 서버에 요청이 들어오는걸 대기함
// Control + c를 입력하면 종료됨
server.listen(3000);
