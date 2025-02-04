﻿    function AddRowsToProductTable(List) {

    var mailingListTableData = $("#tblListFieldData").children('thead').children('tr');

    mailingListTableData.each(function (i, el) {
        var $tds = $(this).find('th');
        var $trs = $('#tblListFieldData tr');
       
        var k = $('#tblListFieldData tr').length - 1;

        var rowsData = "";
        if (k == 0) {
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductCatalogDiv_" + k + "><select name='ProductCatalogId' id=ProductCatalogName_" + k + " class='select2'></select></td>";
        }
        else {

            k = parseInt($trs[k].cells[0].children[0].id.toString().substring(19))+1;
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductCatalogDiv_" + k + "></td>";
        }
        rowsData += "<td><input name='Quantity' id=Quantity_" + k + " class=\"form-control \" value=\"\"  onChange='CalculatePriceWithQuantity("+k+")'/></td>";
        rowsData += "<td><input name='TaxAmount' id=TaxAmount_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><input name='UnitPriceExclTax' id=UnitPriceExclTax_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><a id = remove_" + k + "> <i class=\"s-24 icon-cancel red-text\"></i></a ></td>";
        rowsData += "</tr>";


        if (k != 0) 
           {

            var ddlId = $trs[1].cells[0].children[0].id;
            var ddl = $("#" + ddlId.toString()).clone();


            //Set the ID and Name
            ddl.attr("id", "ProductCatalogName_" + k);
            ddl.attr("name", "ProductCatalogId");

            $("#divListFieldRows").append(rowsData);
            $("#ProductCatalogDiv_" + k).append(ddl);
            ddl.select2();


            }
            else
            {
                $("#divListFieldRows").append(rowsData);
            $("#ProductCatalogName_0").html("");
            $("#ProductCatalogName_0").append(
                $('<option></option>').val("0").html("Select Product Catalog"));
                $.each(List.data, function (i, item) {
                    $("#ProductCatalogName_0").append(
                        $('<option></option>').val(item.value).html(item.text + " ( " + item.Column2+" )"));
            });

            $("#ProductCatalogName_0").select2();
            }
       
    
        $("#remove_" + k + "").click(function () {
            $("#Row_" + k + "").remove(); 
            SumOfInvoiceBill();
        });
        $("#ProductCatalogName_" + k + "").change(function () {
           
            var arrayindex=  List.data.findIndex(function (row) {
                return row.value == $("#ProductCatalogName_" + k + "").val();;
            });
            var arrayData = List.data[arrayindex];
            document.getElementById("Quantity_" + k + "").value = "1";
            document.getElementById("UnitPriceExclTax_" + k + "").value = (parseInt(arrayData.Column3) * parseInt(document.getElementById("Quantity_" + k + "").value)).toString();
            document.getElementById("TaxAmount_" + k + "").value = (parseInt(arrayData.Column4) * parseInt(document.getElementById("Quantity_" + k + "").value)).toString();
            SumOfInvoiceBill();
           
        });
       

        $("#UnitPriceExclTax_" + k + "").bind('input', function () {
            SumOfInvoiceBill();
        });

      
    });
  
}

function CalculatePriceWithQuantity(k) {

    $("#UnitPriceExclTax_" + k + "").val((parseInt($("#UnitPriceExclTax_" + k + "").val()) * parseInt($("#Quantity_" + k + "").val())).toString());
    $("TaxAmount_" + k + "").val((parseInt($("#TaxAmount_" + k + "").val()) * parseInt($("#Quantity_" + k + "").val())).toString());
        SumOfInvoiceBill();
 
}

function computeTableColumnTotal(tableId, colNumber) {
    // find the table with id attribute tableId
    // return the total of the numerical elements in column colNumber
    // skip the top row (headers) and bottom row (where the total will go)

    var result = 0;

    try {
        var tableElem = window.document.getElementById(tableId);
        var tableBody = tableElem.getElementsByTagName("tbody").item(0);
        var i;
        var howManyRows = tableBody.rows.length;
        for (i = 0; i < (howManyRows); i++) // skip first and last row (hence i=1, and howManyRows-1)
        {
            var thisTrElem = tableBody.rows[i];
            var thisTdElem = thisTrElem.cells[colNumber];
            var thisTextNode = thisTdElem.childNodes.item(0).value;

            // try to convert text to numeric
            var thisNumber = parseFloat(thisTextNode);
            // if you didn't get back the value NaN (i.e. not a number), add into result
            if (!isNaN(thisNumber))
                result += thisNumber;
        } // end for

    } // end try
    catch (ex) {
        window.alert("Exception in function computeTableColumnTotal()\n" + ex);
        result = 0;
    }
    finally {
        return result;
    }

}

function SumOfInvoiceBill() {
    var totalAmountExclTax = computeTableColumnTotal("tblListFieldData", 3);
    var totalTaxAmount = computeTableColumnTotal("tblListFieldData", 2);
    document.getElementById('SubTotal').innerText = "$" + totalAmountExclTax;
    var TaxAmount = Math.round((parseFloat(totalTaxAmount)));
    document.getElementById('TaxAmount').innerText = "$" + TaxAmount.toString();
    document.getElementById('TotalAmount').innerText = "$" + (totalAmountExclTax + TaxAmount).toString();
}
function AddRowsToAssociateTable(k,List) {

    var mailingListTableData = $("#tblListField").children('thead').children('tr');

    mailingListTableData.each(function (i, el) {
        var $tds = $(this).find('th');
        var rowsData = "";
        rowsData = "<tr id=Row_" + k + ">";

        rowsData += "<td><input name='AssociateProductList[" + k + "].ProductId' id=ProductName_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><input name='AssociateProductList[" + k + "].Quantity' id=SKU_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><input name='AssociateProductList[" + k + "].Price' id=Price_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><a id = remove_" + k + "> <i class=\"s-24 icon-cancel red-text\"></i></a ></td>";
        rowsData += "</tr>";
        $("#divListFieldRows").append(rowsData);
    });
    $("#remove_" + k + "").click(function () {
        $("#Row_" + k + "").remove();
       
    });
    $("#ProductName_" + k + "").change(function () {

        var arrayindex = List.data.findIndex(function (row) {
            return row.value == $("#ProductName_" + k + "").val();;
        });
        var arrayData = List.data[arrayindex];
        document.getElementById("Quantity_" + k + "").value = "1";
        document.getElementById("Price_" + k + "").value = arrayData.Column3;
       
       

    });
  
}


function AddRowsToProductInventoryTable(List) {

    var mailingListTableData = $("#tblListFieldData").children('thead').children('tr');

    mailingListTableData.each(function (i, el) {
        var $tds = $(this).find('th');
        var $trs = $('#tblListFieldData tr');

        var k = $('#tblListFieldData tr').length - 1;

        var rowsData = "";
        if (k == 0) {
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductDiv_" + k + "><select name='ProductId' id=ProductName_" + k + " class='select2'></select></td>";
        }
        else {

            k = parseInt($trs[k].cells[0].children[0].id.toString().substring(19)) + 1;
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductDiv_" + k + "></td>";
        }
        rowsData += "<td><input name='Description' id=Description_" + k + " class=\"form-control \" value=\"\"  /></td>";
        rowsData += "<td><input name='Sku' id=Sku_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><input name='Quantity' id=Quantity_" + k + " class=\"form-control \" value=\"\"  /></td>";
     
      
        rowsData += "<td><a id = remove_" + k + "> <i class=\"s-24 icon-cancel red-text\"></i></a ></td>";
        rowsData += "</tr>";


        if (k != 0) {

            var ddlId = $trs[1].cells[0].children[0].id;
            var ddl = $("#" + ddlId.toString()).clone();


            //Set the ID and Name
            ddl.attr("id", "ProductName_" + k);
            ddl.attr("name", "ProductId");

            $("#divListFieldRows").append(rowsData);
            $("#ProductDiv_" + k).append(ddl);
            ddl.select2();


        }
        else {
            $("#divListFieldRows").append(rowsData);
            $("#ProductName_0").html("");
            $("#ProductName_0").append(
                $('<option></option>').val("0").html("Select Product"));
            $.each(List.data, function (i, item) {
                $("#ProductName_0").append(
                    $('<option></option>').val(item.value).html(item.text + " ( " + item.Column2 + " )"));
            });

            $("#ProductName_0").select2();
        }


        $("#remove_" + k + "").click(function () {
            $("#Row_" + k + "").remove();
           
        });
        $("#ProductName_" + k + "").change(function () {

            var arrayindex = List.data.findIndex(function (row) {
                return row.value == $("#ProductName_" + k + "").val();;
            });
            var arrayData = List.data[arrayindex];
            document.getElementById("Quantity_" + k + "").value = "1";
            document.getElementById("Description_" + k + "").value = arrayData.Column4;
            document.getElementById("Sku_" + k + "").value = arrayData.Column2;

        });

    });

}

function AddRowsToProductInventoryTable(List, RFQID) {


    var ProductTableData = $("#tblListFieldData").children('thead').children('tr');

    ProductTableData.each(function (i, el) {
        var $tds = $(this).find('th');
        var $trs = $('#tblListFieldData tr');

        var k = $('#tblListFieldData tr').length - 1;

        var rowsData = "";
        if (k == 0) {
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductDiv_" + k + "><select name='ProductId' id=ProductName_" + k + " class='select2'></select></td>";
        }
        else {

             k = parseInt($trs[k].cells[0].children[0].id.toString().substring(12)) + 1;
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductDiv_" + k + "></td>";
        }
        rowsData += "<td><input name='Description' id=Description_" + k + " class=\"form-control \" value=\"\"  /></td>";
        rowsData += "<td><input name='Sku' id=Sku_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><input name='Quantity' id=Quantity_" + k + " class=\"form-control \" value=\"\"  /></td>";

        rowsData += "<td><a style=\"display: none\" id=\"SuccessIcon_" + k + "\"><i class=\"icon-check3 text-green font-weight-bolder\"></i></a>";
        rowsData += " <a  style=\"display: none\" id=\"edit_"+k+"\" onclick=\"toggleEdit_("+k+")(false); return true; \"><i class=\"icon-pencil mr-3\"></i></a>";
        rowsData += "<a id = save_" + k + " onclick='PostAddItemToRFQ(" + k + "," + RFQID + ")'> <i class=\" mr-3 icon-save red-blue\"></i></a > <a id = remove_" + k + "> <i class=\" mr-3 icon-cancel red-text\"></i></a ></td>";

      
        rowsData += "</tr>";


        if (k != 0) {

            var ddlId = $trs[1].cells[0].children[0].id;
            var ddl = $("#" + ddlId.toString()).clone();


            //Set the ID and Name
            ddl.attr("id", "ProductName_" + k);
            ddl.attr("name", "ProductId");
            ddl.attr("style", "display:none");
            ddl.attr("disabled", false);
            $("#divListFieldRows").append(rowsData);
            $("#ProductDiv_" + k).append(ddl);
            ddl.select2();


        }
        else {
            $("#divListFieldRows").append(rowsData);
            $("#ProductName_0").html("");
            $("#ProductName_0").append(
                $('<option></option>').val("0").html("Select Product"));
            $.each(List.data, function (i, item) {
                $("#ProductName_0").append(
                    $('<option></option>').val(item.value).html(item.text + " ( " + item.Column2 + " )"));
            });

            $("#ProductName_0").select2();
        }
        $("#remove_" + k + "").click(function () {
            $("#Row_" + k + "").remove();

        });

        $("#ProductName_" + k + "").change(function () {

            var arrayindex = List.data.findIndex(function (row) {
                return row.value == $("#ProductName_" + k + "").val();;
            });
            var arrayData = List.data[arrayindex];
            document.getElementById("Quantity_" + k + "").value = "1";
            document.getElementById("Description_" + k + "").value = arrayData.Column4;
            document.getElementById("Sku_" + k + "").value = arrayData.Column2;


        });

    });
   

   

}

function PostAddItemToRFQ(k, RfqId) {

    var jsonData = {
        
        id: $("#ItemId_" + k).val(),
        RfqId: RfqId,
        itemId: $("#ProductName_" + k).val(),
        Quantity: $("#Quantity_" + k).val(),
        Sku: $("#Sku_" + k).val(),
        Description: $("#Description_" + k).val(),
    };

    $.post("/Customer/AddEditProductoRFQItems",

        jsonData
        ,
        function (data, status) {
            if (data.success == true) {
                if (data.message == "Create") 
                    {
                        $("#save_" + k).hide();
                        $("#SuccessIcon_" + k).show();
                        $("#SuccessIcon_" + k).fadeOut(3000, function () {

                            $("#edit_" + k).show();
                            $('#ProductName_' + k).prop('disabled', false);
                            $('#Quantity_' + k).prop('disabled', false);
                            $('#Sku_' + k).prop('disabled', false);
                            $('#Description_' + k).prop('disabled', false);
                         
                        });
                    }
                    else
                    {
                        $("#save_" + k).hide();
                        $("#SuccessIcon_" + k).show();
                        $("#SuccessIcon_" + k).fadeOut(3000, function () {

                            $("#edit_" + k).show();
                            $('#ProductName_' + k).prop('disabled', false);
                            $('#Quantity_' + k).prop('disabled', false);
                            $('#Sku_' + k).prop('disabled', false);
                            $('#Description_' + k).prop('disabled', false);
                          
                        });
                    }
            }
        });

}

function PostDeleteItemFromOrder(k, RfqId) {

    var jsonData = {

        rfqitemid: $("#ItemId_" + k).val(),
        RfqId: RfqId,
        itemId: $("#ProductName_" + k).val(),
        Quantity: $("#Quantity_" + k).val(),
        Sku: $("#Sku_" + k).val(),
        Description: $("#Description_" + k).val(),
    };

    $.post("/Customer/DeletePrductRFQItems",

        jsonData
        ,
        function (data, status) {
            if (data.success == true) {
               
                    $("#Row_" + k + "").remove();

            }
        });

}