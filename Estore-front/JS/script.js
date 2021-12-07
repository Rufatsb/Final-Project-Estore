$(document).ready(function() {

    let firstul = $(".firstul")
    let firstanchor = $(".firstanchor")
    let secondul = $(".secondul")
    let secondanchor = $(".secondanchor")
    let thirdul = $(".thirdul")
    let thirdanchor = $(".thirdanchor")


    firstanchor.click(function togglefunction() {
        firstul.toggle();
    });
    secondanchor.click(function togglefunction() {
        secondul.toggle();
    });
    thirdanchor.click(function togglefunction() {
        thirdul.toggle();
    });



    $('.slider-area').slick({
        autoplay: false,
        speed: 800,
        arrows: false,
        fade: true,
        dots: true

    });






});



function myFunction() {
    var x = document.getElementById("myLinks");
    var y = document.querySelector(".mobile-navbar-menu")
    if (y.style.height == "100%" && x.style.height == "100%") {
        y.style.height = "47px";
        x.style.height = "0%";
        x.style.transition = "0.4s"


    } else {
        y.style.height = "100%";
        x.style.height = "100%";
        x.style.transition = "0.4s"

    }
}


window.onscroll = function() { FixedFunction() };
var navbar = document.querySelector(".bottom-header");
var mobilenavbar = document.querySelector(".mobile-navbar")
var sticky = navbar.offsetTop;

function FixedFunction() {
    if (window.scrollY >= sticky) {
        navbar.classList.add("sticky")
    } else {
        navbar.classList.remove("sticky");


    }
}

filterSelection("all")

function filterSelection(c) {
    var x, i;
    x = document.getElementsByClassName("filterDiv");
    if (c == "all") c = "";
    // Add the "show" class (display:block) to the filtered elements, and remove the "show" class from the elements that are not selected
    for (i = 0; i < x.length; i++) {
        w3RemoveClass(x[i], "show");
        if (x[i].className.indexOf(c) > -1) w3AddClass(x[i], "show");
    }
}

// Show filtered elements
function w3AddClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
        if (arr1.indexOf(arr2[i]) == -1) {
            element.className += " " + arr2[i];
        }
    }
}

// Hide elements that are not selected
function w3RemoveClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
        while (arr1.indexOf(arr2[i]) > -1) {
            arr1.splice(arr1.indexOf(arr2[i]), 1);
        }
    }
    element.className = arr1.join(" ");
}

// Add active class to the current control button (highlight it)
var btnContainer = document.getElementById("filter-group");
var btns = btnContainer.getElementsByClassName("filter-item-btn");
var active = document.querySelector(".active")
active.style.color = "#ff003c";
for (var i = 0; i < btns.length; i++) {
    btns[i].addEventListener("click", function() {
        if (!btns[i].classList.contains(".active")) {
            btns[i].classList.add("active")
        } else {

        }

    });
}