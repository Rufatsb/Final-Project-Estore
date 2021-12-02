// $(document).ready(function() {
//     var scroll_start = 0;
//     var startchange = $('#startchange');
//     var offset = startchange.offset();
//     if (startchange.length) {
//         $(document).scroll(function() {
//             scroll_start = $(this).scrollTop();
//             if (scroll_start > offset.top) {

//             } else {

//             }
//         });
//     }
// });

function myFunction() {
    var x = document.getElementById("myLinks");
    if (x.style.display === "block") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}