const getDb = require("../util/database").getDb;

class Product {
  // constructor : 다른 언어에서 사용하는 생성자와 같은 역홀
  // 한 클래스안에 하나만 정의 할 수 있음
  // let a = new Product('test'); 를 싱행하면 'constructor'(생성자)가 실행되어 title이 'test'인 인스턴스가 생성됨
  constructor(title, imageUrl, description, price) {
    this.title = title;
    this.imageUrl = imageUrl;
    this.description = description;
    this.price = price;
  }

  save() {
    const db = getDb();

    // 아래의 삽입문을 먼저 실행하고 체인 처리를 완료한 뒤, 결과를 리턴함
    return (
      db
        .collection("products")
        // insertOne(this) : mongodb의 insert문 One은 하나를 삽입할때 사용, 여러개는 Many
        .insertOne(this)
        .then((result) => console.log(result))
        .catch((err) => console.log(err))
    );
  }
}

module.exports = Product;
