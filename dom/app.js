document.getElementById("para").innerHTML = "para inserted using JS";


var para = document.getElementById("p")
console.log(para);
para.style.color = "red";

var heading = document.getElementsById("heading")
heading.innerHTML = "Heading one";

const p1 = document.getElementById(main);
const p2 = p1.getElementsByTagName("p");

document.getElementById("para1").innerHTML = "hello world  " + p2[0].innerHTML;


