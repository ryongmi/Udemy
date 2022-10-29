const fs = require("fs");

// req : 요청, res : 응답
function requestHandler(req, res) {
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

      // writeFileSync : 파일작업을 비동기로 처리함
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
}

// module.exports : Node.js에 저장된 전역개체
// 데이터를 외부로 보내줌
// 전역개체이기때문에 어디서든 접근가능
//module.exports = requestHandler;

// 개체로 묶어서 한번에 보내는 방법
// module.exports = {
//   Handler: requestHandler,
//   someText: "Some hard coded text",
// };

// 2가지 이사의 데이터를 보내는 방법
// Handler, someText이 속성명, requestHandler, "Some hard coded text"이 데이터
// 개체 속성 추가하는것과 동일한 방법
// module.exports는 전역개체여서 개체와 동일하게 동작하나?
module.exports.Handler = requestHandler;
// module 생략가능, Node.js에서 지원하는 기능
exports.someText = "Some hard coded text";
