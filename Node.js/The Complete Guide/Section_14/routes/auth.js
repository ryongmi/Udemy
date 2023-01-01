const express = require("express");

const router = express.Router();
const authContoroller = require("../controllers/auth");

router.get("/login", authContoroller.getLogin);
router.post("/login", authContoroller.postLogin);

router.post("/logout", authContoroller.postLogout);

module.exports = router;
