
/// <reference path="jquery-3.2.1.min.js" />
/// <reference path="jquery.unobtrusive-ajax.min.js" />

//function myFun()
//{

//    $("#userInput").keypress("click", function () {
//        var values = document.getElementById("userInput").value;
//        $.get("/Default/Index2", { userInput: values });
//    });
//}


function myFun()
{


    var values = document.getElementById("userInput").value;
    $.get("/Default/Index2", { userInput: values });
}


$(document).ready(function () {
    $("#Text1").keydown(function () {
        var searchText = $(this).val();
        debugger
        $.ajax({
            type: "Post",
            url: "/Default/Index?search=" + searchText,
            contentType: "html",
            success: function (response) {
                $("#resultDiv").html(response);
            }
        })
    })
})