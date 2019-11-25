
function onClickEvent(Event) {
    var quantity = $("#Quantity").val();
    var productId = $("#Products").val();
    var productDescription = $("#Products").children("option").filter(":selected").text();

    var url = "/Add?quantity=" + quantity + "&productId="
        + productId + "&productDescription="
        + productDescription;
        

    var addedProducts = {
        Quantity: quantity,
        ProductId: productId,
        ProductDescription: productDescription
    }

    $.ajax({
        url: url,
        type: "Get",
        data: addedProducts,
        success: ConfigureTable
    });
}

function ConfigureTable(data) {
    
}

$("#btnAdd").click(onClickEvent);