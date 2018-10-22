// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function isChecked() {
    // Get the checkbox
    var checkBox = document.getElementById("checkFName");
    var checkBox2 = document.getElementById("checkSurname");
    var checkBox3 = document.getElementById("checkLegalSurname");
    var checkBox4 = document.getElementById("checkDoB");

    // Get the output text
    var inputBox = document.getElementById("dropDownFName");
    var inputBox2 = document.getElementById("dropDownSurname");
    var inputBox3 = document.getElementById("dropDownLegalSurname");
    var inputBox4 = document.getElementById("dropDownDoB");


    // If the checkbox is checked, disable select options
    if (checkBox.checked == true) {

        inputBox.disabled = false;
        
    }
    else {
        inputBox.disabled = true;
    }
    // If the checkbox is checked, disable select options
    if (checkBox2.checked == true) {

        inputBox2.disabled = false;
    }
    else {
        inputBox2.disabled = true;
    }
    // If the checkbox is checked, disable select options
    if (checkBox3.checked == true) {

        inputBox3.disabled = false;
    }
    else {
        inputBox3.disabled = true;
    }
    // If the checkbox is checked, disable select options
    if (checkBox4.checked == true) {

        inputBox4.disabled = false;
    }
    else {
        inputBox4.disabled = true;
    }
}
