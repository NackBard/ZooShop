//Для фильтров - показать кнопку "применить"
let filters = document.querySelectorAll('aside input');
let filterAdd = document.querySelector('.filterAdd');
let aside = document.querySelector('aside');
let addBtn = document.querySelector('.add');
let closeBtn = document.querySelector('.close');

for (let filter of filters ) {
	filter.onclick = function() {
		filterAdd.classList.remove('hidden');
		let filterCoords = filter.getBoundingClientRect();
		let asideCoords = aside.getBoundingClientRect();
		filterAdd.style.left = asideCoords.right + "px";
		filterAdd.style.top = filterCoords.top + pageYOffset - 10 + "px" ;
	}
}

addBtn.onclick = function() {
	filterAdd.classList.add('hidden');
}

closeBtn.onclick = function() {
	filterAdd.classList.add('hidden');
}


//Кнопка "наверх"
let limit = 500;
let goUpBtn = document.querySelector('.goUp');

window.onscroll = function() {
	if (pageYOffset >= limit) {
		goUpBtn.classList.remove('hidden');
	} 
	else {
		goUpBtn.classList.add('hidden');
	}
}


goUpBtn.onclick = function() {
	window.scrollTo(0, 0);
}

//Переключение страниц
let pageNumbers = document.querySelectorAll('.page-number');

for (let pageNumber of pageNumbers) {
	pageNumber.onclick = function() {
		if(!pageNumber.classList.contains('page-active')) {
			let pageActive = document.querySelector('.page-active');
			pageActive.classList.remove('page-active');
			pageNumber.classList.add('page-active');
			
		}
	}
}