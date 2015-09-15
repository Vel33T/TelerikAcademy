(function ($) {
    $.fn.treeView = function () {
        $("li").on("click", function (ev) {
            ev.stopPropagation();
            $(this).find(">ul").toggle(400);
        });
        return $(this);
    }
})(jQuery);

$(document).ready(function () {
    $("ul").hide();
    $('#treeView').treeView().show(1000);
    $("ul").parent().children("a").css("color", "blue");
});