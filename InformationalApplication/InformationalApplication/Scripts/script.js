$(document).ready(function () {
    var arrayOfId = ['#1', '#2', '#3', '#4', '#5', '#6', '#7', '#8', '#9', '#10', '#11', '#12', '#13', '#14', '#15', '#16', '#17', '#18', '#19'];
    for (var id in arrayOfId) {
        addEvent(arrayOfId[id]);
    }

})

function addEvent(selector) {
    $(selector).on('click', function (event) {
        event.preventDefault();
        getPage($(selector).attr("value"));
    })
}


function getPage(page) {
    $.ajax({
        type: 'POST',
        url: '/SiteContent/ReturnPartialView/',
        data: {pageName: page},
        success: function (html) {
            $(".body-text").html(html);
        },
        error: function () {
            $('.body-text').html("Error");
        }
    })
    return false;
}