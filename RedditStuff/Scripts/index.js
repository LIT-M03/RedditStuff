$(function() {
    $("tr:gt(0)").hover(function () {
        var rowTop = $(this).position().top;

        $("#comment").css('top', (rowTop + 20) + 'px');
        $("#comment").css('left', '20px');
        var comment = $(this).data('comment');
        $("#comment").text(comment);
        $("#comment").fadeIn(500);
    }, function () {
        $("#comment").fadeOut(500);
    });
});