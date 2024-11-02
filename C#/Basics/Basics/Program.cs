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
//string Greet(string name, byte age)
//{
//    return ($"Hi, {name}, Welcome to our company. \n Your age is {age}");
//}

//string mssg = Greet("Jeethalaal", 45);
//Console.WriteLine(mssg.ToUpper());

//2. Pre Defined

//Math.Sqrt(49); Console.WriteLine("skill");



//1 . Make 2 jagged arrays.
//2. Create a function to print them.

//exception handling (try | catch )
//try
//{
//    //Code to execute
//    int number = Convert.ToInt32(Console.ReadLine());
//    switch (number)
//    {
//        case 1:
//            Console.WriteLine("Hi");
//            break;
//        case 2:

//            Console.WriteLine("Hi , Hi");

//            break;
//        case 3:
//            Console.WriteLine("Hi,hello, hi");
//            break;
//        case 4:
//            Console.WriteLine("Hi,hello, hi, hello");
//            break;

//        default:
//            Console.WriteLine("bye");
//            break;
//    }
//}
//catch (DivideByZeroException e)
//{
//    //Print a message on exception
//    Console.WriteLine("Can't Divide by zero");

//}
//catch (FormatException e)
//{
//    //Print a message on exception
//    Console.WriteLine("Invalid input we want an integer from you." + e);
//}
//catch (Exception e)
//{
//    //Print a message on exception
//    Console.WriteLine("Oops, Something went wrong.");
//}
//finally
//{
//    Console.WriteLine("Thanks for using our console application. Do recommend it to others :)");
//}


//Collections

//Generics collection
//fixed Datatype
//dynamic size
//List, Dictionary, Stack, Queues

//Non-Generics collection
// Datatype not fixed
//dynamic size
//ArrayList, Hashtable

//using System.Collections;
using System.Linq;

//Generics
//List

//List<string> SuperCars = new List<string>();
//SuperCars.Add("Ferrari");
//SuperCars.Add("Lamborghini");
//SuperCars.Add("Buggati Chiron");


//List<string> Cars = new List<string>();

//Cars.Add("Honda civic");
//Cars.Add("Honda Accord");
//Cars.Add("Toyota Camry");
//Cars.Add("toyota Fortuner");
//Cars.Add("Suzuki Cultus");
//Cars.Add("Toyota vitz");

////Cars.Remove("Toyota vitz");
////Cars.RemoveAt(3)
////
//Console.WriteLine(Cars.Contains("Toyota Revo"));
//Cars.Insert(1, "Toyota Revo");
//Console.WriteLine(Cars.Contains("Toyota Revo"));

//Cars.AddRange(SuperCars);

////Cars.RemoveRange(0,2);

////Cars.Clear();

//Console.WriteLine(Cars.Contains("Toyota Revo"));


////Console.WriteLine(Cars[4]);
//foreach (string car in Cars)
//{
//    Console.WriteLine(car);
//}


//Queues  (fifo: first in first out)
//Queue<string> names = new Queue<string>();
//names.Enqueue("Owais");
//names.Enqueue("ahmed");
//names.Enqueue("ashar");
//names.Enqueue("rayan");
//names.Enqueue("yaheya");
//names.Enqueue("abdullah");
//names.Enqueue("talha");
//names.Enqueue("danish");
//names.Enqueue("sohaib");


//names.Dequeue(); //Owais
//names.Dequeue(); //ahmed
//names.Dequeue(); //ashar
//names.Dequeue(); //rayan

//    names.Clear();

//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}



//Stack (lifo: last in first out)

//Stack<string> SecondRow = new Stack<string>();
//SecondRow.Push("Aisha");
//SecondRow.Push("ashbal");
//SecondRow.Push("mariam");
//SecondRow.Push("muzammil");
//SecondRow.Push("basit");




//SecondRow.Pop();
//SecondRow.Pop();
//SecondRow.Pop();
//SecondRow.Pop();

//SecondRow.Clear();

//foreach (string item in SecondRow)
//{
//    Console.WriteLine(item);
//}



using System.Collections;
////Dictionaries(Generics)
//Dictionary<string, string> user = new Dictionary<string, string>();
//user.Add("username", "owaisk23");
//user.Add("email", "owaisk23@gmail.com");
//user.Add("pass", "abcdefghij");
//user.Add("role", "admin");
//user.Add("image", "owaisk.jpg");

//Console.WriteLine(user["role"]);
////user.Remove("image");
//Console.WriteLine(user["image"]);

//foreach (var item in user)
//{
//    string[] test = (item.ToString()).Split(",");
//    string key = test[0].Trim('[');// [
//    string value = test[1].Trim(']');// ]
//    //Console.WriteLine(key);
//    //Console.WriteLine(value);
//    Console.WriteLine($"The property is : {key} and  value is : {value}");
//    //Console.WriteLine(test[1]);
//}

//Hashtables (Non generic)(no fixed datatype)

//Hashtable user = new Hashtable();
//user.Add("username", "owaisk23");
//user.Add("email", "owaisk23@gmail.com");
//user.Add("pass", 54544454544);
//user.Add("isadmin", true);
//user.Add("image", "owaisk23.jpg");

////Console.WriteLine(user["isadmin"]);
////user.Remove("image");
////user.Contains(2.45);//true
////user.ContainsValue(true);//true

//////Console.WriteLine(user["role"]);
//foreach (DictionaryEntry item in user)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}
//Console.WriteLine(user.GetHashCode());

//ArrayList (Non Generic)(no fixed datatype)
//ArrayList Cars = new ArrayList();

//Cars.Add("Honda civic");
//Cars.Add("Honda Accord");
//Cars.Add("Toyota Camry");
//Cars.Add("toyota Fortuner");
//Cars.Add(240900);
//Cars.Add(.24f);

//Cars.Remove("Toyota vitz");
//Cars.RemoveAt(3)
//
//Console.WriteLine(Cars.Contains("Toyota Revo"));
//Cars.Insert(1, "Toyota Revo");
//Console.WriteLine(Cars.Contains("Toyota Revo"));
//Cars.RemoveRange(0,2);
//Cars.Clear();
//Console.WriteLine(Cars.Contains("Toyota Revo"));

//Console.WriteLine(Cars[4]);
//foreach (var car in Cars)
//{
//    Console.WriteLine(car);
//}


//String Methods

//string test = """{ "name": "John Doe"}""";

using System.Collections;

//string test = "we are  Learnnig \"C#\"";
//Console.WriteLine(test);
//Console.WriteLine(test.Replace("Learnnig", "Mastering"));
//Console.WriteLine(test.Replace("C#", "Java"));

//string email = "hdkjhdkjhkhf";
//int age = 75;

//login start

//login end


//CODING Best Practices
// Indentation (Readable by using spaces and new lines) 
// Comments //Sir yahan switch case shuru kia ha
// Meaningful identifiers (variable names)
// errors (exception handling) 
//less repeatation

//OOP
//Objects and Classes

//Aeroplane Boeing707 = new Aeroplane();//default constructor


//Boeing707.Name = "Boeing 707";
//Boeing707.takeOff();
//Console.WriteLine(Boeing707.AirLine);

//Aeroplane f16 = new Aeroplane("PAF");
//f16.takeOff();

//Aeroplane f17 = new Aeroplane("PAF","F-17 Thunder",2,2,"8500hp");
//f17.takeOff();
//f17.land();

//public class Aeroplane
//{
//    public string? AirLine;
//    public string? Name;
//    public int Seats;
//    public int Crew;
//    public string? Power;

//    //Contstructor
//    public Aeroplane()
//    {
//        this.AirLine = "Not specified";
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }

//    public Aeroplane(string AirLine)
//    {
//        this.AirLine = AirLine;
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }


//    //    //Paremeterized constructor (Overloading)
//    public Aeroplane(string ALine, string name, int seat, int crew, string pow)
//    {
//        this.AirLine = ALine;
//        this.Name = name;
//        this.Seats = seat;
//        this.Crew = crew;
//        this.Power = pow;
//    }
//    public void takeOff()
//    {
//        Console.WriteLine($"{this.Name} is taking off. Best Wishes..!");
//    }
//    public void land()
//    {
//        Console.WriteLine($"{this.Name} is Landing at the 4th runway..! ");
//    }

//}

//OOP (OBJECT ORIENTED PROGRAMMING)
//it is an approach to code cleaner and better.
//readable
//reusable
//optimize
//proper structure of the code is maintained.

//Main Pillars of OOP

//1. Interitance
// i . Single level inheritance  Vehicle -> Car
// ii . Multi level inheritance  Vehicle -> Car -> Ecar
// iii. Heirarchical inheritance Vehicle ->Car , Vehicle-> Bike
// iv. Multiple inheritance  
// v. Hybrid inheritance    Vehicle -> CAR , Vehicle -> Car -> Ecar, Car-> Ecar

//2. Polymorphism
// Method Overloading
// Method Overriding
//3. Abstraction
//4. Encapsulation

//Inheritance
//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();

//Car mercedez = new Car("TZ-8908", "Black", "Mercedez", "Benz C-Class", 20000000);
////mercedez.Run();
//mercedez.Run(500);

////// Parent class | Base Class | Super Class
//public class Vehicle
//{
//    public string regNo;
//    public string color;

//    public Vehicle(string regno, string color)
//    {
//        this.regNo = regno;
//        this.color = color;
//    }
//    public void Run()
//    {
//        Console.WriteLine($"{this.regNo} vehicle started running");
//    }
//}
////// Child class | Derived Class | Sub Class
//public class Car : Vehicle
//{

//    public string brand;
//    public string model;
//    public int price;

//    public Car(string regno, string color, string brand, string model, int price) : base(regno, color)
//    {
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//    }

//    //method overriding
//    public void Run()
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
//    }
//    //method overloading
//    public void Run(int speed)
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
//    }

//}

//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();

//Car MarkX = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car a = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car b = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car bv = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car g = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car MadrkX = new Car("2008", "Black", "Toyota", "Mark X", 3500000);


//MarkX.Run();
//MarkX.Run(300);

//Math abc = new Math();
//abc.Sqrt(49);

//static function examples:
//Math.Sqrt(49);
//Console.WriteLine("dkf");

//Console.WriteLine(Car.totalCars);
//Car.paytax();



//abstract public class Vehicle
//{
//    public string regNo;
//    public string color;

//    public static int totalCars = 0;
//    public static int totalAmount = 0;
//    public static int payingCars = 0;
//    public static int nonPayingCars = 0;
//    public virtual void Run()
//    {
//        Console.WriteLine($"{this.regNo} vehicle started running");

//    }
//}
//abstract public class Car : Vehicle
//{
//    public string brand;
//    public string model;
//    public int price;
//    public int basePrice = 2;
//    public static int carCount = 0;
//    public Car(string regno, string color, string brand, string model, int price)
//    {
//        this.regNo = regno;
//        this.color = color;
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//        totalCars++;
//        carCount++;
//    }
//    public static void paytax()
//    {
//        Console.WriteLine("Boom..! the race has begun. May the best be winner.");
//        //payingCars++;
//        //totalAmount += this.basePrice;

//    }
//    //method overriding
//    public void passWithoutPaying()
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
//        nonPayingCars++;
//    }

//    //method overloading
//    public void Run(int speed)
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
//    }

//}

//Interfaces
////FrontEndDeveloper ashar = new FrontEndDeveloper();
//ashar.ComplexDesign("Ashar Ahmed");
//ashar.SimpleDesign();

//FullStackDeveloper usama = new FullStackDeveloper();
//usama.SimpleDesign();
//usama.ComplexAPIs();

//interface topics
//{

//Interfaces,
//        Static,
//       Abstract
//} 
//interface FrontEndDevelopment
//{
//    public void SimpleDesign();
//    public void ComplexDesign(string name);

//}


//interface BackEndDevelopment
//{
//    public void SimpleCrud();
//    public void ComplexAPIs();
//    public void Authentication();

//}

//public class FrontEndDeveloper : FrontEndDevelopment
//{
//    //method implementation
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS and JS.");
//    }
//    public void ComplexDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you animated and responsive design using HTML, CSS, JS, React, " +
//            $"Nextjs.");
//    }

//}



//Multiple Inheritance
//public class FullStackDeveloper : FrontEndDevelopment, BackEndDevelopment
//{
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS and JS.");
//    }
//    public void ComplexDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you animated and responsive design using HTML, CSS, JS, React, Nextjs.");
//    }
//    public void SimpleCrud()
//    {
//        Console.WriteLine("We will provide you simple crud operations.");
//    }
//    public void ComplexAPIs()
//    {
//        Console.WriteLine($"We will provide you complex APIs.");
//    }
//    public void Authentication()
//    {
//        Console.WriteLine($" We will provide you Authentication.");
//    }
//}

//Access  Modifiers
//1. Public     | anyone can access from any where in the program.
//2. Private    | only owner class can access .
//3. Protected  | only owner class and child class can access .

//Products neckBand = new Products(1500, "Lenovo Neckband" ,"good quality product with extra base and long range connectivity.");
////neckBand.name="Lenovo Neckband";
////neckBand.price;
////neckBand.description;
////Console.WriteLine(neckBand.price);

////neckBand.showPrice();
//neckBand.callShowPrice();

//Gadgets iphone = new Gadgets(230000, "iphone 15 pro max", "acha phone ha", "phones");
//iphone.ShowGadget();

//public class Products
//{
//   public string name;
//   private int price;
//   protected string description;

//    public Products(int price, string name, string description)
//    {
//        this.name = name;
//        this.price = price;
//        this.description = description;
//    }

//    private void showPrice()
//    {
//        Console.WriteLine(this.price);
//    }
//    public void callShowPrice()
//    {
//        this.showPrice();
//    }
//}

//public class Gadgets : Products
//{
//    public string category;

//    public Gadgets(int price, string name, string description, string category) : base (price, name, description)
//    {
//      this.category=category;
//    }

//    public void ShowGadget()
//    {
//        Console.WriteLine(this.name);
//        this.callShowPrice();
//        Console.WriteLine(this.description);
//        Console.WriteLine(this.category);

//    }
//}  

//Delegates
//Math
//Math.Cos()

//Normal Delegate
//MyMaths.MyMathsDelegate Eval = new MyMaths.MyMathsDelegate(MyMaths.Add);
//Eval(4, 8);

//Multicast Delegate

//MyMaths.MyMathsDelegate MultiEval;
// MultiEval = MyMaths.Mul;
//MultiEval(2, 5);

//MultiEval = MyMaths.Div;
//MultiEval(2, 0);

//MultiEval = MyMaths.Sub;
//MultiEval(2, 0);

//MyMaths.Sub(4, 2);
//public class MyMaths
//{
//    public delegate void MyMathsDelegate(double num1, double num2);

//    public static void Add(double a, double b)
//    {
//        Console.WriteLine(a + b);
//    }
//    public static void Sub(double a, int b)
//    {
//        Console.WriteLine(a - b);
//    }

//    public static void Mul(double a, double b)
//    {
//        Console.WriteLine(a * b);
//    }
//    public static void Div(double a, double b)
//    {
//        if(b!=0)
//        Console.WriteLine(a / b);
//        else
//        Console.WriteLine("Can't divide by zero");
//    }
//}


//Shopping.GetItem buy;
//buy = Shopping.GetEatables;
//buy("Jam", 550, "Black current jam with great delight");

//public class Shopping
//{
//    public delegate void GetItem(string name, int price, string description);

//    public static void GetEatables(string name, int price, string desc)
//    {
//        Console.WriteLine("You have bought eatable {0} at Rs. {1} . {2} .",name , price, desc);//placeholders
//    } 
//    public static void GetGadgets(string name, int price, string desc)
//    {
//        Console.WriteLine("You have bought gaddet {0} at Rs. {1} . {2} .",name , price, desc);//placeholders
//    }


//}

//unary operator    a++, a--
//binary operator   a + b; a - b
//Ternary operator  (condition) ? "hi" : "bye" // 3 operands

//string greet = (10 < 10) ? "hi" : "bye";

//Console.WriteLine(greet);

//getters and setters

//Animal cat = new Animal();
//cat.Name = "Tom";
//cat.Age = 40;
//Console.WriteLine(cat.Age);


//public class Animal
//{
//    public string? Name { get; set; } //auto complete properties
//    private int  age;


//    public int Age
//    {
//        get { return age; }

//        set { 

//            if(value < 10)
//            {

//            age = value;
//            }
//            else
//            {
//                age = 10;
//            }
//        }
//    }
//}



//enums
//Implicit typecasting 
//Explicit typecasting 


//Console.WriteLine($"{pakBatters.Fakhar} has jersey no {(int)pakBatters.Fakhar}");

//enum pakBatters
//{
//    Babar =56,
//    Rizwan = 33,
//    Fakhar =45,
//    Imad =75
//}


//switch() { }


//case (int)pakBatters.Fakhar:
//    Console.WriteLine("January");
//    break;

//namespaces : a collection of related classes and sub namespaces.

//using System;
//using System.Collections;
//using TaxMangementSytem;
//using Indexers;


//Tax tolltax = new Tax();

//tolltax.amount = 5000;

//Vehicle vehicle = new Vehicle();
//vehicle.regNum = 4545;



////Indexers : when we want our object to behave like an array we implement indexers.

//fruits basket = new fruits();
//basket[0] = "Langra";
//basket[1] = "Chaunsa";
//basket[2] = "Daseri";
//basket[3] = "Sindhri";
//basket[4] = "Anwer Ritol";

//Console.WriteLine(basket[3]);

//foreach (string item in basket.fruitNames)
//{
//    Console.WriteLine(item);
//}

//Records 

//User ahmed = new User();
//ahmed.id = 1;
//ahmed.name = "Ahmed Hassan";


//User haris = new User();
//haris.id = 1;
//haris.name = "Ahmed Hassan";


////Console.WriteLine(ahmed);
//Console.WriteLine(ahmed == haris);

//User1 talha = new User1();
//talha.id = 2;
//talha.name = "Mirza talha";

//User1 abdullah = new User1();
//abdullah.id = 2;
//abdullah.name = "Mirza talha";

////Console.WriteLine(talha);
//Console.WriteLine(talha == abdullah);

//public class User{
//    public int id { get; set; }
//    public string? name { get; set; }
//}

//public record User1
//{
//    public int id { get; set; }
//    public string name { get; set; }
//}


//events

//myCar Civic = new myCar();
//Civic.speedUp += new myCar.speedCar(myCar.carMoved);
//Civic.drive();


//public class myCar
//{
//    public delegate void speedCar();
//    public event speedCar speedUp;
//    public int speed = 0;

//    public void drive()
//    {
//        for (int i = 1; i < 10; i++)
//        {
//            if (i > 5)
//            {
//                speedUp();
//            }
//            Console.WriteLine($"the car is moving at {i} mph");
//            System.Threading.Thread.Sleep(1000);


//        }
//    }
//    public static void carMoved()
//    {
//        Console.WriteLine("the speed limit has exceeded");
//    }


//}















































