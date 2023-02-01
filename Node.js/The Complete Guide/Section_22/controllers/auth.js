const crypto = require("crypto");
const bcrypt = require("bcryptjs");
//const nodemailer = require("nodemailer");
//const sendgridTransport = require("nodemailer-sendgrid-transport");
const { validationResult } = require("express-validator");

const User = require("../models/user");

// const transporter = nodemailer.createTransport(
//   sendgridTransport({
//     auth: {
//       api_key:
//         "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", // sendgird api key
//     },
//   })
// );

exports.getLogin = (req, res, next) => {
  let message = req.flash("error");

  if (message.length > 0) message = message[0];
  else message = null;

  res.render("auth/login", {
    title: "Login",
    path: "/login",
    errorMessage: message,
    oldInput: {
      email: "",
      password: "",
    },
    validationErrors: [],
  });
};

exports.getSignup = (req, res, next) => {
  // flash(키값) : 설정했던 키값을 가지고 내용을 가져오는데, 그게 배열 형태로 들어옴
  let message = req.flash("error");
  if (message.length > 0) message = message[0];
  else message = null;

  res.render("auth/signup", {
    path: "/signup",
    pageTitle: "Signup",
    errorMessage: message,
    oldInput: {
      email: "",
      password: "",
      confirmPassword: "",
    },
    validationErrors: [],
  });
};

// exports.postLogin = (req, res, next) => {
//   // Max-age=30 -> 헤더설정값, 쿠키 지속 시간 지정, 초단위로 지정한다
//   //res.setHeader("Set-Cookie", "loggedIn=true");
//   // const email = req.body.email;
//   // const password = req.body.password;

//   User.findById("63cfde49d7b76a52513e8d32")
//     .then((user) => {
//       req.session.isLoggedIn = true;
//       req.session.user = user;

//       // 세션을 저장하는 메서드
//       // 일반적으로는 알아서 저장되기 때문에 필요없지만, 세션이 확실히 저장되고 나서 진행해야 할 경우 사용
//       req.session.save((err) => {
//         console.log(err);
//         res.redirect("/");
//       });
//     })
//     .catch((err) => console.log(err));
// };

exports.postLogin = (req, res, next) => {
  const email = req.body.email;
  const password = req.body.password;

  const errors = validationResult(req);
  if (!errors.isEmpty()) {
    return res.status(422).render("auth/login", {
      path: "/login",
      pageTitle: "Login",
      errorMessage: errors.array()[0].msg,
      oldInput: {
        email: email,
        password: password,
      },
      validationErrors: errors.array(),
    });
  }

  User.findOne({ email: email })
    .then((user) => {
      if (!user) {
        return res.status(422).render("auth/login", {
          path: "/login",
          pageTitle: "Login",
          errorMessage: "Invalid email or password.",
          oldInput: {
            email: email,
            password: password,
          },
          validationErrors: [],
        });
      }
      bcrypt
        .compare(password, user.password)
        .then((doMatch) => {
          if (doMatch) {
            req.session.isLoggedIn = true;
            req.session.user = user;

            // 세션을 저장하는 메서드
            // 일반적으로는 알아서 저장되기 때문에 필요없지만, 세션이 확실히 저장되고 나서 진행해야 할 경우 사용
            return req.session.save((err) => {
              console.log(err);
              res.redirect("/");
              // Product.find()
              //   .then((products) => {
              //     res.render("./shop/index", {
              //       prods: products,
              //       title: "Shop",
              //       path: "/",
              //     });
              //   })
              //   .catch((err) => {
              //     const error = new Error(err);
              //     error.httpStatusCode = 500;
              //     // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
              //     return next(error);
              //   });
            });
          }
          return res.status(422).render("auth/login", {
            path: "/login",
            pageTitle: "Login",
            errorMessage: "Invalid email or password.",
            oldInput: {
              email: email,
              password: password,
            },
            validationErrors: [],
          });
        })
        .catch((err) => {
          console.log(err);
          res.redirect("/login");
        });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postSignup = (req, res, next) => {
  const email = req.body.email;
  const password = req.body.password;
  const errors = validationResult(req);
  console.log(errors.array());

  if (!errors.isEmpty()) {
    return res.status(422).render("auth/signup", {
      path: "/signup",
      pageTitle: "Signup",
      errorMessage: errors.array()[0].msg,
      oldInput: {
        email: email,
        password: password,
        confirmPassword: req.body.confirmPassword,
      },
      validationErrors: errors.array(),
    });
  }

  // bcrypt : 해시 암호화를 해주는 npm
  // hash(암호화할 값, 암호화를 진행할 횟수), 12번이면 강의기준 높은 보안이라고함
  // 비동기식이기때문에 작업이 끝나고 프로미스로 반환받아 진행
  bcrypt
    .hash(password, 12)
    .then((hashedPassword) => {
      const user = new User({
        email: email,
        password: hashedPassword,
        cart: { items: [] },
      });
      return user.save();
    })
    .then((result) => {
      // transporter.sendMail({
      //   to: email,                                   // 받을 주소
      //   from: email,                                 // 발신 주소 -> 문제는 sendgird에서 인증받은 메일주소만 가능하기 때문에, 홈페이지에서 설정을 해줘야함. 귀찮아서 그냥 넘어감
      //   subject: "Signup succeeded",                 // 제목
      //   html: "<h1>You succeefully signed up!</h1>", // 내용
      // });
      res.redirect("./login");
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postLogout = (req, res, next) => {
  // destroy : session 패키지에서 지원하는 메서드, 세션 정보를 삭제함
  req.session.destroy((err) => {
    console.log(err);
    res.redirect("/");
  });
};

exports.getReset = (req, res, next) => {
  // flash(키값) : 설정했던 키값을 가지고 내용을 가져오는데, 그게 배열 형태로 들어옴
  let message = req.flash("error");
  if (message.length > 0) message = message[0];
  else message = null;

  res.render("auth/reset", {
    path: "/reset",
    pageTitle: "Reset Password",
    errorMessage: message,
  });
};

exports.postReset = (req, res, next) => {
  crypto.randomBytes(32, (err, buffer) => {
    if (err) {
      console.log(err);
      return res.redirect("/reset");
    }
    const token = buffer.toString("hex");
    User.findOne({ email: req.body.email })
      .then((user) => {
        if (!user) {
          req.flash("error", "No account with that email found.");
          return res.redirect("/reset");
        }
        user.resetToken = token;
        user.resetTokenExpiration = Date.now() + 3_600_000; // 현재시간 + 1시간을 한것
        return user.save();
      })
      .then((result) => {
        res.redirect("/");
        // transporter.sendMail({
        //   to: req.body.email,
        //   from: "shop@node-complete.com",
        //   subject: "Password reset",
        //   html: `
        //     <p>You requested a password reset</p>
        //     <p>Click this <a href="http://localhost:3000/reset/${token}">link</a> to set a new password.</p>
        //   `,
        // });
      })
      .catch((err) => {
        const error = new Error(err);
        error.httpStatusCode = 500;
        // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
        return next(error);
      });
  });
};

exports.getNewPassword = (req, res, next) => {
  const token = req.params.token;
  User.findOne({
    resetToken: token,
    resetTokenExpiration: { $gt: Date.now() }, // $gt Date.now() 보다 크면 참이됨
  })
    .then((user) => {
      // flash(키값) : 설정했던 키값을 가지고 내용을 가져오는데, 그게 배열 형태로 들어옴
      let message = req.flash("error");
      if (message.length > 0) message = message[0];
      else message = null;

      res.render("auth/new-password", {
        path: "/new-password",
        pageTitle: "New Password",
        errorMessage: message,
        userId: user._id.toString(),
        passwordToken: token,
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postNewPassword = (req, res, next) => {
  const userId = req.body.userId;
  const newPassword = req.body.password;
  const passwordToken = req.body.passwordToken;
  let resetUser;

  User.findOne({
    resetToken: passwordToken,
    resetTokenExpiration: { $gt: Date.now() },
    _id: userId,
  })
    .then((user) => {
      resetUser = user;
      return bcrypt.hash(newPassword, 12);
    })
    .then((hashedPassword) => {
      resetUser.password = hashedPassword;
      resetUser.resetToken = undefined;
      resetUser.resetTokenExpiration = undefined;
      return resetUser.save();
    })
    .then((result) => {
      res.redirect("/login");
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};
