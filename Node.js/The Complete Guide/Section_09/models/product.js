const fs = require("fs");
const path = require("path");

const p = path.join(
  path.dirname(process.mainModule.filename),
  "data",
  "products.json"
);

const getProductsFromFile = (cb) => {
  fs.readFile(p, (err, fileContent) => {
    if (err) cb([]);
    else cb(JSON.parse(fileContent));
  });
};

module.exports = class Product {
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
    getProductsFromFile((products) => {
      products.push(this);
      fs.writeFile(p, JSON.stringify(products), (arr) => {
        console.log(arr);
      });
    });
  }

  static fetchAll(cb) {
    getProductsFromFile(cb);
  }
};
