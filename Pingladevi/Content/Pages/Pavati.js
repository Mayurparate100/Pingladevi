$(document).ready(function () {
    detail();
})
var savePavati = function () {
    var id = $("#txtId").val();
    var date = $("#txtDate").val();
    var name = $("#txtName").val();
    var mobileno = $("#txtMobileno").val();
    var paymentinword = $("#txtPaymentInWord").val();
    var paymentinno = $("#txtPaymentInNo").val();

    var model = {
        Id: id,
        Date: date,
        Name: name,
        Mobileno: mobileno,
        PaymentInWord: paymentinword,
        PaymentInNo: paymentinno,
    };

    
    $.ajax({
        url: "/Pavati/SavePavati",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",

        success: function (response) {
            console.log(response.message);
            alert("Successfull");
          
            detail(reponse.message);
        }
    })
};

var detail = function (Id) {
    var model = { Id: id };

    $.ajax({
        url: "/Pavati/DetailData ",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            $("#txtId").val(response.model.Id);
            $("#txtDate").val(response.model.Date);
            $("#txtnamesame").val(response.model.Name);
            $("#txtmobilenosame").val(response.model.Mobileno);
            $("#txtpaymentinwordsame").val(response.model.PaymentInWord);
            $("#txtpaymentinnosame").val(response.model.PaymentInNo);
        }
    });
}
