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




});



function myFunction() {
    var x = document.getElementById("myLinks");
    var y = document.querySelector(".mobile-navbar-menu")
    if (y.style.height == "100%" && x.style.height == "100%") {
        y.style.height = "47px";
        x.style.height = "0%";
    } else {

        y.style.height = "100%";
        x.style.height = "100%";
    }
}

// When the user scrolls the page, execute myFunction
window.onscroll = function() { FixedFunction() };

// Get the navbar
var navbar = document.querySelector(".bottom-header");
var mobilenavbar = document.querySelector(".mobile-navbar")
    // Get the offset position of the navbar
var sticky = navbar.offsetTop;
var msticky = mobilenavbar.offsetTop;
// Add the sticky class to the navbar when you reach its scroll position. Remove "sticky" when you leave the scroll position
function FixedFunction() {
    if (window.scrollY >= sticky) {
        navbar.classList.add("sticky")
    }
    // } else if (window.scrollY >= msticky) {
    //     mobilenavbar.classList.add("msticky")
    // } 
    else {
        navbar.classList.remove("sticky");
        mobilenavbar.classList.remove("msticky");

    }
}