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