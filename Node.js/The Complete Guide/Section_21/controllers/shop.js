const fs = require("fs");
const path = require("path");
const PDFDocument = require("pdfkit");

const Product = require("../models/product");
const Order = require("../models/order");
const order = require("../models/order");

const ITEMS_PER_PAGE = 2;

exports.getIndex = (req, res, next) => {
  const page = req.query.page;
  console.log(page);
  Product.find()
    // skip : 괄호안에 있느 숫자만큼 데이터를 생략하고, 그뒤의 데이터부터 보여줌
    .skip((page - 1) * ITEMS_PER_PAGE)
    // limit : 가져오는 데이터 수를 제한함
    .limit(ITEMS_PER_PAGE)
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

exports.getInvoice = (req, res, next) => {
  const orderId = req.params.orderId;

  order
    .findById(orderId)
    .then((order) => {
      if (!order) return next(new Error("No order found"));
      if (order.user.userId.toString() !== req.user._id.toString())
        return next(new Error("Unauthorized"));

      const invoiceName = "invoice-" + orderId + ".pdf";
      const invoicePath = path.join("data", "invoices", invoiceName);

      // PDFDocument : PDF를 생성할 수 있게해주는 npm
      // PDF 파일을 서버에 저장하거나, 클라이언트에 전송할 수 있음
      const pdfDoc = new PDFDocument();
      res.setHeader("Content-Type", "application/pdf");
      res.setHeader(
        "Content-Disposition",
        "inline; filename='" + invoiceName + "'"
      );
      pdfDoc.pipe(fs.createWriteStream(invoicePath));
      pdfDoc.pipe(res);

      pdfDoc.fontSize(26).text("Invoice", {
        underline: true,
      });
      pdfDoc.text("------------------------------");
      let totalPrice = 0;
      order.products.forEach((prod) => {
        totalPrice += prod.quantity * prod.product.price;
        pdfDoc
          .fontSize(14)
          .text(
            `${prod.product.title} - ${prod.quantity} x $${prod.product.price}`
          );
      });
      pdfDoc.text("--------------------------------------------------------");
      pdfDoc.fontSize(20).text(`Total Price: $${totalPrice}`);
      pdfDoc.end();

      // * 이 방식은 서버에서 파일을 읽어들여 한번에 클라이언트로 보내주는 방법이며, 많은 요청이 발생하면 서버의 메모리 여유가 없음 *
      // 작은 파일을 전송할때 권장됨
      // fs.readFile(invoicePath, (err, data) => {
      //   if (err) return next(err);

      //   // 응답값이 pdf라는것을 브라우저에게 알림
      //   res.setHeader("Content-Type", "application/pdf");
      //   // attachment : 다운로드 형식
      //   // filename : 다운로드할때, 파일이름을 지정할 수 있음
      //   // res.setHeader(
      //   //   "Content-Disposition",
      //   //   `attachment; filename=${invoiceName}`
      //   // );
      //   //inline : 기본값이며, 브라우저에서 열리게됨
      //   res.setHeader(
      //     "Content-Disposition",
      //     "inline; filename='" + invoiceName + "'"
      //   );
      //   res.send(data);
      // });

      // * 이 방식은 서버에서 파일을 클라이언트로 스트리밍하여 클라이언트에서 하나의 파일이 되게 함. 작게 분할하여 연속적으로 보내는 방식. 서버의 메모리 여유가 있음 *
      // 큰 파일을 전송할때 권장됨
      // const file = fs.createReadStream(invoicePath);
      // res.setHeader("Content-Type", "application/pdf");
      // res.setHeader(
      //   "Content-Disposition",
      //   "inline; filename='" + invoiceName + "'"
      // );
      // file.pipe(res);
    })
    .catch((err) => next(err));
};

// exports.getCheckout = (req, res, next) => {
//   res.render("./shop/checkout", {
//     title: "Checkout",
//     path: "/checkout",
//   });
// };
