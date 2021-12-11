$(document).ready(function() {
    let firstul = $(".firstul")
    let firstanchor = $(".firstanchor")
    let secondul = $(".secondul")
    let secondanchor = $(".secondanchor")
    let thirdul = $(".thirdul")
    let thirdanchor = $(".thirdanchor")


    firstanchor.on("click", function togglefunction() {
        firstul.toggle();
    });
    secondanchor.on("click", function togglefunction() {
        secondul.toggle();
    });
    thirdanchor.on("click", function togglefunction() {
        thirdul.toggle();
    });



    $('.slider-area').slick({
        autoplay: false,
        speed: 800,
        arrows: false,
        fade: true,
        dots: true

    });
    $('.owl-carousel').owlCarousel({
        loop: true,
        center: true,
        items: 1,
        margin: 0,
        autoplay: true,
        nav: true,
        dots: false,
        autoplayTimeout: 3000,
        smartSpeed: 450,

    });


    let owlnext = $(".owl-next span");
    let owlprev = $(".owl-prev span");

    function addicon() {


        owlnext.replaceWith("<i></i>")
        owlprev.replaceWith("<i></i>")
        let nexticon = $(".owl-next i")
        let previcon = $(".owl-prev i")
        nexticon.addClass("fas").addClass("fa-chevron-right")
        previcon.addClass("fas").addClass("fa-chevron-left")

    }
    addicon()


    let categorylist = $(".category-list")
    let categorylistitem = $(".category-list-items")
    let categorylisticon = $(".category-list i")
    let pricelist = $(".price-list")
    let pricelistitem = $(".price-list-items")
    let pricelisticon = $(".price-list i")

    function rotatefunction() {
        if (categorylisticon.hasClass("fa-caret-down")) {
            categorylisticon.removeClass("fa-caret-down").addClass("fa-caret-up")
        } else if (pricelisticon.hasClass("fa-caret-down")) {
            pricelisticon.removeClass("fa-caret-down").addClass("fa-caret-up")
        } else {
            categorylisticon.removeClass("fa-caret-up").addClass("fa-caret-down");
            pricelisticon.removeClass("fa-caret-up").addClass("fa-caret-down");


        }
    }
    categorylist.click(function togglefunction() {
        categorylistitem.slideToggle();
        rotatefunction();

    });

    pricelist.click(function togglefunction() {
        pricelistitem.slideToggle();
        rotatefunction();


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