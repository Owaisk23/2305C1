function loginUser(){
    var email = document.getElementById("email").value;
    var password = document.getElementById("pass").value;

    if(email == "" || password == ""){
        alert("Enter Email & password")
    }else {
        alert("your given email is: " + email + " & your password is: " + password)
    }
}


function insertTag(){
    var heading = document.createElement('h1')
    heading.innerText = "Hello world from DOM!"
    heading.setAttribute("class", "heading");

    var section1 = document.getElementById("section")
    section1.appendChild(heading)

    console.log(heading);

}

