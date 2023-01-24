const express = require("express");

// body -> req.body를 의미
const { check, body } = require("express-validator/check");

const router = express.Router();
const authController = require("../controllers/auth");
const User = require("../models/user");

router.get("/login", authController.getLogin);
router.post(
  "/login",
  [
    body("email")
      .isEmail()
      .withMessage("Please enter a valid email.")
      .normalizeEmail(),
    body(
      "password",
      "Please enter a password with only numbers and text and at leaset 5 characters."
    )
      .isLength({ min: 5 })
      .isAlphanumeric()
      .trim(),
  ],
  authController.postLogin
);

router.get("/signup", authController.getSignup);
router.post(
  "/signup",
  [
    check("email")
      .isEmail()
      .withMessage("Please enter a valid email.")

      // 개발자가 자유롭게 만들수 있는 유효성 검사메서드
      // value -> 입력값
      .custom((value, { req }) => {
        return User.findOne({ email: value }).then((userDoc) => {
          if (userDoc) {
            return Promise.reject(
              "E-Mail exists already, please pick a different one."
            );
          }
          // if (value === "test@naver.com")
          //   throw new Error("This email address if forbidden.");
          // return true;
        });
      })
      .normalizeEmail(),
    // body -> req.body만 탐색하여 안에 있는 password를 찾는다. 다른 header 등은 신경쓰지 않는다.
    // (a, b) -> a: 검사할 필드 이름, b: 유효하지 않을 경우 출력할 메시지, withMessage와 동일한 역할
    body(
      "password",
      "Please enter a password with only numbers and text and at leaset 5 characters."
    )
      .isLength({ min: 5 })
      .isAlphanumeric()
      .trim(),
    body("confirmPassword")
      .trim()
      .custom((value, { req }) => {
        if (value !== req.body.password)
          throw new Error("Passwords have to match!");
        return true;
      }),
  ],
  authController.postSignup
);

router.post("/logout", authController.postLogout);

router.get("/reset", authController.getReset);
router.post("/reset", authController.postReset);

router.get("/reset/:token", authController.getNewPassword);
router.post("/new-password", authController.postNewPassword);

module.exports = router;
