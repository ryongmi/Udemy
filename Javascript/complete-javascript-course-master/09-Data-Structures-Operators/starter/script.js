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

// Property Names
// 객체의 속성명을 배열로 가져옴
const properties = Object.keys(openingHours);
console.log(properties);

let openStr = `We are open on ${properties.length} days: `;
for (const day of properties) {
  openStr += `${day}, `;
}
console.log(openStr);

// Property Values
// 객체의 속성을 배열로 가져옴
const values = Object.values(openingHours);
console.log(values);

// [키, 값]
// open, close는 객체 안에 있기때문에 {}를 써서 가져옴
const entries = Object.entries(openingHours);
for (const [key, { open, close }] of entries) {
  console.log(`On ${key} we open at ${open} and close at ${close}`);
}

///////////////////////////////////////
// Coding Challenge #2

/* 
Let's continue with our football betting app!

1. Loop over the game.scored array and print each player name to the console, along with the goal number (Example: "Goal 1: Lewandowski")
2. Use a loop to calculate the average odd and log it to the console (We already studied how to calculate averages, you can go check if you don't remember)
3. Print the 3 odds to the console, but in a nice formatted way, exaclty like this:
      Odd of victory Bayern Munich: 1.33
      Odd of draw: 3.25
      Odd of victory Borrussia Dortmund: 6.5
Get the team names directly from the game object, don't hardcode them (except for "draw"). HINT: Note how the odds and the game objects have the same property names 😉

BONUS: Create an object called 'scorers' which contains the names of the players who scored as properties, and the number of goals as the value. In this game, it will look like this:
      {
        Gnarby: 1,
        Hummels: 1,
        Lewandowski: 2
      }

GOOD LUCK 😀
*/

// 1.
for (const [index, name] of game.scored.entries()) {
  console.log(`Goal ${index + 1}: ${name}`);
}

// 2.
let average = 0;
for (const value of Object.values(game.odds)) average += value;
average /= Object.values(game.odds).length;
console.log(average);

// 3.
for (const [teamName, value] of Object.entries(game.odds)) {
  let teamStr = teamName === 'x' ? 'draw' : `victory ${game[teamName]}`;
  console.log(`Odd of ${teamStr}: ${value}`);
}

// BONUS
// So the solution is to loop over the array, and add the array elements as object properties, and then increase the count as we encounter a new occurence of a certain element
// 객체기 때문에 속성명을 이용하여 계산이 가능.
const scorers = {};
for (const player of game.scored) {
  scorers[player] ? scorers[player]++ : (scorers[player] = 1);
}

for (const [name, value] of Object.entries(scorers)) {
  console.log(name, value);
}

// Set은 중복된 값은 제외함
const orderSet = new Set([
  'Pasta',
  'Pizza',
  'Pizza',
  'Risotto',
  'Pasta',
  'Pizza',
]);
console.log(orderSet);

console.log(new Set('Jonas'));

console.log(orderSet.size);

// x.has('y') : x라는 Set개체 안에 y라는 값이 있는지 검사하는 메서드
// 있으면 true, 없으면 false
console.log(orderSet.has('Pizza'));
console.log(orderSet.has('Bread'));

// add() : 값 추가 메서드, 중복된 값은 추가안됨
orderSet.add('Garlic Bread');
orderSet.add('Garlic Bread');

// delete() : 값 삭제 메서드,
orderSet.delete('Risotto');
console.log(orderSet);

for (const order of orderSet) console.log(order);

// 기본적으로 배열을 Set으로 가져오면 객체로 정의되지만,
// [...] 을 이용해 풀어서 가져오면 배열로 정의됨
const staff = ['Waiter', 'Chef', 'Waiter', 'Manager', 'Chef', 'Waiter'];
const staffUnique = [...new Set(staff)];
console.log(staffUnique);

// Map : 키, 값 쌍을 이루는 데이터 타입
const rest = new Map();
rest.set('name', 'Classico Italiano');
rest.set(1, 'Firenze, Italy');
console.log(rest.set(2, 'Lisbon, Portugal'));

// 한번에 여러개의 값을 저장할수 있음
rest
  .set('categories', ['Italian', 'Pizzeria', 'Vegetarian', 'Organic'])
  .set('open', 11)
  .set('close', 23)
  .set(true, 'We are open :D')
  .set(false, 'We are closed :(');

console.log(rest);

// get(x) : x라는 키를 검색하여 값을 반환함 - 키의 타입도 맞아야함
//          x라는 키가 없다면 undefined 반한
console.log(rest.get('name'));
console.log(rest.get(true));
console.log(rest.get(321));

// x.has('y') : map개체에 y라는 키값이 있는지 검색
// 있으면 true, 없으면 false
console.log(rest.has('categories'));

// delete() : 값 삭제 메서드,
rest.delete(2);

// 배열은 객체이기 때문에 힙에 저장됨.
// 따라서 변수에 먼저 배열을 할당하고, Map에 set하지 않고,
// 배열 자체로 찾으려고 하면 주소가 달라, undefined가 발생함
const mapArr = [1, 2];
rest.set(mapArr, 'Test');
console.log(rest.get([1, 2]));
console.log(rest.get(mapArr));

// HTML 컨트롤도 저장할 수 있음
rest.set(document.querySelector('h1'), 'Heading');
console.log(rest);

const question = new Map([
  ['question', 'What is the best programming language in the world?'],
  [1, 'C'],
  [2, 'Java'],
  [3, 'JavaScript'],
  ['correct', 3],
  [true, 'Correct 🎉'],
  [false, 'Try again!'],
]);

console.log(Object.entries(openingHours));

// 객체를 Map으로 변환
const hoursMap = new Map(Object.entries(openingHours));
console.log(hoursMap);

console.log(question.get('question'));
for (const [key, value] of question) {
  if (typeof key === 'number') console.log(`Answer ${key}: ${value}`);
}
//const answer = Number(prompt('Your answer'));
const answer = 3;
console.log(question.get(question.get('correct') === answer));

// Convert map to array
// Map은 키, 값 쌍이기 때문에, 배열의 배열 형태로 나옴
console.log([...question]);
console.log([...question.keys()]);
console.log([...question.values()]);

///////////////////////////////////////
// Coding Challenge #3

/* 
Let's continue with our football betting app! This time, we have a map with a log of the events that happened during the game. The values are the events themselves, and the keys are the minutes in which each event happened (a football game has 90 minutes plus some extra time).

1. Create an array 'events' of the different game events that happened (no duplicates)
2. After the game has finished, is was found that the yellow card from minute 64 was unfair. So remove this event from the game events log.
3. Print the following string to the console: "An event happened, on average, every 9 minutes" (keep in mind that a game has 90 minutes)
4. Loop over the events and log them to the console, marking whether it's in the first half or second half (after 45 min) of the game, like this:
      [FIRST HALF] 17: ⚽️ GOAL

GOOD LUCK 😀
*/

const gameEvents = new Map([
  [17, '⚽️ GOAL'],
  [36, '🔁 Substitution'],
  [47, '⚽️ GOAL'],
  [61, '🔁 Substitution'],
  [64, '🔶 Yellow card'],
  [69, '🔴 Red card'],
  [70, '🔁 Substitution'],
  [72, '🔁 Substitution'],
  [76, '⚽️ GOAL'],
  [80, '⚽️ GOAL'],
  [92, '🔶 Yellow card'],
]);

// 1.
const eventSet = [...new Set(gameEvents.values())];
console.log(eventSet);

// 2.
gameEvents.delete(64);

// 3.
console.log(
  `An event happened, on average, every ${90 / gameEvents.size} minutes`
);
const time = [...gameEvents.keys()].pop();
console.log(time);
console.log(
  `An event happened, on average, every ${time / gameEvents.size} minutes`
);

// 4.
for (const [time, ev] of gameEvents) {
  const str = time <= 45 ? 'FIRST' : 'SECOND';
  console.log(`[${str} HALF] ${time}: ${ev}`);
}
