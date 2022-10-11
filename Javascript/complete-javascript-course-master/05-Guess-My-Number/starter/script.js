'use strict';

console.log(document.querySelector('.message').textContent);

document.querySelector('.message').textContent = '🎉 Correct Number!';

document.querySelector('.number').textContent = 13;
document.querySelector('.score').textContent = 10;

// 입력하는 컨트롤일때는 value를 사용해야함
document.querySelector('.guess').value = 23;
console.log(document.querySelector('.guess').value);
