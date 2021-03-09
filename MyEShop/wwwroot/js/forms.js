//Для форм - показать окно с повторной отправкой кода
let formPopup = document.querySelector('.popup');
let sendCodeBtn = document.querySelector('.showPopup');

sendCodeBtn.onclick = function () {
  
  formPopup.classList.remove('hidden');
};


