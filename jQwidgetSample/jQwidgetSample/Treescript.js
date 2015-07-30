$(document).ready(function () {
    var url="jsdata.txt";
    var source =
                {
                    datatype: "json",
                    datafields: [
                        { name: 'id' ,type:'number' },
                        { name: 'parentid', type:'number' },
                        { name: 'text', type:'string' },
                        { name: 'value', type:'number'}
                    ],
                    id: 'id',
                    url:url
                };
// create data adapter.
var dataAdapter = new $.jqx.dataAdapter(source);
// perform Data Binding.
dataAdapter.dataBind();
// get the tree items. The first parameter is the item's id. The second parameter is the parent item's id. The 'items' parameter represents 
// the sub items collection name. Each jqxTree item has a 'label' property, but in the JSON data, we have a 'text' field. The last parameter 
// specifies the mapping between the 'text' and 'label' fields.  
var records = dataAdapter.getRecordsHierarchy('id', 'parentid', 'items');
$('#jqxWidget').jqxTree({ source: records, width: '300px'});
});