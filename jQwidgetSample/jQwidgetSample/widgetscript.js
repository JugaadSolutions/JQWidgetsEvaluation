$(document).ready(function () {
    // Create jqxTree
    $('#jqxTree').jqxTree({ height: '300px', width: '300px' });
    $('#jqxTree').bind('select', function (event) {
        var htmlElement = event.args.element;
        var item = $('#jqxTree').jqxTree('getItem', htmlElement);
        alert(item.label);
    });
});