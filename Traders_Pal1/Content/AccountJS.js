//$(document).redy(function () {


//})


function ValidateRegistration() {
    debugger;
    var name = $("#name").val();
    var password = $("#password1").val();
    var mobileNo = $("#mobileNo").val();
    var emailId = $("#email").val();
    var ConfirmPassword = $("#confirmpsw").val();

    if (name == '') {
        swal("Required", "Name is required.", "warning");
        return false;
    }
    if (password != ConfirmPassword) {
        swal("Required", "Please Same Password", "warning");
        return false;
    }
    if (mobileNo == '') {
        swal("Required", "Please 10 digit MobileNo", "warning");
        return false;
    }
    if (emailId == '') {
        swal("Required", "Please fill Email", "warning");
        return false;
    }

    var am = { Name: name, Password: password, EmailId: emailId, MobileNo: mobileNo }


    //$.post('/Home/NewRegistration', { am: JSON.stringify(am) },
    //    function (data) {
    //        debugger;
    //        console.log(data);
    //        alert(data.Message);
            
    //        $('#exampleModal').modal('show');



    //    })

    $.post('/Home/NewRegistration', { am: JSON.stringify(am) },
      function (data) {
          debugger;
          console.log(data);
          alert(data.message);
          $('#exampleModal2').modal('hide');
          $('#exampleModal').modal('show');


          var name = $("#name").val('');
          var password = $("#password1").val('');
          var mobileNo = $("#mobileNo").val('');
          var emailId = $("#email").val('');
          var ConfirmPassword = $("#confirmpsw").val('');
      })

   


}