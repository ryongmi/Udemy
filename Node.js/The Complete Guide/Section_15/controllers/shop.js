const Product = require("../models/product");
const Order = require("../models/order");

exports.getIndex = (req, res, next) => {
  Product.find()
    .then((products) => {
      res.render("./shop/index", {
        prods: products,
        title: "Shop",
        path: "/",
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.getProducts = (req, res, next) => {
  Product.find()
    .then((products) => {
      res.render("./shop/product-list", {
        prods: products,
        title: "All Products",
        path: "/products",
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.getProduct = (req, res, next) => {
  // productId - shop.js에서 사용한 동적 url변수
  // :productId - 이렇게 사용
  const prodId = req.params.productId;

  Product.findById(prodId)
    .then((product) => {
      res.render("./shop/product-Detail", {
        product: product,
        title: product.title,
        path: "/products",
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.getCart = (req, res, next) => {
  req.user
    .populate("cart.items.productId")
    .then((user) => {
      const products = user.cart.items;
      res.render("./shop/cart", {
        title: "Your Cart",
        path: "/cart",
        products: products,
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postCart = (req, res, next) => {
  const prodId = req.body.productId;
  Product.findById(prodId)
    .then((product) => {
      return req.user.addToCart(product);
    })
    .then((result) => {
      res.redirect("./cart");
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postCartDeleteProduct = (req, res, next) => {
  const prodId = req.body.productId;

  req.user
    .deleteItemFromCart(prodId)
    .then((result) => res.redirect("/cart"))
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postOrder = (req, res, next) => {
  req.user
    .populate("cart.items.productId")
    .then((user) => {
      const products = user.cart.items.map((i) => {
        return { quantity: i.quantity, product: { ...i.productId._doc } };
      });
      const order = new Order({
        user: {
          email: req.user.email,
          userId: req.user,
        },
        products: products,
      });

      return order.save();
    })
    .then((result) => {
      return req.user.clearCart();
    })
    .then(() => {
      res.redirect("./orders");
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.getOrders = (req, res, next) => {
  Order.find({ "user.userId": req.user._id })
    .then((orders) => {
      res.render("./shop/orders", {
        title: "Orders",
        path: "/orders",
        orders: orders,
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

// exports.getCheckout = (req, res, next) => {
//   res.render("./shop/checkout", {
//     title: "Checkout",
//     path: "/checkout",
//   });
// };
