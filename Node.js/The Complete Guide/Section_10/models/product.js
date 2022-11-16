const db = require("../util/database");

const Cart = require("../models/cart");

module.exports = class Product {
  // constructor : 다른 언어에서 사용하는 생성자와 같은 역홀
  // 한 클래스안에 하나만 정의 할 수 있음
  // let a = new Product('test'); 를 싱행하면 'constructor'(생성자)가 실행되어 title이 'test'인 인스턴스가 생성됨
  constructor(id, title, imageUrl, description, price) {
    this.id = id;
    this.title = title;
    this.imageUrl = imageUrl;
    this.description = description;
    this.price = price;
  }

  save() {
    return db.execute(
      // SQL삽입 공격을 막기위해 VALUES에 ?를 넣고, 파라미터로 값을 넣어, mysql엔진에서 파싱을 통해 값을 검사하고 넣어줌
      "INSERT INTO products (title, price, description, imageUrl) VALUES (?, ?, ?, ?)",
      [this.title, this.price, this.description, this.imageUrl]
    );
  }

  static deleteById(id) {}

  static fetchAll() {
    // then(), catch() : promise를 사용할 때 쓸수 있는 메서드
    return db.execute("SELECT * FROM products");
    // .then((result) => {
    //   // 쿼리를 실행하고 나서 실행되는 구문
    //   // 0번째에는 쿼리로 받아온 데이터가 들어있고, 1번째에는 테이블?의 메타데이터?가 들어있음.
    //   // 따라서 0번째만 사용하면됨
    //   // console.log(result[0], result[1]);
    //   console.log(result[0]);
    // })
    // .catch((err) => {
    //   // 쿼리 실행도중 에러가 났을때 실행되는 구문
    //   console.log(err);
    // });
  }

  static findById(id) {
    return db.execute("SELECT * FROM products WHERE id = ?", [id]);
  }
};
