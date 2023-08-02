// document.write("Hello In JS WOrld")

// var fname = "Owais"; //declare & assign val

// document.write(fname);
//  var age; //declare
// age = 23;

// document.write(fname);
// document.write(age);




// fname = "Khan";
// age = 33;
 
// document.write(fname); //expected outcome: 
// document.write(age);

// let var const

// let firstName = 'Abdullah';
// document.write(firstName);
// firstName = 'Owais';
// let firstName = 'Owais';

// let firstName = "Owais";
// document.write(firstName);

//PRinting values in Javascript 
//Document.write

// var fname = "owais";
// document.write(fname);

//console log

// var fname = "Ashar";
// var age = 20;
// console.log(age);

// alert

// var fname = "owais";
// var age = 33;
// alert(age);

// Arithematic Operation
// var num1 = 20;
// var num2 = 30;

// var add = num1 + num2;
// console.log(typeof(add));

// DATA TYPES
// var data = 23;

// console.log(typeof(data));


// var a = null;
// console.log(a);
// const num = 23;
// num = 33;

// var std_Name = ["Ashar", "Abdullah", "Taha"]


//--------------------CLASS 2-------------------------------------


// // arithmetic operators in Javascript

// var num1 = 14;
// var num2 = 2;

// var sum = num1 % num2; 
// console.log(sum);

// // concatenation

// var fname = "Muhammad Ali";
// console.log("GRID assig is done by her sister: " + fname); //

// var number = 2 + 2 + 'Abcd';
// console.log(number); //expected outcome = 4Abcd, 

// var number = 'Abcd' + 2 + 3;   
// console.log(number); 

// var name = 'Pakistan ' + 'Zindabad';
// console.log(name)

// Precedence

// var exp = 2 + 4 * 6 / 2; 
//             // 2 + 4 * 3
//             // 2+ 12
//             // 14
// console.log('Precedence outcome: ' + exp) // expected outcome= 14   , real= 14


// var exp1 = (2*5) - 10 / (2 * 3);
//             //  10 - 10 / 6 
//             // 10 - 1.66 
// console.log(exp1) //real = 8.33

// // post and pre increament and decrement

// var a = 10;
// a = ++a; // 10 +1 
// a = ++a; // 11 + 1
// var b = a;

// console.log('Value of a is: '+ a)
// console.log('Value of b is: '+ b)

// var x = 2;

// var y = x + x + x++ + x + ++x;  //x+1
//     // 2 + 2 + 2 + 3 + 4
// console.log('Output 0f y: '+ y); // 13
// console.log('Output of x: '+ x); // 4


// var x =5;

// var y = x + ++x + x++ + --x + x-- + x;
//        // 5 + 6  +  6   +  6  + 6    + 5

// console.log('Outcome of x '+ x); // 5
// console.log('Outcome of y ' + y); // 34

// var a = 2
// var b = a - a++ + --a + a-- + a;
//        // 2 - 2  +  2  + 2   + 1
// alert(a + ' and ' + b);   // a = 1 & b = 5


// console.log("It is the 'red' box");

// // relationaal operator 

// console.log('=========================')

// var number1 = 6; // number
// var number2 = '6'; // string


// var result = number1 !== number2;

// console.log(result); // true


// var fname = prompt('Enter name.');
// //USECASE OF UNARY OPERATOR
// var num = +prompt('Enter number');
// console.log(typeof fname);

// //
// console.log(typeof num);

// conditional statements 
// if-else statement
// var marks = 56;

// if(marks>=50){

//     alert('you are passed')

// }
// else{
//     alert('you are failed')
// }



// // prompt 

// var Name = prompt('Enter Your Name');
// var Marks = prompt('Enter you Marks', '20');

// if(Marks > 50){
//     // Owais, your marks is 70;
//     alert(Name + ', your marks is ' + Marks );
// }else {
//     alert(Name + ' is Failed')
// }

// if, else-if, else
// var marks = +prompt('Enter your marks');

// if (marks > 80) {
//     alert('A grade')
// } else if(marks < 80){
//     alert('B Grade')
// }
// else{
//     alert('wrong value')
// }


// nested if
// var marks = 45;
//     //true       true
// if(marks>80 && marks<100){
//     alert('GRADE A')
//     if(marks>=90){
//         alert('Include Bonus')
//     }else{
//         alert('No Bonus')
//     }

// }
// else if(marks>50 && marks<80){
//     alert('GRADE B')
// }else{
//     alert('Failed or invalid marks')
// }

// syntax

// switch (key) {
//     case value:

//         break;

//     default:
//         break;
// }

// var days = +prompt('Enter number to find a Day',1);

// switch (days) {
//     case 1:
//         alert('Monday')
//         break;

//     case 2:
//         alert('Tuesday')
//         break;

//     case 3:
//         alert('Wednesday')
//         break;
       
//     case 4:
//         alert('Thursday')
//         break;

//     case 5:
//         alert('Friday')
//         break;

//     case 6:
//         alert('Saturday')
//         break;

//     default:
//         alert('Holiday')
//         break;
// }

//FOR LOOP

// for loop has three statements
// i) initialization --> run only one time before iteration.
// ii) condition --> run before iteration
// iii) expression --> run after iteration

// for (initialization; condition ; expression){
//     code to be executed;
// }

// for(i=1; i <=100; i++ ){
//     console.log(i);
// }

// user input.
// var num = +prompt("Enter number for table", 2);

// for(var i = 1; i<=50; i++){

//         console.log(num + "x" + i + "=" + num * i);
// }


//ARRAYS

// var student1 = 'Ibrahim';
// var age1 = 19;

// var student2 = 'Asim';
// var age2 = 18;

                    //0       1         2       3       4      5
// var studentNames = ['Ashar','Owais','Talha', 'Saima','Fizza','John', 'Abdullah', 'Ebad'];
// var ages = [23,10,12,30,34,23,11];
// console.log(studentNames[0]); //AShar
// console.log(ages[0]); //23
// console.log(studentNames[1]);
// console.log(ages[1]);
// console.log(studentNames[3]);
// console.log(ages[3]);

// for (let i = 0; index < array.length; index++) {        
//}

// for(var i = 0; i<studentNames.length; i++){

//         console.log('Student Name: ' + studentNames[i])
    
// }

// for(var i = 0; i < ages.length; i++){

//     console.log('Students Age is: ' + ages[i])

// }

//While and do-while loops 

// var i = 11;

// while (i<100) {
//      console.log(i);
//      i++
// }


// var i =11;

// do {
//      console.log(i)
//      i++
// } while (i<10);


// Arrays Methods


// var countries = ['Pak', 'Afq', 'Ind', 'China'];

// console.log(countries);

// var updateCountries = countries.push('Ban');
// // var updateCountries = countries.pop();

// console.log(updateCountries);


// var temp = [23, 30, 15, 35, 50];

// console.log(temp);

// //var updateTemp = temp.shift();
// var updateTemp = temp.unshift(40);

// console.log(updateTemp);

// function delaration

// function print(){
//     console.log('Hello in Func')
//     console.log('Umeed hai apko samjh ayega')
//     console.log('Focus rakhiyega samjh ajayega')
// }



// // function calling

// print();


// function add(){
//     console.log(5+2);

// }

// add();

// func with arguments and parameters
// function sum(num1, num2){
//     var num = num1 + num2;
//     console.log('Sum result is: '+ num);    
// }

// //func calling

// sum(42, 50);

// // func with arguments and parameters
// function sub(num1, num2){
//     var num = num1 - num2;
//     console.log('Subtract result is: ' + num);    
// }

// //func calling

// sub(90, 50);

// AGE CALCULATOR:

// function ageCal(){
//     var birthYear = +prompt('Enter your birth year')
//     var currYear = 2023;

//     var age = currYear - birthYear; 

//     alert('Your age is: ' + age);
// }


// function greet(){
//     alert('hello, good morning!')
// }




// function getInput(){

//     var input = prompt('Enter Name');

//     showOutput();
// }


// function showOutput(){
//     alert('Hi!')
// }


// function car(){
//      // get input from user 
//     var carName = prompt("Enter car name ");
    
//     compliment();
// }   

// function compliment(){
//     alert("Your car is beautiful");
// }


// var cities = ["Khi", "Hyd", "Isb", "Lhr", "Swat"]
// //slice & splice
// console.log(cities[2]);


// var num = +prompt("Enter number for table");

// for(var i = 1; i <= 10; i++){
//     //              2 x 1 = 2
//     console.log(num + "x" + i + "=" + num*i);    

// var Car = {
//     // property name : property value
//     // name:"Civic",

//     name : ["Civic","Alto","Corola"],
//     color: "Purple",
//     price: 50000,


//     // info: function(){
//     //     console.log(this.name,this.color);
//     // }
// }

// console.log(Car);


// var Student = new Object();

// Student.name = "Abc"
// console.log(Student);





















































