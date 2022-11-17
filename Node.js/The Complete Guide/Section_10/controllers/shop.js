const Product = require("../models/product");
const Cart = require("../models/cart");

exports.getIndex = (req, res, next) => {
  Product.findAll()
    .then((products) => {
      res.render("./shop/index", {
        prods: products,
        title: "Shop",
        path: "/",
      });
    })
    .catch((err) => console.log(err));

  // Product.fetchAll()
  //   .then(([rows, fileData]) => {
  //     res.render("./shop/index", {
  //       prods: rows,
  //       title: "Shop",
  //       path: "/",
  //     });
  //   })
  //   .catch((err) => console.log(err));
};

exports.getProducts = (req, res, next) => {
  // findAll() : sequlize에서 지원하는 전체 검색 메서드
  //             매개변수 객체를 넘겨서 조건을 추가할 수 있음
  Product.findAll()
    .then((products) => {
      res.render("./shop/product-list", {
        prods: products,
        title: "All Products",
        path: "/products",
      });
    })
    .catch((err) => console.log(err));

  // DB 사용했을때
  // Product.fetchAll()
  //   .then(([rows, fileData]) => {
  //     res.render("./shop/product-list", {
  //       prods: rows,
  //       title: "All Products",
  //       path: "/products",
  //     });
  //   })
  //   .catch((err) => {
  //     console.log(err);
  //   });
};

exports.getProduct = (req, res, next) => {
  // productId - shop.js에서 사용한 동적 url변수
  // :productId - 이렇게 사용
  const prodId = req.params.productId;

  // sequelize 5 에서는 findById를 사용하는데, 6에서부터는 findByPk를 사용함
  // findByPk() : 기본적으로 프라이머리키를 조건으로 검색함
  Product.findByPk(prodId)
    .then((product) => {
      res.render("./shop/product-Detail", {
        product: product,
        title: product.title,
        path: "/products",
      });
    })
    .catch((err) => console.log(err));

  // findAll을 사용하여 조건 검색 하는 법
  // Product.findAll({
  //   where: {
  //     id: prodId,
  //   },
  // })
  //   .then((products) => {
  //     console.log(products);
  //     res.render("./shop/product-Detail", {
  //       // findAll을 사용해 조건검색을 하면, 찾는 데이터만 오는것이 아니라 배열형식으로 다른 데이터도 따라오기때문에, 0번째있는것을 사용해야함
  //       product: products[0],
  //       title: products[0].title,
  //       path: "/products",
  //     });
  //   })
  //   .catch((err) => console.log(err));
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
