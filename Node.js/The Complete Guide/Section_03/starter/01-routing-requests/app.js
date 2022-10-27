// require('파일명(경로)') : Node.js 내장 메서드
// 외부 파일을 참조함.
// './파일명' : 상대경로, '/파일명' : 절대경로
// http : Node.js 내장 메서드
const http = require("http");
const fs = require("fs");

// createServer() : 서버 생성 메서드
// 서버에 요청이 올때마다 Node.js가 실행함
// createServer() 메서드로 생성된 서버를 상수 server에 저장함
// req : 요청, res : 응답
const server = http.createServer((req, res) => {
  // req.url : 호스트 뒤에 붙은 주소
  // ex) localhost:3000/test -> /test가 출력됨
  //console.log(req.url, req.method, req.headers);

  const url = req.url;
  const method = req.method;

  if (url === "/") {
    res.write("<html>");
    res.write("<head><title>Enter Message</title></head>");
    res.write(
      "<body><form action='/message' method='POST'><input type='text' name='message'><button type='submit'>Send</button></input></form></body>"
    );
    res.write("</html>");
    return res.end();
  }
  if (url === "/message" && method === "POST") {
    const body = [];
    req.on("data", (chunk) => {
      // chunk : 사용자가 input에 입력한 값을 16진수로 가져온것
      console.log(chunk);
      body.push(chunk);
    });
    req.on("end", () => {
      // parsedBody : 16진수로 가져온 사용자 입력값을 사람이 볼수 있는 문자열로 변환
      // 사용자 입력값 : test 라고 하면, message=test 란 값이 나옴
      // (태그)name=입력값 형식으로 옴
      const parsedBody = Buffer.concat(body).toString();
      console.log(parsedBody);
      const message = parsedBody.split("=")[1];

      fs.writeFileSync("message.txt", message);
    });

    // statusCode = 302 : 브라우저가 허용하게 하는 값?
    res.statusCode = 302;
    res.setHeader("Location", "/");
    return res.end();
  }

  // setHeader() : 응답을 보낼때 Header를 설정하는 메서드
  res.setHeader("Content-Type", "text/html");

  // write() : 응답을 보낼때 내용을 작성하는 메서드
  res.write("<html>");
  res.write("<head><title>My First Page</title></head>");
  res.write("<body><h1>Hello from my Node.js Server!</h1></body>");
  res.write("</html>");

  // end() : 보낼 응답 내용이 끝났음을 알림, 이 이후에는 write()메서드를 사용해서는 안됨, 오류발생함
  res.end();
});

// listen(x) : x번째 포트로 서버에 요청이 들어오는걸 대기함
// Control + c를 입력하면 종료됨
server.listen(3000);
