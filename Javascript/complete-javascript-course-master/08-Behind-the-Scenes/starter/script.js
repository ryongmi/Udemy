'use strict';
/* 
const jonas = {
  year: 1991,
  calcAge: function () {
    console.log(this);
  },
};
jonas.calcAge();

const matilda = {
  year: 2017,
};

// 미리 정의되어 있지않아도, 다른 객체의 함수를 가져올수 있음.
// this 키워드 : 항상 호출하는 객체를 가리킴.
matilda.calcAge = jonas.calcAge;

// 일반 함수에서 (객체에 속해있지 않는 함수) this 키워드를 사용하면, 소유자?를 찾지못해 에러가 발생함.
const f = jonas.calcAge();
f();
 */

const jonas = {
  firstName: 'Jonas',
  year: 1991,
  calcAge: function () {
    console.log(this);

    // 함수안에 함수일때 this 키워드 쓰는 방법 1 -> self 변수에 this를 할당하지 않고, isMillenial 함수에서 바로 this를 쓰려하면, undefined가 뜸
    // const self = this;
    // const isMillenial = function () {
    //   console.log(self);
    // };
    // isMillenial();

    // 함수안에 함수일때 this 키워드 쓰는 방법 2 -> 화살표 함수를 사용
    const isMillenial = () => {
      console.log(this);
    };
    isMillenial();
  },

  greet: () => console.log(`Hey ${this.firstName}`),
};
jonas.greet();
jonas.calcAge();
