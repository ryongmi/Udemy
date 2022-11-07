const Product = require("../models/product");

exports.getIndex = (req, res, next) => {
  Product.fetchAll((products) => {
    // 첫번째 매개변수가 화면에 띄울 파일의 경로
    // app.js 파일에서 pug 템플릿 설정하면서 기본폴더를 views로 지정함
    res.render("./shop/index", {
      prods: products,
      title: "Shop",
      path: "/",
    });
  });
};

exports.getProducts = (req, res, next) => {
  Product.fetchAll((products) => {
    // 첫번째 매개변수가 화면에 띄울 파일의 경로
    // app.js 파일에서 pug 템플릿 설정하면서 기본폴더를 views로 지정함
    res.render("./shop/product-list", {
      prods: products,
      title: "All Products",
      path: "/products",
    });
  });
};

exports.getCart = (req, res, next) => {
  res.render("./shop/cart", {
    title: "Cart",
    path: "/cart",
  });
};

exports.getOrders = (req, res, next) => {
  res.render("./shop/orders", {
    title: "Orders",
    path: "/orders",
  });
};

exports.getCheckout = (req, res, next) => {
  res.render("./shop/checkout", {
    title: "Checkout",
    path: "/checkout",
  });
};
