// 상위 디렉터리로 가는데 도움을 주는 파일
// 파일이름과 path모듈이 이름이 같아도, 임폴트 방식이 다르기 떄문에 상관없음

const path = require("path");

// 애플리케이션을 시작한 위치를 나타냄
// 여기서는 app.js를 나타냄
// process : 모든 파일에서 사용 가능한 전역변수
module.exports = path.dirname(process.mainModule.filename);
