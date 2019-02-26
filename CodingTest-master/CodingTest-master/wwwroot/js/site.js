// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function HtmlData() {
    var uri = '/ajax/Data'

    //var xmlHttp = new XMLHttpRequest();
    //xmlHttp.addEventListener("click", callbackFunction);
    //xmlHttp.open('GET', uri);
    //xmlHttp.send();

    $.ajax({
        url: uri,
        type: 'GET',
        success: function (response) {
            $('#content').html(response);
        },
        error: function (jqXHR) {
            $('#content').append(jqXHR.status + "  " + jqXHR.statusText);
        }
    });
}
