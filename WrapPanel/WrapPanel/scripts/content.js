/// <reference path="jquery-2.1.1.js" />

function getContainer() {
    return $('#container');
}

function fillContent(onComplete)
{
    $.ajax({
        type: "POST",
        url: "/ContentService.asmx/GetContent",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, status, req, xml, xmlHttpRequest, responseXML) {
            var contentItems = data.d;
            var container = getContainer();
            container.empty();
            $.each(contentItems, function (index, contentItem) {
                container.append("<div class='contentBlock'>" + contentItem.Html + "</div>");
            });
            onComplete();
        },
        error: function (data, status, req, xml, xmlHttpRequest, responseXML) {
        }
    });
}