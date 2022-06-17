
//lang on data tables
var english = {
    "sLengthMenu": "Display _MENU_ records per page",
    "sZeroRecords": "No data available in table",
    "sInfo": "Showing _START_ to _END_ of _TOTAL_ records",
    "sInfoEmpty": "Showing 0 to 0 of 0 records",
    "sInfoFiltered": "(filtered from _MAX_ total records)",
    "sSearch": "Search:",
    oPaginate: {
        sFirst: "First", sLast: "Last",
        sNext: "Next", sPrevious: "Previous"
    },
};

var hungary = {
    "sLengthMenu": "Jelenítse meg _MENU_ rekordot oldalanként",
    "sZeroRecords": "Nincs rendelkezésre álló adat a táblázatban",
    "sInfo": "A _START_ rekord _END_ - _TOTAL_ megjelenítése",
    "sInfoEmpty": "A 0 rekord 0 - 0 megjelenítése",
    "sInfoFiltered": "(_MAX_ összes rekordból szűrt)",
    "sSearch": "Keresés:",
    oPaginate: {
        sFirst: "First", sLast: "Last",
        sNext: "következő", sPrevious: "Előző"
    },
};

var langCookie = getCookie('lang');
var currentLang = langCookie == 'en' ? english : hungary;

$(function (e) {

    var sortCol = $('.grid').data("sort-col");
    var sortOrder = $('.grid').data("sort-order");
    if (sortCol != null) {
        $('.grid').DataTable({ "oLanguage": currentLang, "order": [[sortCol, sortOrder]] });
    } else {
        $('.grid').DataTable({ "oLanguage": currentLang });
    }

});


function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}