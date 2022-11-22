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
  //Product.findAll()
  req.user
    .getProducts()
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
  // Product.create({
  //   title: title,
  //   price: price,
  //   imageUrl: imageUrl,
  //   description: description,
  //   userId: req.user.id,
  // })
  // createProduct : sequelize에서 관계를 정의하면 자동으로 메서드를 생성함
  // 데이터를 추가할때 userId 부분을 자동으로 할당해줌
  req.user
    .createProduct({
      title: title,
      price: price,
      imageUrl: imageUrl,
      description: description,
    })
    .then((result) => {
      console.log(result);
      // redirect() : 경로 재설정
      res.redirect("/admin/products");
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
  //Product.findByPk(prodId).then((product) => {
  //   if (!product) {
  //     return res.redirect("/");
  //   }

  //   res.render("./admin/edit-product", {
  //     title: "Edit Product",
  //     path: "/admin/edit-product",
  //     editing: editMode,
  //     product: product,
  //   });
  // };
  req.user
    // getProducts : 관계를 선언하면 생시는 메서드, products 테이블에서 조건으로 userId를 검색함
    .getProducts({ where: { id: prodId } })
    .then((products) => {
      const product = products[0];
      if (!product) {
        return res.redirect("/");
      }

      res.render("./admin/edit-product", {
        title: "Edit Product",
        path: "/admin/edit-product",
        editing: editMode,
        product: product,
      });
    })
    .catch((err) => console.log(err));

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
  Product.findByPk(prodId)
    .then((product) => {
      product.title = updateedTitle;
      product.price = updateedPrice;
      product.description = updateedDesc;
      product.imageUrl = updateedImageUrl;

      // save() : sequelize에서 제공하는 메서드
      // 변경된 값을 DB에 반영해줌
      return product.save();
    })
    .then((result) => {
      console.log("UPDATE PRODUCT");
      res.redirect("/admin/products");
    })
    // then()안에서 return을 했던 product.save()에서 발생한 에러까지 여기에 표시됨
    .catch((err) => console.log(err));

  // const updatedProduct = new Product(
  //   prodId,
  //   updateedTitle,
  //   updateedImageUrl,
  //   updateedDesc,
  //   updateedPrice
  // );
  // updatedProduct.save();
};

exports.postDeleteProduct = (req, res, next) => {
  const prodId = req.body.productId;
  //Product.deleteById(prodId);
  Product.findByPk(prodId)
    .then((product) => {
      // destroy() : 해당하는 모든 데이터를 삭제함, delete를 대신해서 사용됨
      return product.destroy();
    })
    .then((result) => {
      console.log("DESTROY PRODUCT");
      res.redirect("/admin/products");
    })
    .catch((err) => console.log(err));
};
