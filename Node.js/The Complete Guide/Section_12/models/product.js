const mongodb = require("mongodb");
const getDb = require("../util/database").getDb;

class Product {
  // constructor : 다른 언어에서 사용하는 생성자와 같은 역홀
  // 한 클래스안에 하나만 정의 할 수 있음
  // let a = new Product('test'); 를 싱행하면 'constructor'(생성자)가 실행되어 title이 'test'인 인스턴스가 생성됨
  constructor(title, imageUrl, description, price, id, userId) {
    this.title = title;
    this.imageUrl = imageUrl;
    this.description = description;
    this.price = price;
    this._id = id ? new mongodb.ObjectId(id) : null;
    this.userId = userId;
  }

  save() {
    const db = getDb();
    let dbOp;
    if (this._id) {
      dbOp = db
        .collection("products")
        .updateOne({ _id: this._id }, { $set: this });
    } else {
      dbOp = db
        .collection("products")
        // insertOne(this) : mongodb의 insert문 One은 하나를 삽입할때 사용, 여러개는 Many
        .insertOne(this);
    }
    return dbOp
      .then((result) => console.log(result))
      .catch((err) => console.log(err));
  }

  static fetchAll() {
    const db = getDb();

    return db
      .collection("products")
      .find()
      .toArray()
      .then((products) => {
        return products;
      })
      .catch((err) => console.log(err));
  }

  static findById(prodId) {
    const db = getDb();

    return (
      db
        .collection("products")
        .find({
          // mongodb는 데이터를 BSON형식으로 저장함
          // Id는 db에서 자동을 저장되는데, ObjectId형식으로 저장되기 때문에, 형식을 맞춰서 조회를 해야함
          // 시간상으로 먼저 저장된 데이터의 id보다 뒤에 저장된 id가 더 높음
          _id: mongodb.ObjectId(prodId),
        })
        // next : 검색한 데이터 중 첫번째 데이터를 가져옴
        .next()
        .then((product) => {
          return product;
        })
        .catch((err) => console.log(err))
    );
  }

  static deleteById(prodId) {
    const db = getDb();
    return db
      .collection("products")
      .deleteOne({
        _id: new mongodb.ObjectId(prodId),
      })
      .then()
      .catch((err) => console.log(err));
  }
}

module.exports = Product;
