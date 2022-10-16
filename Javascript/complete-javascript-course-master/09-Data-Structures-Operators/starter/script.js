'use strict';

// Data needed for a later exercise
const flights =
  '_Delayed_Departure;fao93766109;txl2133758440;11:25+_Arrival;bru0943384722;fao93766109;11:45+_Delayed_Arrival;hel7439299980;fao93766109;12:05+_Departure;fao93766109;lis2323639855;12:30';

// 객체 속성명을 다른 변수 또는 값에서 불러와 설정
const weekdays = ['mon', 'tue', 'wed', 'thu', 'fri', 'sat', 'sun'];
const openingHour = {
  [weekdays[3]]: {
    open: 12,
    close: 22,
  },
  [weekdays[4]]: {
    open: 11,
    close: 23,
  },
  [`day-${2 + 4}`]: {
    open: 0, // Open 24 hours
    close: 24,
  },
};

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

// const ingredients = [
//   prompt("Let's make pasta! Ingredient 1?"), // 문자열 중간에 '(작은 따음표)를 사용하려면 ('Let\'s') -> 이렇게 \를 사용하고 쓰면됨.
//   prompt('Ingredient 2?'),
//   prompt('Ingredient 3?'),
// ];

// restaurant.orderPasta(...ingredients);

// 객체 복사
const newRestaurant = { foundedIn: 1998, ...restaurant, founder: 'Guiseppe' };
console.log(newRestaurant);

// 복사한 객체의 속성을 변경해도 원본 객체의 속성은 변함이 없음
const restaurantCopy = { ...restaurant };
restaurant.name = 'Ristorante Roma';
console.log(restaurantCopy.name);
console.log(restaurant.name);

// 왼쪽에서 Iterable을 써서 가져올수있음
const [w, e, ...others] = [1, 2, 3, 4, 5];
console.log(w, e, others);

// ...으로 배열을 가져오면 연속된 배열로 만들어지는것 같음. 그 인덱스에 맞게 변수할당을 해주면됨.
const [pizza, , Risotto, ...otherFood] = [
  ...restaurant.mainMenu,
  ...restaurant.starterMenu,
];
console.log(pizza, Risotto, otherFood);

function add(...numbers) {
  let total = 0;
  for (let index = 0; index < numbers.length; index++) {
    total += numbers[index];
  }
  console.log(total);
}

add(2, 3);
add(5, 3, 7, 2);
add(2, 3, 7, 0);

///////////////////////////////////////
// Coding Challenge #1

/* 
We're building a football betting app (soccer for my American friends 😅)!

Suppose we get data from a web service about a certain game (below). In this challenge we're gonna work with the data. So here are your tasks:

1. Create one player array for each team (variables 'players1' and 'players2')
2. The first player in any player array is the goalkeeper and the others are field players. For Bayern Munich (team 1) create one variable ('gk') with the goalkeeper's name, and one array ('fieldPlayers') with all the remaining 10 field players
3. Create an array 'allPlayers' containing all players of both teams (22 players)
4. During the game, Bayern Munich (team 1) used 3 substitute players. So create a new array ('players1Final') containing all the original team1 players plus 'Thiago', 'Coutinho' and 'Perisic'
5. Based on the game.odds object, create one variable for each odd (called 'team1', 'draw' and 'team2')
6. Write a function ('printGoals') that receives an arbitrary number of player names (NOT an array) and prints each of them to the console, along with the number of goals that were scored in total (number of player names passed in)
7. The team with the lower odd is more likely to win. Print to the console which team is more likely to win, WITHOUT using an if/else statement or the ternary operator.

TEST DATA FOR 6: Use players 'Davies', 'Muller', 'Lewandowski' and 'Kimmich'. Then, call the function again with players from game.scored

GOOD LUCK 😀
*/

const game = {
  team1: 'Bayern Munich',
  team2: 'Borrussia Dortmund',
  players: [
    [
      'Neuer',
      'Pavard',
      'Martinez',
      'Alaba',
      'Davies',
      'Kimmich',
      'Goretzka',
      'Coman',
      'Muller',
      'Gnarby',
      'Lewandowski',
    ],
    [
      'Burki',
      'Schulz',
      'Hummels',
      'Akanji',
      'Hakimi',
      'Weigl',
      'Witsel',
      'Hazard',
      'Brandt',
      'Sancho',
      'Gotze',
    ],
  ],
  score: '4:0',
  scored: ['Lewandowski', 'Gnarby', 'Lewandowski', 'Hummels'],
  date: 'Nov 9th, 2037',
  odds: {
    team1: 1.33,
    x: 3.25,
    team2: 6.5,
  },
};

// 1.
const [players1, players2] = game.players;
console.log(players1, players2);

// 2.
const [gk, ...fieldPlayers] = players1;

// 3.
const allPlayers = [...players1, ...players2];
console.log(allPlayers);

// 4.
const players1Final = [...players1, 'Thiago', 'Coutinho', 'Perisic'];
console.log(players1Final);

// 5.
const {
  odds: { team1, x: draw, team2 },
} = game;
console.log(team1, draw, team2);

// 6.
function printGoals(...players) {
  console.log(`${players.length} goals were scored`);
}

printGoals('Davies', 'Muller', 'Lewandowski', 'Kimmich');
printGoals(...game.scored);

// 7.
team1 < team2 && console.log('Team 1 is more likely to win');
team1 > team2 && console.log('Team 2 is more likely to win');

// foreach문과 같은 결과
const menu3 = [...restaurant.mainMenu, ...restaurant.starterMenu];
for (const item of menu3) console.log(item);

// entries() : 배열의 인덱스와 값을 분리시켜주는 메서드
for (const [i, el] of menu3.entries()) {
  console.log(`${i + 1}: ${el} `);
}
