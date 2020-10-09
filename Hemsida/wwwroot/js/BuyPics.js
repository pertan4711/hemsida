$(document).ready(function () {
    //alert("Hej hopp");
    console.log("Hej hopp");

    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;
    var theForm = $("#theForm");
    theForm.hide();


    //var button = document.getElementById("buyButton");
    //button.addEventListener("click", function () {
    //    console.log("Buying item");
    //});
    var button = $("#buyButton");
    button.on("click", () => {
        console.log("Buying item");
    })

    //var productInfo = document.getElementsByClassName("product-props");
    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", () => {
        $popupForm.fadeToggle(250);
    });
});