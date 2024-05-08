
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