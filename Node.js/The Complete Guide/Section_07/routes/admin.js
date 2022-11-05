const express = require("express");

const router = express.Router();

const productsController = require("../controllers/products");

// Express 라우터에 getAddProduct 함수를 저장하는 구문
// get - /add-product 의 요청이 들어올때 함수가 실행되게끔 설정
router.get("/add-product", productsController.getAddProduct);
router.post("/add-product", productsController.postAddProduct);

module.exports = router;
