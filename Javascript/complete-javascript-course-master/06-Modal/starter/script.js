'use strict';

const modal = document.querySelector('.modal');
const overlay = document.querySelector('.overlay');
const btnCloseModal = document.querySelector('.close-modal');
const btnOpenModal = document.querySelectorAll('.show-modal');

/* 
querySelector - 같은 이름의 클래스가 여러개 있을 경우, 가장 앞에 있는 컨트롤을 선택.
querySelectorAll - 같은 이름의 클래스가 여러개 있을 경우, 모든 컨트롤을 선택. (배열로 가져옴) 
*/

const openModal = function () {
  modal.classList.remove('hidden');
  overlay.classList.remove('hidden');
};

const closeModal = function () {
  modal.classList.add('hidden');
  overlay.classList.add('hidden');
};

for (let index = 0; index < btnOpenModal.length; index++)
  btnOpenModal[index].addEventListener('click', openModal);

btnCloseModal.addEventListener('click', closeModal);
overlay.addEventListener('click', closeModal);

document.addEventListener('keydown', function (e) {
  if (e.key === 'Escape' && !modal.classList.contains('hidden')) {
    closeModal();
  }
});
