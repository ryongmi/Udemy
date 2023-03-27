const authMiddleware = require("../middleware/is-auth");
const jwt = require("jsonwebtoken");
const sinon = require("sinon");

const expect = require("chai").expect;

// 테스트 단일모듈을 묶어서 관리할수 있는 메서드.
describe("Auth middleware", () => {
  it("should throw an error if no authorization header is present", function () {
    const req = {
      get: function (headerName) {
        return null;
      },
    };

    // 직접 실행하게 되면 미들웨어에서 오류가 발생하기 때문에
    // bind를 사용하여 참조만 보내 테스트만 실행되게 함
    // Not authenticated. -> 에러가 발생했을때, 출력될 에러메시지를 예상
    expect(authMiddleware.bind(this, req, {}, () => {})).to.throw(
      "Not authenticated."
    );
  });

  it("should throw an error if the authorization header is only one string", function () {
    const req = {
      get: function (headerName) {
        return "null";
      },
    };

    // throw에 인수를 넣지 않으면, 에러메시지가 반환되지 않을것이라고 예측하는 것.
    expect(authMiddleware.bind(this, req, {}, () => {})).to.throw();
  });

  // token검사 후 속성 userId를 잘 할당하는지 테스트
  it("should yield a userId after decoding the token", function () {
    const req = {
      get: function (headerName) {
        return "Bearer dsdsadasdasdsa";
      },
    };
    // stub(객체, 메서드) -> 이 객체의 메서드를 저장함
    sinon.stub(jwt, "verify");

    // 토큰값을 알수없기때문에, 메서드를 재정의하여 테스트를 진행함
    jwt.verify.returns({ userId: "abc" });

    authMiddleware(req, {}, () => {});
    expect(req).to.have.property("userId");
    expect(req).to.have.property("userId", "abc"); // 값까지 확인하는법
    expect(jwt.verify.called).to.be.true; // 메서드가 실행되었는지 확인하는법

    // 메서드 원상복구
    jwt.verify.restore();
  });

  it("should throw an error if the token cannot be verified", function () {
    const req = {
      get: function (headerName) {
        return "Bearer xyz";
      },
    };

    expect(authMiddleware.bind(this, req, {}, () => {})).to.throw();
  });
});
