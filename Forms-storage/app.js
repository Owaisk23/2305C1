function userSignUp(){
// get values from user
var name = document.getElementById("user_name").value;
var email = document.getElementById("user_email").value;
var password = document.getElementById("user_password").value;

if(name == "" || email == "" || password == ""){
    // Error Handling
    var errorSpan = document.getElementById("error")
    errorSpan.innerText = "Plz fill all the field"
    errorSpan.style.display = "inline";
}else{
    // set values in Local Storage
    // localStorage.setItem("name", name);
    // localStorage.setItem("email", email);    
    // localStorage.setItem("password", password);

    sessionStorage.setItem("name", name);
    sessionStorage.setItem("email", email);    
    sessionStorage.setItem("password", password);
    // change file location from signUp to logIn
    location.href = "./login/login.html";
}




}
