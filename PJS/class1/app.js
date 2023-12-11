// console.log('hello world');


// var a = 5 + 2 * 3 - 2 / 2; // result 10
//         // 5 + 2 * 3 - 1
//         // 5 + 6 -1
//         // 11 - 1
//         // 10
// var b = 15;
// b = b + 1;  //16
// b = b - 1; //15

// b += 2; //17

// console.log(b)






// var x = 2;

// var y = x + ++x + x +  x++ + x;
//     //  2 + 3 +  3  +  3  +  4 = 15

// console.log("Expected outcome of x: " + x); //4
// console.log("Expected outcome of y: " + y); //15

// var x = 5;

// var y = x + ++x + x++ + --x + x-- + x + ++x + ++x;
// //      5 +  6  +  6  + 6  +  6   + 5  +  6  +  7


// console.log("Expected outcome of x: " + x); //7
// console.log("Expected outcome of y: " + y); // 47


// var a = 7;
// var b = a++ + --a - a + ++a - --a + a++ + a + ++a - a  + a++ - a;
// //      7  +  7  -  7  + 8  - 7  +  7  +  8 +  9 -  9  + 9  - 10

// console.log("Expected outcome of b: " + b) // 22
// console.log("Expected outcome of a: " + a) // 10

// Array Methods

// POP

// var num = [22, 56, 40, 10, 5];
// console.log(num);
// // remove element from end
// var popNum = num.pop();

// console.log(popNum);
// console.log(num);

// PUSH

// var num = [22, 56, 40, 10, 5];
// console.log(num);
// // add element from end
// var pushNum = num.push(23, 77, 86, 90);
// console.log(num);

// SHIFT

// var countries = ['Ind', 'Afg', 'Ban', 'Pak'];

// console.log(countries);
// // remove element from start
// var removeCountry = countries.shift();

// console.log(removeCountry)

// console.log(countries);

// UNSHIFT

// var countries = ['Ind', 'Afg', 'Ban', 'Pak'];

// console.log(countries);
// // remove element from start
// var addCountry = countries.unshift('Iran', 'Iraq');

// console.log(countries);

// SLICE

// var num = [23, 58, 1, 5, 78, 88, 91, 55, 100];
// //         0,  1,  2 ......
// console.log(num);

// var sliceNum = num.slice(3, 6);
// //        slice(startIndex, endLengthNumber)
// console.log(sliceNum)

// // REVERSE
// var reverseNum = num.reverse();

// console.log(reverseNum);


// CONCAT

// var num = [1, 2, 3];
// var num2 = [56, 77];

// var abc = num.concat(num2);


// console.log(abc)


// includes
// const number = [1,2,3,4,5,6,7,8];

// const include = number.includes(7);

// console.log(include);

// console.log(typeof(number))
// const numbString = number.toString();
// console.log(typeof(numbString))
// console.log(number);

// console.log(numbString)
// filter
// const evenNum = number.filter((num) => num % 2 == 0);
// console.log(evenNum)

// some
// const someNum = number.some((num) => num % 2 == 0);
// console.log(someNum)

// every

// const everyNum = number.every((num) => num % 2 == 0);
// console.log(everyNum)

// find
// const findNum = number.find((num) => num > 7);
// console.log(findNum)

// map
// const doubleNum = number.map((num) => num * 3);
// console.log(doubleNum)

// for-each



// reduce method
// const sum = number.reduce((total, num) => 
// total + num, 0);
// console.log(sum)


// SPLICE method

// var names = ['Taha', 'Ali', 'Abdullah', 'Hamza', 'Haseeb'];

// var spliceNames = names.splice(0, 2 , 'Bilal', 'Asif');
// names.sort()

// console.log(names);




// var fruits = ['Apple', 'grapes', 'Banana', 'Orange']

// var cutArray = fruits.splice(1,2, 'Juice');

// console.log(fruits);

// var indexFruits = fruits.indexOf('Apple');
// var lastindexFruits = fruits.lastIndexOf('Orange');


// console.log(indexFruits)
// console.log(lastindexFruits)




// let randomNum = Math.random();
// randomNum *= 1000;

// let roundNum = Math.round(randomNum);
// console.log(roundNum)



// var marks = +prompt("Enter your marks");

// if (marks >= 80 && marks <= 100) {

//     alert('Congrats, you got A grade')

// } else if (marks >= 70 && marks <= 79) {

//     alert('Congrats, you got B grade')

// } else if (marks >= 60 && marks <= 69) {

//     alert('Congrats, you got C grade')

// } else {

//     alert("Invalid marks or Fail")

// }




let p2 = document.getElementById('head').innerText = "Hello from JS";
document.getElementById('para').innerText = "Hello from JS we r revising DOm.";

let p1 = document.getElementById('p1').innerHTML = "<h1>hello from js</h1>"




console.log(p1);


