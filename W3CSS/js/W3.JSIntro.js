
// Progress Bars
function move()
{
    var elem = document.getElementById('myBar');
    var width = 1;
    var id = setInterval(frame, 10);
    function frame() {
        if (width == 100 ) {
            clearInterval(id);
        }else {
            width++;
            elem.style.width = width + '%';
            elem.innerHTML = width * 1 + '%'
        }
    }
}

//Dropdown

function myDropFunc() {
    var x = document.getElementById("Demodrop");
    if (x.classList) {
        x.classList.toggle("w3-show");
    } else {
        // Fallback for IE9
        if  (x.className.indexOf("w3-show") == -1)
            x.className += " w3-show";
        else
            x.className = x.className.replace(" w3-show", "");
    }
}

//Accordions
function myAccFunc(id) {
    var x = document.getElementById(id);
    if (x.classList) {
        x.classList.toggle("w3-show");
        x.previousElementSibling.classList.toggle("w3-dark-grey");
    } else {
        // Fallback for IE9 and earlier
        if (x.className.indexOf("w3-show") == -1)
            x.className += " w3-show";
        else
            x.className = x.className.replace(" w3-show", "");
    }
}

//Tabs
function openCity(evt, cityName) {
    var i;
    var x = document.getElementsByClassName("city");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    var activebtn = document.getElementsByClassName("testbtn");
    for (i = 0; i < x.length; i++) {
        activebtn[i].className = activebtn[i].className.replace(" w3-red", "");
    }
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " w3-red";
}

function openImg(imgName) {
    var i, x;
    x = document.getElementsByClassName("picture");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    document.getElementById(imgName).style.display = "block";
}

// Slideshows
var slideIndex = 1;

function plusDivs(n) {
slideIndex = slideIndex + n;
showDivs(slideIndex);
}

function currentDiv(n) {
  showDivs(slideIndex = n);
}

function showDivs(n) {
  var i;
  var x = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("demodots");
  if (n > x.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = x.length} ;
  for (i = 0; i < x.length; i++) {
     x[i].style.display = "none";  
  }
  for (i = 0; i < dots.length; i++) {
     dots[i].className = dots[i].className.replace(" w3-white", "");
  }
  x[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " w3-white";
}

showDivs(1);