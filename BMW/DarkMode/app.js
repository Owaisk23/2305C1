function darkMode(){
    var container = document.getElementById("container");
    var lightImg = document.getElementById("lightModeImg");
    var nightImg = document.getElementById("darkModeImg");


    container.style.backgroundColor = "black";
    container.style.color = "white";

    lightImg.style.display = "inline";
    nightImg.style.display = "none";


    console.log(lightImg);

}



function lightMode(){

    var container = document.getElementById("container");
    var lightImg = document.getElementById("lightModeImg");
    var nightImg = document.getElementById("darkModeImg");


    container.style.backgroundColor = "white";
    container.style.color = "black";

    lightImg.style.display = "none";
    nightImg.style.display = "inline";

}