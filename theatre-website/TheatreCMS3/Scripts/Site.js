// This is for the SignIn.cshtml view to count the number of Developers on the page.

document.addEventListener("DOMContentLoaded", function () {
    var numPersonsElement = document.getElementById("NumPersons");
    var personsList = document.getElementById("PersonList");
    var numPersons = personsList.getElementsByTagName("p").length;
    numPersonsElement.textContent = numPersons;
});
