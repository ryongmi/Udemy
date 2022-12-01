const mongodb = require("mongodb");
const getDb = require("../util/database").getDb;

class User {
  constructor(userName, userEmail, cart, id) {
    this.userName = userName;
    this.userEmail = userEmail;
    this.cart = cart;
    this._id = id;
  }

  save() {
    const db = getDb();

    return db.collection("users").insertOne(this);
  }

  addToCart(product) {
    console.log(this.cart.items);
    const cartProductIndex = this.cart.items.findIndex((cp) => {
      // DB에서 조회해 가져온 ObjectId는 자바스크립트에서는 스트링으로 작동하지만, 정확히는 스트링이 아니기 때문에 === 으로 조건을 주면 flase가 발생함
      return cp.productId.toString() === product._id.toString();
    });

    const updatedCartItems = [...this.cart.items];
    let newQuantity = 1;

    if (cartProductIndex >= 0) {
      newQuantity = this.cart.items[cartProductIndex].quantity + 1;
      updatedCartItems[cartProductIndex].quantity = newQuantity;
    } else {
      updatedCartItems.push({
        productId: new mongodb.ObjectId(product._id),
        quantity: newQuantity,
      });
    }

    const updatedCart = {
      items: updatedCartItems,
    };
    const db = getDb();
    return db
      .collection("users")
      .updateOne(
        { _id: new mongodb.ObjectId(this._id) },
        { $set: { cart: updatedCart } }
      );
  }

  getCart() {
    const db = getDb();
    const productIds = this.cart.items.map((i) => {
      return i.productId;
    });

    return db
      .collection("products")
      .find({ _id: { $in: productIds } })
      .toArray()
      .then((products) => {
        return products.map((p) => {
          return {
            ...p,
            quantity: this.cart.items.find((i) => {
              return i.productId.toString() === p._id.toString();
            }).quantity,
          };
        });
      });
  }

  static findById(userId) {
    const db = getDb();

    return db
      .collection("users")
      .findOne({
        _id: new mongodb.ObjectId(userId),
      })
      .then((user) => {
        console.log(user);
        return user;
      })
      .catch((err) => console.log(err));
  }
}

module.exports = User;
