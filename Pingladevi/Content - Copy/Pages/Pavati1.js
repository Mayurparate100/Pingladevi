$(document).ready(function () {
    getPavati1List();
})
var getPavati1List = function () {
    $.ajax({
        url: "/Pavati1/GetPavati1List",
        method: "Post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#Tbl_Pavati tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id + "</td><td>" + elementValue.Date + "</td><td>" + elementValue.Name + "</td><td>" + elementValue.Mobileno + "</td><td>" + elementValue.PaymentInWord + "</td><td>" + elementValue.PaymentInNo +"</td><td><input type='submit' value='Edit' onClick='Editdata(" + elementValue.Id + ")'/></td></tr>";
            });

            $("#Tbl_Pavati tbody").append(html);
        }


    });

}
var Editdata = function (Id) {

    var model = { Id: Id };
    alert("Record Edit Successfully ....");
    $.ajax({

        url: "/Pavati1/GetEditData ",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {

            $("#lblid").val(response.model.Id);
            $("#txtdate").val(response.model.Date);
            $("#txtname").val(response.model.Name);
            $("#txtmobileno").val(response.model.Mobileno);
            $("#txtpaymentinword").val(response.model.PaymentInWord);
            $("#txtpaymentinno").val(response.model.PaymentInNo);

        }
    });

}
var ClearData = function () {

    $("#lblid").val("");
    $("#txtdate").val("");
    $("#txtname").val("");
    $("#txtmobileno").val("");
    $("#txtpaymentinword").val("");
    $("#txtpaymentinno").val("");

}
