exports.getLogin = (req, res, next) => {
  const isLoggedIn = req.get("Cookie").trim().split("=")[1] === "true";

  res.render("auth/login", {
    title: "Login",
    path: "/login",
    isAuthenticated: isLoggedIn,
  });
};

exports.postLogin = (req, res, next) => {
  // Max-age=30 -> 헤더설정값, 쿠키 지속 시간 지정, 초단위로 지정한다
  res.setHeader("Set-Cookie", "loggedIn=true");
  res.redirect("/");
};
