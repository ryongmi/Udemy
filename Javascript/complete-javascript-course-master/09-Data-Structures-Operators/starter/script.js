'use strict';

// Data needed for a later exercise
const flights =
  '_Delayed_Departure;fao93766109;txl2133758440;11:25+_Arrival;bru0943384722;fao93766109;11:45+_Delayed_Arrival;hel7439299980;fao93766109;12:05+_Departure;fao93766109;lis2323639855;12:30';

// Data needed for first part of the section
const restaurant = {
  name: 'Classico Italiano',
  location: 'Via Angelo Tavanti 23, Firenze, Italy',
  categories: ['Italian', 'Pizzeria', 'Vegetarian', 'Organic'],
  starterMenu: ['Focaccia', 'Bruschetta', 'Garlic Bread', 'Caprese Salad'],
  mainMenu: ['Pizza', 'Pasta', 'Risotto'],

  order: function (starterIndex, mainIndex) {
    return [this.starterMenu[starterIndex], this.mainMenu[mainIndex]];
  },

  // 객체를 매개변수로 받았을때, 객체를 분해하여 속성으로만 사용
  // 기본값 설정법
  orderDelivery: function ({
    starterIndex = 1,
    mainIndex = 0,
    time = '20:00',
    address,
  }) {
    console.log(
      `Order received! ${this.starterMenu[starterIndex]} and ${this.mainMenu[mainIndex]} will be delivered to ${address} at ${time}`
    );
  },

  orderPasta: function (ing1, ing2, ing3) {
    console.log(
      `Here is your declicious pasta with ${ing1}, ${ing2} and ${ing3}`
    );
  },

  openingHours: {
    thu: {
      open: 12,
      close: 22,
    },
    fri: {
      open: 11,
      close: 23,
    },
    sat: {
      open: 0, // Open 24 hours
      close: 24,
    },
  },
};

// 객체 함수 호출방법
restaurant.orderDelivery({
  time: '22:30',
  address: 'Via del Sole, 21',
  mainIndex: 2,
  starterIndex: 2,
});

const arr = [2, 3, 4];
const a = arr[0];
const b = arr[1];
const c = arr[2];

// 변수 선언하면서 배열의 값을 할당받는 방법
const [x, y, z] = arr;
console.log(x, y, z);

// [] 안에 있는 순서대로 restaurant.categories[0], restaurant.categories[1], restaurant.categories[2]의 값을 할당받음
let [main, , secondary] = restaurant.categories;
console.log(main, secondary);

// 변수의 값을 교환하는 방법
[main, secondary] = [secondary, main];
console.log(main, secondary);

const [starter, mainCourse] = restaurant.order(2, 0);
console.log(starter, mainCourse);

// 배열 안의 배열 값을 가져오는 방법
const nested = [2, 4, [5, 6]];
const [i, , [j, k]] = nested;
console.log(i, j, k);

// 기본값 설정
const [p = 1, q = 1, r = 1] = [8, 9];
console.log(p, q, r);

// const {x} = y
// 가져오고 싶은 y객체안에 있는 속성명을 {}안에 정의하면, 속성값을 지닌, 속성명과 동일한 변수가 생성됨.
// 만약 객체안에 속성명이 없다면 값을 할당받지못해 undefined가 발생.
const { name, openingHours, categories } = restaurant;
console.log(name, openingHours, categories);

// 객체명과 다른 변수명으로 사용하고 싶을 때 사용
const {
  name: restaurantName,
  openingHours: hours,
  categories: tags,
} = restaurant;
console.log(restaurantName, hours, tags);

// 기본값 넣는법
const { menu = [], starterMenu: starters = [] } = restaurant;
console.log(menu, starters);

// 이미 선언되어 있는 변수에 속성값 할당하는법
// () 를 사용하지 않으면 에러발생
let m = 111;
let n = 999;
const obj = { m: 22, n: 11, v: 5 };
({ m, n } = obj);
console.log(m, n);

// 객체안에 객체가 선언되어 있을때 값을 가져오는 방법.
const {
  //fri: { open, close },
  fri: { open: o, close: cl },
} = openingHours;
console.log(o, cl);

// Iterable : ... ( 배열, 문자열 등 )
// 배열의 전체 인수를 풀어서 가져옴
const ar = [7, 8, 9];
const newArr = [1, 2, ...ar];
console.log(newArr);
console.log(...newArr);

// 배열 합치기
const newMenu = [...restaurant.mainMenu, 'Gnocci'];
console.log(newMenu);

const menuCopy = [...restaurant.mainMenu];
const menu2 = [...restaurant.starterMenu, ...menuCopy];
console.log(menu2);

const ingredients = [
  prompt("Let's make pasta! Ingredient 1?"), // 문자열 중간에 '(작은 따음표)를 사용하려면 ('Let\'s') -> 이렇게 \를 사용하고 쓰면됨.
  prompt('Ingredient 2?'),
  prompt('Ingredient 3?'),
];

restaurant.orderPasta(...ingredients);

// 객체 복사
const newRestaurant = { foundedIn: 1998, ...restaurant, founder: 'Guiseppe' };
console.log(newRestaurant);

// 복사한 객체의 속성을 변경해도 원본 객체의 속성은 변함이 없음
const restaurantCopy = { ...restaurant };
restaurant.name = 'Ristorante Roma';
console.log(restaurantCopy.name);
console.log(restaurant.name);
