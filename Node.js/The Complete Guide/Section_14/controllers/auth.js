const User = require("../models/user");

exports.getLogin = (req, res, next) => {
  res.render("auth/login", {
    title: "Login",
    path: "/login",
    //isAuthenticated: false,
  });
};

exports.postLogin = (req, res, next) => {
  // Max-age=30 -> 헤더설정값, 쿠키 지속 시간 지정, 초단위로 지정한다
  //res.setHeader("Set-Cookie", "loggedIn=true");
  User.findById("63948b43c358582e6ac735ef")
    .then((user) => {
      req.session.isLoggedIn = true;
      req.session.user = user;

      // 세션을 저장하는 메서드
      // 일반적으로는 알아서 저장되기 때문에 필요없지만, 세션이 확실히 저장되고 나서 진행해야 할 경우 사용
      req.session.save((err) => {
        console.log(err);
        res.redirect("/");
      });
    })
    .catch((err) => console.log(err));
};

exports.postLogout = (req, res, next) => {
  // destroy : session 패키지에서 지원하는 메서드, 세션 정보를 삭제함
  req.session.destroy((err) => {
    console.log(err);
    res.redirect("/");
  });
};
