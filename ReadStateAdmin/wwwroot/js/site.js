// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.
$('.o-modal').click(function () {
    var div = $(this).data('modal-id');
    var m = $(div + ' .modal');
    $(m).modal('show');
    $.get($(this).data('url'), function (data) {
        if (data) {
            $(m).modal('hide');
            m = $(div + ' .modal');
            $(div).html(data);
            $(m).modal('show');
        } else {
            alert("Error on fetch data !");
            $(div).html('');
            $(m).modal('hide');
            return false;
        }
    });

    return false;
});
$('.modal-loader').on("hidden.bs.modal", function () {
    var div = $(this).parent();
    div.html('<div class="modal fade modal-loader" tabindex="-1" role="dialog" aria-hidden="true"><div class="modal-dialog modal-lg"><div class="modal-content"><div class="modal-header"></div><div class="modal-body"><div class="spinner-border spinner-border-sm text-primary" role="status"><span class="sr-only"></span></div> Loading...</div></div></div></div></div>');
});