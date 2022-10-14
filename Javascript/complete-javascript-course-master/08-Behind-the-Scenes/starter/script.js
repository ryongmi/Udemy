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

// 함수의 매개변수(매개변수가 0개여도 가능)보다 더 많은 인수를 넘겨줄때,
// arguments에 배열형식으로 저장되어 사용할 수 있음. (화살표 함수는 불가능함, arguments를 사용하면 undefined 발생)
const addExpr = function (a, b) {
  console.log(arguments);
  return a + b;
};

addExpr(2, 5);
addExpr(2, 5, 8, 12);

const addArrow = (a, b) => {
  console.log(arguments);
  return a + b;
};
// addArrow(2, 5, 8);

const jessica = {
  firstName: 'Jessica',
  lastName: 'WillIams',
  age: 27,
  family: ['Alice', 'Bob'],
};

// Object.assign
// 독립된 객체로 복사하는 메서드
// 하지만 객체안에 객체가 있다면 그 객체는 같은 주소를 가리키는 복사본이됨. jessica - family가 그와 같은 경우
const jessicaCopy = Object.assign({}, jessica);
jessicaCopy.lastName = 'Davis';

jessicaCopy.family.push('Mary');
jessicaCopy.family.push('John');

console.log('Before marriage:', jessica);
console.log('After marriage:', jessicaCopy);
