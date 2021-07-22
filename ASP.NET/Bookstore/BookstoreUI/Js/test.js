$.ajax({
    type: "GET",
    url:
       "https://localhost:44336/api/Books/ByCategoryID/" +
       categoryID +
       numOfBooks,
    contentType: "application/json; charset=utf-8",
    dataType: "json",
    success: function (data) {
        console.log(data);
    }, //End of AJAX Success function
    failure: function (data) {
       console.log(data.responseText);
    }, //End of AJAX failure function
    error: function (data) {
       console.log(data.responseText);
    }, //End of AJAX error function
 });