// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var site = (function () {
    'use strict';
    var checkInputButton, inputValue;

    var that = {};

    that.init = function () {
        checkInputButton = $("#SimpleInputFormButtonPost");
        inputValue = $("#DivisibleByTwoInput");

        checkInputButton.click(function () {
            checkInput(inputValue);
        });
    };

    that.submitForm = function (input) {
        $ajax({
            url:$("base").attr("href")+""
        });

    };

    return that;
})();