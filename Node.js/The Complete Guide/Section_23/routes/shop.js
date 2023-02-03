const express = require("express");

const router = express.Router();

const shopController = require("../controllers/shop");
const isAuth = require("../middleware/is-auth");

router.get("/", shopController.getIndex);

router.get("/products", shopController.getProducts);
// // : - Express에서 지원하는 동적 값
// // :productId - 이부분에 들어가는 어떤 값이라도 있으면 productId로 가져올수 있음
// // ex) url = /products/add => productId = add 가 됨.
router.get("/products/:productId", shopController.getProduct);

router.get("/cart", isAuth, shopController.getCart);
router.post("/cart", isAuth, shopController.postCart);
router.post("/cart-delete-item", isAuth, shopController.postCartDeleteProduct);

router.get("/orders", isAuth, shopController.getOrders);
router.post("/create-order", isAuth, shopController.postOrder);

router.get("/orders/:orderId", isAuth, shopController.getInvoice);
router.get("/checkout", isAuth, shopController.getCheckout);

module.exports = router;
