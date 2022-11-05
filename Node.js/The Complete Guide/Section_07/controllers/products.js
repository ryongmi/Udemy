const products = [];

exports.getAddProduct = (req, res, next) => {
  res.render("add-product", {
    title: "Add Product",
    path: "/admin/add-product",
    fromsCSS: true,
    productCSS: true,
    activeShop: true,
    activeProduct: true,
  });
};

exports.postAddProduct = (req, res, next) => {
  products.push({ title: req.body.title });

  // redirect() : 경로 재설정
  res.redirect("/");
};

exports.getProducts = (req, res, next) => {
  // 템플릿의 기본 폴더를 views로 잡아놔서 경로는 필요없음
  // pug 를 템플릿으로 사용하겠다고 명시하여 확장자는 필요없음
  // shop 파일을 보내며, 두번째 매개변수는 pug파일, 즉 html에서 사용할 변수값이다.
  // 파일이름과 같이 보냄으로써 shop 파일에서 'prods', 'title' 두개의 값을 사용할 수 있게됨
  res.render("shop", {
    prods: products,
    title: "Shop",
    path: "/",
    hasProduct: products.length > 0,
    productCSS: true,
    activeShop: true,
  });
};
