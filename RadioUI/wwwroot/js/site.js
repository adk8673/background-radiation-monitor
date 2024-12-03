// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict";

var HomePage = (function ($) {
    var init = (dataUrl) => {
        $.ajax({
            url: dataUrl,
            method: "GET",
            contentType: "application/json; charset=utf-8",
            async: true,
            success: function (response) {
                $("#cpmResult").html();
                $("#usvResult").html();
            }
        });
    }

    return
    {
        Init: init
    };
}(jQuery));