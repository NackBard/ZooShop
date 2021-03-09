//Список действий, который открывается в хэдере при нажатии на иконку user
let userManage = document.querySelector('.user-manage');
let userIcon = document.querySelector('.user');
let body = document.querySelector('body');
let clickCounter = 0;

userIcon.onclick = function() {
	clickCounter += 1;
	userManage.classList.remove('hidden');
	let coords = userIcon.getBoundingClientRect();
	userManage.style.top = coords.bottom - 10 + "px";
	userManage.style.left = coords.left - 140 + "px";
}

body.onclick = function() {
	clickCounter += 1;
	if ((!userManage.classList.contains('hidden')) && (clickCounter > 2)){
		userManage.classList.add('hidden');
		clickCounter = 0;
	}
}

//Счетчик товаров в корзине
let tovarNumber = document.querySelector('.tovar-number');
let tovarAddBtns = document.querySelectorAll('.tovar-add');
let tovarDelBtns = document.querySelectorAll('.minus');
let quentitySections = document.querySelectorAll('.quentity');
let tovarCounter = 0;
let quentityCounter = 1;

/*for (let quentitySection of quentitySections) {
	let tovarPlusBtn = quentitySection.querySelector('.tovar-plus');
	let tovarMinusBtn = quentitySection.querySelector('.minus');
	let quentityValue = quentitySecion.querySelector('.quentity-value');

	if (quentityCounter <= 1) {
		tovarMinusBtn.disabled = "true";
	}
	else {
		tovarMinusBtn.disabled = "false";
	}

	tovarPlusBtn.onclick = function() {
		quentityCounter += 1;
		quentityValue.textContent = quentityCounter;
	}
	tovarMinusBtn.onclick = function() {
		quentityCounter -= 1;
		quentityValue.textContent = quentityCounter;
	}
}
*/

let bag = document.querySelector('.bag');
let tovarNumberBtn = document.querySelector('.bag button');
let coords = bag.getBoundingClientRect();
tovarNumberBtn.style.top = coords.top - 5 + "px";
tovarNumberBtn.style.left = coords.right - 20 + "px";

for (let tovarAdd of tovarAddBtns) {
	tovarAdd.onclick = function() {
		tovarCounter += 1;
		if (tovarCounter >= 1) {
			tovarNumberBtn.classList.remove('hidden');
		} else 
		{
			tovarNumberBtn.classList.add('hidden');
		}
		tovarNumber.textContent = tovarCounter;
	}
}

for (let tovarDel of tovarDelBtns) {
	tovarDel.onclick = function() {
		tovarCounter -= 1;
		if (tovarCounter == 0) {
			tovarNumber.classList.add('hidden');
		}
	}
}