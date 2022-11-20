const Sequelize = require("sequelize");
const sequelize = require("../util/database");

const Cart = sequelize.define("cart", {
  id: {
    type: Sequelize.INTEGER,
    autoIncrement: true,
    allowNull: false,
    primaryKey: true,
  },
});

module.exports = Cart;

// const fs = require("fs");
// const path = require("path");

// const p = path.join(
//   path.dirname(process.mainModule.filename),
//   "data",
//   "cart.json"
// );

// module.exports = class Cart {
//   static addProcut(id, productPrice) {
//     fs.readFile(p, (err, fileContent) => {
//       let cart = { products: [], totalPrice: 0 };
//       if (!err) {
//         // 파일이 있다면 JSON 형식으로 변환하여 가져옴
//         cart = JSON.parse(fileContent);
//       }

//       // Cart에 담을 id와 같은 id가 있는지 검색
//       const existingProductIndex = cart.products.findIndex(
//         (prod) => prod.id === id
//       );
//       const existingProduct = cart.products[existingProductIndex];
//       let updatedProduct;

//       if (existingProduct) {
//         // 같은 id가 있다면 번호를 1 올리고 내용을 가져옴
//         updatedProduct = { ...existingProduct };
//         // 번호를 1 올리고
//         updatedProduct.qty += 1;
//         // 기존 파일을 할당하고
//         cart.products = [...cart.products];
//         // 새로 추가한 항목을 기존에 있던 같은 항목에 업데이트 시킴
//         cart.products[existingProductIndex] = updatedProduct;
//       } else {
//         // 같은 id가 없다면 가져온 id로 새로 생성함
//         updatedProduct = { id: id, qty: 1 };
//         cart.products = [...cart.products, updatedProduct];
//       }

//       // 총 금액에 추가하려는 금액을 더한다
//       // 변수 앞에 + 를 붙이면 정수형으로 바뀜
//       cart.totalPrice += +productPrice;

//       fs.writeFile(p, JSON.stringify(cart), (err) => {
//         console.log(err);
//       });
//     });
//   }

//   static deleteProduct(id, productPrice) {
//     fs.readFile(p, (err, fileContent) => {
//       if (err) {
//         // 찾는 id의 상품이 없다면 리턴
//         return;
//       }

//       const updatedCart = { ...JSON.parse(fileContent) };
//       const product = updatedCart.products.find((prod) => prod.id === id);

//       // 장바구니에 찾는 제품이 없다면 리턴
//       if (!product) return true;

//       const productQty = product.qty;
//       updatedCart.products = updatedCart.products.filter(
//         (prod) => prod.id !== id
//       );
//       updatedCart.totalPrice -= productPrice * productQty;

//       fs.writeFile(p, JSON.stringify(updatedCart), (err) => {
//         console.log(err);
//       });
//     });
//   }

//   static getCart(cb) {
//     fs.readFile(p, (err, fileContent) => {
//       const cart = JSON.parse(fileContent);
//       if (err) {
//         cb(null);
//       } else {
//         cb(cart);
//       }
//     });
//   }
// };
