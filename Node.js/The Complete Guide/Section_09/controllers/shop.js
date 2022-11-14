const Product = require("../models/product");
const Cart = require("../models/cart");

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

exports.getProduct = (req, res, next) => {
  // productId - shop.js에서 사용한 동적 url변수
  // :productId - 이렇게 사용
  const prodId = req.params.productId;

  Product.findById(prodId, (product) => {
    res.render("./shop/product-Detail", {
      product: product,
      title: product.title,
      path: "/products",
    });
  });
};

exports.getCart = (req, res, next) => {
  Cart.getCart((cart) => {
    Product.fetchAll((products) => {
      const cartProducts = [];
      for (product of products) {
        const cartProductData = cart.products.find(
          (prod) => prod.id === product.id
        );
        if (cartProductData) {
          cartProducts.push({ productData: product, qty: cartProductData.qty });
        }
      }

      res.render("./shop/cart", {
        title: "Your Cart",
        path: "/cart",
        products: cartProducts,
      });
    });
  });
};

exports.postCart = (req, res, next) => {
  const prodId = req.body.productId;

  Product.findById(prodId, (product) => {
    Cart.addProcut(prodId, product.price);
  });

  res.redirect("/cart");
};

exports.postCartDeleteProduct = (req, res, next) => {
  const prodId = req.body.productId;
  Product.findById(prodId, (product) => {
    Cart.deleteProduct(prodId, product.price);
    res.redirect("/cart");
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
