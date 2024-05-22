
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

// Lightbox (Modal and Slideshow)

function openModalLight() {
    document.getElementById('myModalLight').style.display = "block";
  }
  
  function closeModalLight() {
    document.getElementById('myModalLight').style.display = "none";
  }
  
  
  var slideIndexLight = 1;
  showDivsLight(slideIndexLight);
  
  function plusDivsLight(n) {
    showDivsLight(slideIndexLight += n);
  }
  
  
  function currentDivLight(n) {
    showDivsLight(slideIndexLight = n);
  }
  
  function showDivsLight(n) {
    var i;
    var x = document.getElementsByClassName("mySlidesLight");
    var dots = document.getElementsByClassName("demoLight");
    var captionText = document.getElementById("captionLight");
    if (n > x.length) {slideIndexLight = 1}
    if (n < 1) {slideIndexLight = x.length}
    for (i = 0; i < x.length; i++) {
       x[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
       dots[i].className = dots[i].className.replace(" w3-opacity-off", "");
  
    }
    x[slideIndexLight-1].style.display = "block";
    dots[slideIndexLight-1].className += " w3-opacity-off";
    captionText.innerHTML = dots[slideIndexLight-1].alt;
  }

  // Animation

  startAnim("Normal")
  function startAnim(animName) {
    var i;
    var x = document.getElementsByClassName("animTest");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    document.getElementById(animName).style.display = "block";
  }

  // Filter
  function myFunction2() {
    var input, filter, table, tr, td, i;
    input = document.getElementById('myInput');
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName('tr');
    for (i = 0; i < tr.length; i++) {
      td = tr[i].getElementsByTagName('td')[0];
      if (td) {
        if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
          tr[i].style.display = '';
        } else {
          tr[i].style.display = 'none';
        }
      }
    }
  }

  function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
  }