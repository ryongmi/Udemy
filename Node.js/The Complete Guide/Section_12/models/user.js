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
    // const cartProduct = this.cart.items.findIndex((cp) => {
    //   return cp._id === product._id;
    // });
    const updatedCart = { items: { ...product, quantity: 1 } };
    const db = getDb();
    return db
      .collection("users")
      .updateOne(
        { _id: new mongodb.ObjectId(this._id) },
        { $set: { cart: updatedCart } }
      );
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
