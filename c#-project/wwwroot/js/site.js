// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function openContent(evt, pageName) {
    // khai bao bien
    var i, maincontent, tablinks;

    // lay tat thuoc tinh thuoc class="maincontent" va hide
    maincontent = document.getElementsByClassName("maincontent");
    for (i = 0; i < maincontent.length; i++) {
        maincontent[i].style.display = "none";
    }

    //
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    //
    document.getElementById(pageName).style.display = "block";
    evt.currentTarget.className += " active";
}

document.getElementById("defaultOpen").click();