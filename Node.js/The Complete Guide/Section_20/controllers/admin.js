// const mongoose = require("mongoose");
const { validationResult } = require("express-validator");

const Product = require("../models/product");

exports.getAddProduct = (req, res, next) => {
  res.render("./admin/edit-product", {
    title: "Add Product",
    path: "/admin/add-product",
    editing: false,
    hasError: false,
    errorMessage: null,
    validationErrors: [],
  });
};

exports.postAddProduct = (req, res, next) => {
  const title = req.body.title;
  const image = req.file;
  const description = req.body.description;
  const price = req.body.price;

  const errors = validationResult(req);
  if (!errors.isEmpty()) {
    return res.status(422).render("./admin/edit-product", {
      title: "Add Product",
      path: "/admin/add-product",
      editing: false,
      hasError: true,
      product: {
        //_id: new mongoose.Types.ObjectId(""), 일부러 에러를 만드는 부분, 이미 생성된 품목 id로 생성
        title: title,
        image: image,
        description: description,
        price: price,
      },
      errorMessage: errors.array()[0].msg,
      validationErrors: errors.array(),
    });
  }

  const product = new Product({
    title: title,
    price: price,
    description: description,
    image: image,
    // Mongoose에서는 id를 정확히 지정하지 않고, user를 넘겨도, db에서 자동으로 id를 찾아 넣어줌
    userId: req.user,
    //userId: req.user._id,
  });

  product
    .save()
    .then((result) => {
      console.log("Created Product");
      res.redirect("/admin/products");
    })
    .catch((err) => {
      // 500 : 서버측 에러가 발생했다는 코드
      // return res.status(500).render("./admin/edit-product", {
      //   title: "Add Product",
      //   path: "/admin/add-product",
      //   editing: false,
      //   hasError: true,
      //   product: {
      //     title: updateedTitle,
      //     imageUrl: updateedImageUrl,
      //     description: updateedDesc,
      //     price: updateedPrice,
      //     _id: prodId,
      //   },
      //   errorMessage: "Database operation failed, please try again",
      //   validationErrors: [],
      // });
      // req.redirect("/500");
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.getProducts = (req, res, next) => {
  Product.find({ userId: req.user._id })
    // - 를 사용하면 그 데이터는 보여주지 않음.
    //.select("title price -_id")
    // 왼쪽에 있는것을 참조하여 다양한 데이터를 가져옴.
    // 오른쪽에 있는 데이터만 보여줌
    // _id는 명시적으로 빼지 않는 이상, 항상 가져옴
    //.populate("userId", "name")
    .then((products) => {
      res.render("./admin/products", {
        title: "Admin Products",
        path: "/admin/products",
        prods: products,
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.getEditProduct = (req, res, next) => {
  // req.query : 쿼리 매개변수로 url에서 주고 받고 할 수 있음
  // url?edit=true -> edit은 키값이되며, true값을 지님
  const editMode = req.query.edit === "true";

  if (!editMode) {
    return res.redirect("/");
  }

  const prodId = req.params.productId;

  Product.findById(prodId)
    .then((product) => {
      if (!product) {
        return res.redirect("/");
      }

      res.render("./admin/edit-product", {
        title: "Edit Product",
        path: "/admin/edit-product",
        editing: editMode,
        product: product,
        hasError: false,
        errorMessage: null,
        validationErrors: [],
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postEditProduct = (req, res, next) => {
  const prodId = req.body.productId;
  const updateedTitle = req.body.title;
  const updateedPrice = req.body.price;
  const updateedImageUrl = req.body.imageUrl;
  const updateedDesc = req.body.description;

  const errors = validationResult(req);
  if (!errors.isEmpty()) {
    return res.status(422).render("./admin/edit-product", {
      title: "Edit Product",
      path: "/admin/edit-product",
      editing: true,
      hasError: true,
      product: {
        title: updateedTitle,
        imageUrl: updateedImageUrl,
        description: updateedDesc,
        price: updateedPrice,
        _id: prodId,
      },
      errorMessage: errors.array()[0].msg,
      validationErrors: errors.array(),
    });
  }

  Product.findById(prodId)
    .then((product) => {
      if (product.userId.toString() !== req.user._id.toString())
        return res.redirect("/");

      product.title = updateedTitle;
      product.price = updateedPrice;
      product.imageUrl = updateedImageUrl;
      product.description = updateedDesc;

      return product.save().then((result) => {
        console.log("Updated Product");
        res.redirect("/admin/products");
      });
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};

exports.postDeleteProduct = (req, res, next) => {
  const prodId = req.body.productId;

  //Product.findByIdAndRemove(prodId)
  Product.deleteOne({ _id: prodId, userId: req.user._id })
    .then(() => {
      console.log("Delete PRODUCT");
      res.redirect("/admin/products");
    })
    .catch((err) => {
      const error = new Error(err);
      error.httpStatusCode = 500;
      // next()에 매개변수를 넣고 실행하면 에러 처리 미들웨어로 보내짐
      return next(error);
    });
};
