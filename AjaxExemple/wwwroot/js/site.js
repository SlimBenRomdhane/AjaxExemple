// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.
$(function () {
    console.log("Page's ready");

    $("#ShowCustomerDetailsButton").click(function () {
        event.preventDefault();
        console.log("The ok buttun was clicked...");



        $.ajax({
            type: "POST",
            url: "/Customer/ShowMore",
            data: $("form").serialize(),
            success: function (data) {
                //console.log(data);
                $("#ShowCutomerDetailsArea").html(data);
            }
        });
    });

    

});