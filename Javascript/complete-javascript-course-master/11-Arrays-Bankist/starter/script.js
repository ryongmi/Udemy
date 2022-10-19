'use strict';

/////////////////////////////////////////////////
/////////////////////////////////////////////////
// BANKIST APP

// Data
const account1 = {
  owner: 'Jonas Schmedtmann',
  movements: [200, 450, -400, 3000, -650, -130, 70, 1300],
  interestRate: 1.2, // %
  pin: 1111,
};

const account2 = {
  owner: 'Jessica Davis',
  movements: [5000, 3400, -150, -790, -3210, -1000, 8500, -30],
  interestRate: 1.5,
  pin: 2222,
};

const account3 = {
  owner: 'Steven Thomas Williams',
  movements: [200, -200, 340, -300, -20, 50, 400, -460],
  interestRate: 0.7,
  pin: 3333,
};

const account4 = {
  owner: 'Sarah Smith',
  movements: [430, 1000, 700, 50, 90],
  interestRate: 1,
  pin: 4444,
};

const accounts = [account1, account2, account3, account4];

// Elements
const labelWelcome = document.querySelector('.welcome');
const labelDate = document.querySelector('.date');
const labelBalance = document.querySelector('.balance__value');
const labelSumIn = document.querySelector('.summary__value--in');
const labelSumOut = document.querySelector('.summary__value--out');
const labelSumInterest = document.querySelector('.summary__value--interest');
const labelTimer = document.querySelector('.timer');

const containerApp = document.querySelector('.app');
const containerMovements = document.querySelector('.movements');

const btnLogin = document.querySelector('.login__btn');
const btnTransfer = document.querySelector('.form__btn--transfer');
const btnLoan = document.querySelector('.form__btn--loan');
const btnClose = document.querySelector('.form__btn--close');
const btnSort = document.querySelector('.btn--sort');

const inputLoginUsername = document.querySelector('.login__input--user');
const inputLoginPin = document.querySelector('.login__input--pin');
const inputTransferTo = document.querySelector('.form__input--to');
const inputTransferAmount = document.querySelector('.form__input--amount');
const inputLoanAmount = document.querySelector('.form__input--loan-amount');
const inputCloseUsername = document.querySelector('.form__input--user');
const inputClosePin = document.querySelector('.form__input--pin');

function displayMovements(movements) {
  // innerHTML : 개체의 모든 HTML 내용을 가져옴
  // 지금은 빈문자를 할당함
  containerMovements.innerHTML = '';

  movements.forEach(function (mov, i) {
    // 금액에 따라 css 및 문자를 다르게 적용하기 위해 사용
    const type = mov > 0 ? 'deposit' : 'withdrawal';

    const html = `
        <div class="movements__row">
          <div class="movements__type movements__type--${type}">${
      i + 1
    } ${type}</div>
          <div class="movements__value">${mov}</div>
        </div>
    `;

    // insertAdjacentHTML(x, y) : html에 문자를 삽입할 수 있는 메서드
    // x: 위치, y: 삽입할 내용
    containerMovements.insertAdjacentHTML('afterbegin', html);
  });
}

displayMovements(account1.movements);

/////////////////////////////////////////////////
/////////////////////////////////////////////////
// LECTURES

const currencies = new Map([
  ['USD', 'United States dollar'],
  ['EUR', 'Euro'],
  ['GBP', 'Pound sterling'],
]);

const movements = [200, 450, -400, 3000, -650, -130, 70, 1300];

/////////////////////////////////////////////////

let arr = ['a', 'b', 'c', 'd', 'e'];

// slice(x, y) : 배열의 x번째 인덱스부터 y-1번째 인덱스까지 배열을 반환함
console.log(arr.slice(2));
console.log(arr.slice(2, 4));
console.log(arr.slice(-2));

// splice(x, y) : 배열의 x번째 인덱스부터 y만큼의 배열을 반환하고, 반환한 범위의 원본 값을 삭제함
console.log(arr.splice(2, 3));
console.log(arr);

arr = ['a', 'b', 'c', 'd', 'e'];
const arr2 = ['j', 'i', 'h', 'g', 'f'];

// reverse() : 배열의 앞뒤를 바꿔서 원본에 저장함
console.log(arr2);
console.log(arr2.reverse());
console.log(arr2);

// concat() : 두개의 배열을 하나의 배열로 만들어 반환함
// x.concat(y) : x가 먼저 y가 뒤에 할당되어 배열 생성됨
const letters = arr.concat(arr2);
console.log(letters);
console.log([...arr, ...arr2]);

// join(x) : 배열에 저장된 값들의 사이사이에 x로 연결하여 문자열을 반환함
console.log(letters.join(' - '));

// at() : 배열 인덱스를 지정하여 값을 반환받는 메서드, 문자열도 작동
const arrAt = [23, 11, 64];
console.log(arrAt[0]);
console.log(arrAt.at(0));
console.log(arrAt.at(-1));

// forEach() 배열의 길이만큼 반복하는 메서드
// 배열의 값을 함수의 매개변수로 넘겨줌
// function(단일값, 현재 인덱스 번호, 주체 배열의 전체 배열)
// for of 와 다른점 : forEach는 중간에 멈출수가 없고, 배열 길이만큼 반복됨 - retunr, break를 이용하면 되지않나?
movements.forEach(function (movement, index, array) {
  if (movement > 0)
    console.log(`Movement ${index + 1}: You deposited ${movement}`);
  else console.log(`Movement ${index + 1}: You withdrew ${Math.abs(movement)}`);
});

// Map
currencies.forEach(function (value, key, map) {
  console.log(`${key}: ${value}`);
});

// Set
const currenciesUnique = new Set(['USD', 'GBP', 'USD', 'EUR', 'EUR']);
console.log(currenciesUnique);

// Set에는 Key값, 인덱스가 없기 때문에 value와 key값이 동일하게 나옴
// _ : 던지기 변수, 사용하지 않을 변수를 정의한것
currenciesUnique.forEach(function (value, _, map) {
  console.log(`${value}: ${value}`);
});
