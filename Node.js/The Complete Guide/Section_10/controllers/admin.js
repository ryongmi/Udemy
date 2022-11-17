const Product = require("../models/product");

exports.getAddProduct = (req, res, next) => {
  res.render("./admin/edit-product", {
    title: "Add Product",
    path: "/admin/add-product",
    editing: false,
    product: new Product("", "", "", ""),
  });
};

exports.getProducts = (req, res, next) => {
  Product.findAll()
    .then((products) => {
      res.render("./admin/products", {
        title: "Admin Products",
        path: "/admin/products",
        prods: products,
      });
    })
    .catch((err) => {
      console.log(err);
    });

  // Product.fetchAll((products) => {
  //   res.render("./admin/products", {
  //     title: "Admin Products",
  //     path: "/admin/products",
  //     prods: products,
  //   });
  // });
};

exports.postAddProduct = (req, res, next) => {
  const title = req.body.title;
  const imageUrl = req.body.imageUrl;
  const description = req.body.description;
  const price = req.body.price;

  // create() : sequlize에서 지원하는 메서드
  //            객체로 데이터를 보내면 INSERT를 해줌
  Product.create({
    title: title,
    price: price,
    imageUrl: imageUrl,
    description: description,
  })
    .then((result) => {
      console.log(result);
      // redirect() : 경로 재설정
      res.redirect("/");
    })
    .catch((err) => console.log(err));
};

exports.getEditProduct = (req, res, next) => {
  // req.query : 쿼리 매개변수로 url에서 주고 받고 할 수 있음
  // url?edit=true -> edit은 키값이되며, true값을 지님
  const editMode = req.query.edit;

  if (!editMode) {
    return res.redirect("/");
  }

  const prodId = req.params.productId;
  Product.findByPk(prodId).then((product) => {
    if (!product) {
      return res.redirect("/");
    }

    res.render("./admin/edit-product", {
      title: "Edit Product",
      path: "/admin/edit-product",
      editing: editMode,
      product: product,
    });
  });

  // Product.findById(prodId, (product) => {
  //   if (!product) {
  //     return res.redirect("/");
  //   }

  //   res.render("./admin/edit-product", {
  //     title: "Edit Product",
  //     path: "/admin/edit-product",
  //     editing: editMode,
  //     product: product,
  //   });
  // });
};

exports.postEditProduct = (req, res, next) => {
  const prodId = req.body.productId;
  const updateedTitle = req.body.title;
  const updateedPrice = req.body.price;
  const updateedImageUrl = req.body.imageUrl;
  const updateedDesc = req.body.description;
  const updatedProduct = new Product(
    prodId,
    updateedTitle,
    updateedImageUrl,
    updateedDesc,
    updateedPrice
  );
  updatedProduct.save();

  res.redirect("/admin/products");
};

exports.postDeleteProduct = (req, res, next) => {
  const prodId = req.body.productId;
  Product.deleteById(prodId);

  res.redirect("/admin/products");
};
