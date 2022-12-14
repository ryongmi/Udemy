const express = require("express");

const router = express.Router();

const adminController = require("../controllers/admin");

// Express 라우터에 getAddProduct 함수를 저장하는 구문
// get - /add-product 의 요청이 들어올때 함수가 실행되게끔 설정
router.get("/add-product", adminController.getAddProduct);
router.get("/products", adminController.getProducts);

router.post("/add-product", adminController.postAddProduct);

router.get("/edit-product/:productId", adminController.getEditProduct);
router.post("/edit-product", adminController.postEditProduct);

router.post("/delete-product", adminController.postDeleteProduct);

module.exports = router;
