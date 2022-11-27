const express = require("express");

const router = express.Router();

const shopController = require("../controllers/shop");

router.get("/", shopController.getIndex);

router.get("/products", shopController.getProducts);
// : - Express에서 지원하는 동적 값
// :productId - 이부분에 들어가는 어떤 값이라도 있으면 productId로 가져올수 있음
// ex) url = /products/add => productId = add 가 됨.
router.get("/products/:productId", shopController.getProduct);

// router.get("/cart", shopController.getCart);
// router.post("/cart", shopController.postCart);
// router.post("/cart-delete-item", shopController.postCartDeleteProduct);

// router.get("/orders", shopController.getOrders);
// router.post("/create-order", shopController.postOrder);

// router.get("/checkout", shopController.getCheckout);

module.exports = router;
