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

/*Console.WriteLine("Enter Salary... ");

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
}*/

// Switch Case
/*Console.WriteLine("Enter number for days from 1 to 7:");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;

}*/
/*
int a = 525;
Console.WriteLine($"this is string interpolation {a*2}");// String Interpolation $" {}"*/


/*for(int i = 0; i <= 23; i++)
{
    Console.WriteLine(i);
}*/

//for(int i = 10; i > 0 ; i--)
//{
//    Console.WriteLine(i);
//}


//for (int i = 1; i < 101; i++)
//{
//    if(i%2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//While Loop

//int j = 13;

//while(j < 13)
//{
//    Console.WriteLine("J");
//    j--;
//}

//Do While Loop

//int j = 13;

//do
//{
//    Console.WriteLine("J");
//    j++;
//}while(j < 13);

//Even / Odd
/*int num;
char ans;

do
{
    Console.WriteLine("Enter a Number");
    num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Even Number");
    }
    else
    {
        Console.WriteLine("Odd number");
    }
    Console.WriteLine("Do you want to continue Press y for yes and any key to exit");

    ans = Convert.ToChar(Console.ReadLine());
} while (ans == 'Y' || ans == 'y');*/

//Array with fixed size

/*int[] numbers = new int[4]; //only 4 elemnts will come in this array


numbers[0] = 2;
numbers[1] = 12;
numbers[2] = 22;
numbers[3] = 32;


Console.WriteLine(numbers[0]);

int[] stdMarks = { 67, 88, 99, 70 };

//foreach
foreach (int n in stdMarks)
{
    Console.WriteLine(n);
}*/

//Console.WriteLine(Math.Pow(2, 2));

//int[] numbers = new int[4]; //C# give default value to uninitialized variables int=0, sting = null, bool= true 

//Console.WriteLine(numbers);

//string[] cities = { "Karachi", "Lahore", "Isb", "Multan", "Karachi", "Swat", "Sialkot", "Pindi", "Karachi" };

//Array.Sort(cities);
//Array.Reverse(cities);
/*foreach (string n in cities)
{
    Console.WriteLine(n);
}*/

//Console.WriteLine(Array.IndexOf(cities, "Swat"));

//Console.WriteLine(Array.LastIndexOf(cities, "Karachi"));

//for(int i = 0; i < cities.Length; i++)
//{
//    Console.WriteLine(cities[i]);
//}

// Multidimensional array(Array inside array) 20 ,40 etc

//int[,] TopMarks =
//{
//    {97, 99},
//    {87, 83},
//    {77, 79},
//    {65, 69}
//};
//Console.WriteLine(TopMarks[3, 1]);


//for (int i = 0; i < TopMarks.GetLength(0); i++)
//{
//    Console.WriteLine($"Printing {i + 1} array");

//    for (int j = 0; j < TopMarks.GetLength(1); j++)
//    {
//        Console.WriteLine(TopMarks[i, j]);
//    }
//    Console.WriteLine();
//}

// jagged Array (size of sub-array is not fixed)

//string[][] skillSet =
//{
//    new string[4]{"c#", "sql", "css", "html"},
//    new string[1]{"php"},
//    new string[2]{"javascript", "typescript"},
//    new string[3]{"bootstrap", "figma", "sqlserver"}
//};

//Console.WriteLine(skillSet[3][2]);


//var decides the datatype on runtime

//foreach(var skills in skillSet)
//{
//    foreach(var skill in skills)
//    {
//        Console.WriteLine(skill);
//    }
//}

//Functions

//user define functions
//add();

//1. No Return No Parameter
//return type function name () { body }

//function create
//void Greet()
//{
//    Console.WriteLine("Hi, Owais!! Welcome to our company..");
//}

////function calling
//Greet();

//2. No Return with Parameters

//void Greet(string name)
//{
//    Console.WriteLine($"Hi, {name}!! Welcome to our company..");
//}

////function calling
//Greet("Haseeb");
//Greet("Azhar");
//Greet("Taha");

//3. Return with no Parameter

//string Greet()
//{
//    return("Hi, User!! Welcome to our company");
//}

////Console.WriteLine(Greet());

//string messg = Greet();

//Console.WriteLine(messg.ToUpper());

//float floatNumbers()
//{
//    return (0.7323f);
//}

//Console.WriteLine(floatNumbers());

//float fNum = floatNumbers();
//Console.WriteLine(fNum);

//4. Return with parameters
// \n is used to take next line.
string Greet(string name, byte age)
{
    return ($"Hi, {name}, Welcome to our company. \n Your age is {age}");
}

string mssg = Greet("Jeethalaal", 45);
Console.WriteLine(mssg.ToUpper());























































