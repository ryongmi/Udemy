const authMiddleware = require("../middleware/is-auth");
const sinon = require("sinon");
const mongoose = require("mongoose");

const User = require("../models/user");
const authController = require("../controllers/auth");
const expect = require("chai").expect;

describe("Auth Controller", function (done) {
  // before : 테스트 전에 한번 실행되는 훅
  // beforeEach : 모든 it() 테스트가 실행되기전에 한번씩 실행되는 훅
  before(function (done) {
    mongoose
      .connect(
        "mongodb+srv://User:231612@cluster0.10vyadb.mongodb.net/test-message?retryWrites=true"
      )
      .then((result) => {
        const user = new User({
          email: "test@test.com",
          password: "test",
          name: "test",
          posts: [],
          _id: "5c0f66b979af55031b34728a",
        });
        return user.save();
      })
      .then(() => {
        done();
      });
  });

  it("should throw an error with code 500 if accessing the database fails", function () {
    // DB 데이터가 필요하기때문에, 메서드를 재정의함
    sinon.stub(User, "findOne");
    User.findOne.throws();

    const req = {
      email: "test@test.com",
      password: "dsds",
    };

    authController
      .login(req, {}, () => {})
      .then((result) => {
        expect(result).to.be.an("error");
        expect(result).to.have.property("statusCode", 500);

        // 비동기식이 있을 경우, 그것을 기다렸다가 가게 하는 메서드
        // 이 메서드를 사용하지 않을 거면, 매개변수에 있는 done을 정의하지 않아야함.
        done();
      });

    User.findOne.restore();
  });

  it("should send a response with a valid user status for an existing user", function (done) {
    const req = { userId: "5c0f66b979af55031b34728a" };
    const res = {
      statusCode: 500,
      userStatus: null,
      status: function (code) {
        this.statusCode = code;
        return this;
      },
      json: function (data) {
        this.userStatus = data.status;
      },
    };
    authController
      .getUserStatus(req, res, () => {})
      .then(() => {
        expect(res.statusCode).to.be.equal(200);
        expect(res.userStatus).to.be.equal("I am new!");

        done();
      });
  });

  // after : 테스트 후에 한번 실행되는 훅
  // afterEach : 모든 it() 테스트가 실행된 후 한번씩 실행되는 훅
  after(function (done) {
    // 테스트시, ID값이 하드코딩된 한명의 유저가 테스트 db에 생성되기 때문에, 다음 실행에서 에러를 방지하기 위해 유저를 삭제함
    User.deleteMany({});
    // DB 연결을 해제하고 done을 실행하지 않으면, 프로세스가 끝나지 않은것으로 판단하여 종료되지않아 Timeout 에러가 발생함
    mongoose.disconnect().then(() => {
      done();
    });
  });
});
