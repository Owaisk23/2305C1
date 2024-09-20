// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

string fName = "Owais";
string lName = " Ahmed Khan";

Console.WriteLine("Hello, Welcome to our company Mr." + fName + lName);*/

// Datatypes
/*byte age = 23;
short salary = 27000;
int number = 15;
long lNum = 1233211233213312321L;

float fNum = 2.567F; // 7 digits
double dNum = 1.23986592365623596239; // 15 digits
decimal deciNum = 2.913695613916541949146912346124612M; // 28 digits

char myGrade = 'A';
bool isValid = false;
string address = "North Nazimabad Block A";*/
// Console.WriteLine(age +  "age" + "lNum" + salary + "sal" + number + "Numb");

// Arithematic Operators

/*Console.WriteLine(55 + 45);
Console.WriteLine(55 - 45);
Console.WriteLine(55 * 45);
Console.WriteLine(55 / 45);
Console.WriteLine(55 % 45);
*/
// Assignment Operator

/*int number = 5;

Console.WriteLine(number += 2); // number = number + 2 == 7
Console.WriteLine(number -= 2); // number = number - 2 == 5
Console.WriteLine(number *= 2); // number = number * 2 == 10
Console.WriteLine(number /= 2); // number = number / 2 == 5
*/
// Comparision Operators (True, False)

/*int a = 50, b = 120;

Console.WriteLine(a == b); //False
Console.WriteLine(a != b); //True
Console.WriteLine(a < b); //True
Console.WriteLine(a > b); //False
Console.WriteLine(a <= b); //True
Console.WriteLine(a >= b); //False*/

//Logical Operator (AND &&, OR ||, NOT !)
/*int a = 34, b = 45;

// AND OPERATOR
// T / T == TRUE
Console.WriteLine(a >= b && a == b); //False
Console.WriteLine(a <= b && a >= b); //False

// OR OPERATOR
Console.WriteLine(a <= b || a == b); //
                                     //  T     F     == TRUE 

// NOT OPERATOR
Console.WriteLine(!(a == b)); // TRUE
*/

// Conditional Statements
//IF Else
using System;

Console.WriteLine("Enter Salary... ");

int salary = Int32.Parse(Console.ReadLine());

if (salary >= 50000 && !(salary >= 80000))
{
    Console.WriteLine("Good Salary Package");
}
else if (salary < 50000)
{
    Console.WriteLine("Do you get fuel Allowance??");
    string answer = Console.ReadLine();

    answer = answer.ToLower(); //yes or y
    if (answer == "yes" || answer == "y")
    {
        Console.WriteLine("Sounds Good!!");
    }
    else if (answer == "no" || answer == "n")
    {
        Console.WriteLine("Try to switch your Job");
    }
    else
    {
        Console.WriteLine("Please answer yes or no");
    }
}
else
{
    Console.WriteLine("MASHALLAH!");
}

