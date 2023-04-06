const sinon = require("sinon");
const expect = require("chai").expect;
const mongoose = require("mongoose");

const User = require("../models/user");
const feedController = require("../controllers/feed");

describe("Feed Controller", function (done) {
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

  beforeEach(function () {});

  afterEach(function () {});

  it("should add a created post to the posts of the creator", function (done) {
    const req = {
      body: {
        title: "Test Post",
        content: "A Test Post",
      },
      file: {
        path: "abc",
      },
      userId: "5c0f66b979af55031b34728a",
    };
    const res = {
      status: function () {
        return this;
      },
      json: function () {},
    };

    feedController
      .createPost(req, res, () => {})
      .then((savedUser) => {
        expect(savedUser).to.have.property("posts");
        expect(savedUser.posts).to.have.length(1);
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
