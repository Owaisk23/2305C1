function logIn(){
    // user input values on logIn Page
    var email = document.getElementById("user_email").value;
    var password = document.getElementById("user_password").value;

    // getting values from Local Storage
    // var localEmail =localStorage.getItem("email");
    // var localPass = localStorage.getItem("password");
    
    
    var localEmail =sessionStorage.getItem("email");
    var localPass = sessionStorage.getItem("password");

    // Authentication Logic

    if(email == localEmail && password == localPass){
        alert("LogIn Success");
    }else{
        alert("Kon Hoo app??")
    }
}