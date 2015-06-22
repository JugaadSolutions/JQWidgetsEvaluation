$(document).ready(function () {
    var url = "Jsondata.txt";
    
    for (var i = 0; i < 1000; i++) {
        var row = {};
        var productindex = Math.floor(Math.random() * productNames.length);
        var price = parseFloat(priceValues[productindex]);
        var quantity = 1 + Math.round(Math.random() * 10);
        row["firstname"] = firstNames[Math.floor(Math.random() * firstNames.length)];
        row["lastname"] = lastNames[Math.floor(Math.random() * lastNames.length)];
        row["productname"] = productNames[productindex];
        row["price"] = price;
        row["quantity"] = quantity;
        row["total"] = price * quantity;
        data[i] = row;
    }
    var source =
             {
                 datatype: "json",
                 datafields: [
                   { name: 'firstname' },
                   { name: 'lastname' },
                   { name: 'productname' },
                   { name: 'price' },
                 ],
                 url: url
             };
   
    $("#jqxgrid").bind('bindingcomplete', function () {
        $("#jqxgrid").jqxGrid('sortby', 'firstname', 'asc');
    });
    var dataAdapter = new $.jqx.dataAdapter(source, {
        downloadComplete: function (data, status, xhr) { },
        loadComplete: function (data) { },
        loadError: function (xhr, status, error) { }
    });
    var dataAdapter = new $.jqx.dataAdapter(source);
    // initialize jqxGrid
    $("#jqxgrid").jqxGrid(
    {
        width: 850,
        source: dataAdapter,                
        altrows: true,
        sortable: true,
        selectionmode: 'multiplecellsextended',
       columns: [
          { text: 'First Name', datafield: 'firstname', width: 130 },
          { text: 'Last Name', datafield: 'lastname', width: 130 },
          { text: 'Product', datafield: 'productname', width: 200 },
          { text: 'Price', datafield: 'price', width: 70, align: 'right', cellsalign: 'right' },
          { text: 'Quantity', datafield: 'quantity', cellsalign: 'right', align: 'right', cellsformat: 'c2' },
          { text: 'Total', datafield: 'total', cellsalign: 'right', align: 'right', cellsformat: 'c3' }
        ]
    });
  
     $("#excelExport").jqxButton();
    $("#xmlExport").jqxButton();
    $("#csvExport").jqxButton();
    $("#tsvExport").jqxButton();
    $("#htmlExport").jqxButton();
    $("#jsonExport").jqxButton();
    $("#pdfExport").jqxButton();
    $("#excelExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'xls', 'jqxGrid');           
    });
    $("#xmlExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'xml', 'jqxGrid');
    });
    $("#csvExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'csv', 'jqxGrid');
    });
    $("#tsvExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'tsv', 'jqxGrid');
    });
    $("#htmlExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'html', 'jqxGrid');
    });
    $("#jsonExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'json', 'jqxGrid');
    });
    $("#pdfExport").click(function () {
        $("#jqxgrid").jqxGrid('exportdata', 'pdf', 'jqxGrid');
    });
});
