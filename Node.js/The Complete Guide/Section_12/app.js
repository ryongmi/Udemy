const path = require("path");
const express = require("express");
const bodyParser = require("body-parser");

// express 함수 및 로직을 받아옴
const app = express();

const errorController = require("./controllers/error");

const adminRoutes = require("./routes/admin");
const shopRoutes = require("./routes/shop");

const sequelize = require("./util/database");
const Product = require("./models/product");
const User = require("./models/user");
const Cart = require("./models/cart");
const CartItem = require("./models/cart-item");
const Order = require("./models/order");
const OrderItem = require("./models/order-item");
// pug에서 image - src 같이 문자열로 넣어야 하는곳은 src="#{변수명}"으로 넣는것이 아니라 src=변수명 으로 넣으면 작동함

// 'pug' 라는 템플릿 엔진을 사용하겠다고 명시
// 내장 엔진이여서 set으로 함
app.set("view engine", "pug");

// 템플릿 엔진의 기본 폴더를 설정
// views 폴더가 기본 폴더로 설정됨
app.set("views", "views");

// bodyParser.urlencoded() : req.body 값을 분석해서 알려줌
app.use(bodyParser.urlencoded({ extended: false }));

// 정적으로 파일의 경로를 지정
// 정적의미 : 다른 미들웨어를 거쳐서 처리되지 않고, 바로 파일 시스템에 포워딩됨
app.use(express.static(path.join(__dirname, "public")));

app.use((req, res, next) => {
  User.findByPk(1)
    .then((user) => {
      req.user = user;
      next();
    })
    .catch((err) => console.log(err));
});

// 라우터안의 경로가 /admin으로 공통될때, 라우터 파일이 아닌, 호출할때 경로를 지정할 수 있음
// 이렇게 지정하게되면, /admin으로 경로가 시작되는 것들만 실행되게 할 수 있음
app.use("/admin", adminRoutes);
app.use(shopRoutes);

app.use(errorController.get404);

Product.belongsTo(User, { constraints: true, onDelete: "CASCADE" });
User.hasMany(Product);
User.hasOne(Cart);
Cart.belongsTo(User);
Cart.belongsToMany(Product, { through: CartItem });
Product.belongsToMany(Cart, { through: CartItem });
Order.belongsTo(User);
User.hasMany(Order);
Order.belongsToMany(Product, { through: OrderItem });
//Cart.hasMany(Product);

sequelize // sync() : sequelize에 정의한 모델을 살펴보고, 관련 테이블 및 관계를 생성한다
  // .sync({ force: true })
  .sync()
  .then((result) => {
    // 사용자가 1명이라도 있는지 확인하는 더미코드
    return User.findByPk(1);
  })
  .then((user) => {
    if (!user) {
      User.create({ name: "TurTle", email: "test@test.com" });
    }
    // Promise.resolve : 괄호안에 있는 값을 Promise로 넘겨줌, 명시를 위해 사용
    // return을 시키면 Promise에서 자동으로 검사함, 메서드 생략가능
    return Promise.resolve(user);
  })
  .then((user) => {
    return user.createCart();
  })
  .then((cart) => {
    // 요청 대기
    app.listen(3000);
  })
  .catch((err) => console.log(err));