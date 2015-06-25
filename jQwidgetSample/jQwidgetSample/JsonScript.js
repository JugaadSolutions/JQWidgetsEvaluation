$(document).ready(function () {
    var url = "Jsondata.txt";
    
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
   
      var dataAdapter = new $.jqx.dataAdapter(source, {
        downloadComplete: function (data, status, xhr) { },
        loadComplete: function (data) { },
        loadError: function (xhr, status, error) { }
      });

    var dataAdapter = new $.jqx.dataAdapter(source);
    // initialize jqxGrid
    $("#jqxgrid").jqxGrid(
    {
        width: 540,
        source: dataAdapter,                
        altrows: true,
        sortable: true,
        selectionmode: 'multiplecellsextended',
       columns: [
          { text: 'First Name', datafield: 'firstname', width: 130 },
          { text: 'Last Name', datafield: 'lastname', width: 130 },
          { text: 'Product', datafield: 'productname', width: 200 },
          { text: 'Price', datafield: 'price', width: 80, align: 'right', cellsalign: 'right' },
         ]
    });
    $("#jqxgrid").bind('bindingcomplete', function () {
        $("#jqxgrid").jqxGrid('sortby', 'firstname', 'asc');
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
