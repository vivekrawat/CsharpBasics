using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

Console.WriteLine("hello world");
Console.Write("congratulations");
Console.Write("  ");
Console.Write("you wrote your frost lines of code");

// Correct! Console.WriteLine prints the output on the existing line and appends a new line after it

// Literals: a lieral value is a value which does not change like the values inside Console


// the following tables also incudes digits before and after .
// Float Type    Precision
// ----------------------------
// float         ~6-9 digits
// double        ~15-17 digits
// decimal        28-29 digits

// string for words, phrases, or any alphanumeric data for presentation, not calculation
// char for a single alphanumeric character
// int for a whole number
// decimal for a number with a fractional component
// bool for a true/false value

Console.WriteLine(2.35454F);// for float case in sensitive can be f too
Console.WriteLine(2.35454D);// for double
Console.WriteLine(2.35454M);// for decimal

// Variable names must begin with an alphabetical letter or an underscore, not a number.

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

string customerName;
decimal temperature = 34.4m;

// Before you can use a variable, you have to declare it.

// implicitly typed local variables
// It can infer your variable's data type by its initialized value. 
var message = "Hello world!";

// initalization is important for explicitly typed local variables otherwise it throws an error

Console.WriteLine("Hello\nWorld!"); // new line
Console.WriteLine("Hello\tWorld!"); // new tab
Console.WriteLine("Hello \"World\"!");


Console.WriteLine("c:\\source\\repos"); // to display a single back slash use 2
// Verbatim string literal

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");


// Kon'nichiwa World special characters
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

string firstName = "Bob";
string messa = "Hello " + firstName;
Console.WriteLine(messa);

// string interpolation
string mesg2 = $"Hello      {firstName}";

Console.WriteLine($@"C:\Output\{firstName}\Data");// string interpolation and string verbatim combined
// inplicit type conversion
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// more complex example
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");


// operations not it is not a looselt typed language
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);//12
Console.WriteLine("Difference: " + difference);//2
Console.WriteLine("Product: " + product);//35
Console.WriteLine("Quotient: " + quotient);//1

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// int decimalQuotient = 7 / 5.0m; will throw error

// ++, --,+= , -= work in c#
// you can call some class withtout instantiating it while some class cannot be called without instantiating it
Random dice = new Random();

int num = dice.Next(1, 7);

Console.WriteLine("" + num);

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

string mess4 = "this is the msg la la la";

if (mess4.Contains("thiss"))
{
  Console.WriteLine(mess4);
}
else
{
  Console.WriteLine("not found");
}

// ==, the "equals" operator, to test for equality
// >, the "greater than" operator, to test that the value on the left is greater than the value on the right
// <, the "less than" operator, to test that the value on the left is less than the value on the right
// >=, the "greater than or equal to" operator
// <=, the "less than or equal to" operator
// &&, the "and" operator, to test that both operands are true
// ||, the "or" operator, to test that at least one operand is true

// else if



// arrays

int[] myArray = new int[2];
myArray[0] = 1;
myArray[1] = 2;

string[] strings = {"lalala", "lula la", "lalala"};

char[] chars = ['1', '1'];
Console.WriteLine("" + chars.Length);

foreach (string name in strings)
{
  Console.WriteLine("" + name);
}
for (int i = 0; i < strings.Length; i++) { 
  Console.WriteLine("" + i);
}

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// C# uses the block scope

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


string val1 = "one";
double val2 = 2.300d;
Console.WriteLine(val1 + " " + val2);

string first = "5";// when value is 3fdsf the error is returned
string second = "7";
int summ = int.Parse(first) + int.Parse(second);
int result = Convert.ToInt32(first) * Convert.ToInt32(second); //another way to do the same
Console.WriteLine(summ);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

string value3 = "102f";
int resultt = 0;
if (int.TryParse(value3, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
// composite formatting

string item = string.Format("{0} {1}!", first, second);
Console.WriteLine(item);
Console.WriteLine("{0} {0} {0}!", first, second);

decimal price = 123.45m;
int discountt = 50;
Console.WriteLine($"Price: {price:C} (Save {discountt:C})");// will add the currency at the end

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); // will put commas for better reading



// Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
// Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
// Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
// Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
// Methods that turn a string into an array of strings or characters (Split(), ToCharArray())

Console.WriteLine("Enter current GMT");
// reding an input from the user
int currentGMT = Convert.ToInt32(Console.ReadLine());

// function declaration is similar to as it is done in c++
// void DisplayTimes() 

CountTo(5);

	void CountTo(int max) 
	{
		for (int i = 0; i < max; i++)
		{
			Console.Write($"{i}, ");
		}
	}

  // void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
// function with return value
string FormatDecimal(double input)
{
  return input.ToString().Substring(0, 5);
}

// exception handling

try
{
  // Step 1: code execution begins
  try
  {
    // Step 2: an exception occurs here
  }
  finally
  {
    // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
  }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{
  // Step 5: the system transfers control to the first line of the catch code block
}

// User input: Exceptions can occur when code processes user input. For example, exceptions occur when the input value is in the wrong format or out of range.

// Data processing and computations: Exceptions can occur when code performs data calculations or conversions. For example, exceptions occur when code attempts to divide by zero, cast to an unsupported type, or assign a value that's out of range.

// File input/output operations: Exceptions can occur when code reads from or writes to a file. For example, exceptions occur when the file doesn't exist, the program doesn't have permission to access the file, or the file is in use by another process.

// Database operations: Exceptions can occur when code interacts with a database. For example, exceptions occur when the database connection is lost, a syntax error occurs in a SQL statement, or a constraint violation occurs.

// Network communication: Exceptions can occur when code communicates over a network. For example, exceptions occur when the network connection is lost, a timeout occurs, or the remote server returns an error.

// Other external resources: Exceptions can occur when code communicates with other external resources. Web Services, REST APIs, or third-party libraries, can throw exceptions for various reasons. For example, exceptions occur due to network connections issues, malformed data, etc.



var person = new { name = "hello", AesGcm = 12 };
// person.lan = "kala"; will throw error

dynamic persona = new ExpandoObject();
persona.Name = "hello";
persona.Age = 12;
persona.Age2 = 12;
// // inheritance example
// class Animal  // Base class (parent) 
// {
//   public void animalSound() 
//   {
//     Console.WriteLine("The animal makes a sound");
//   }
// }

// class Pig : Animal  // Derived class (child) 
// {
//   public void animalSound()
//   {
//     Console.WriteLine("The pig says: wee wee");
//   }
// }

// The output from the example above was probably not what you expected. That is because the base class method overrides the derived class method, when they share the same name.

// However, C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods:

class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Programm
{
  static void Main(string[] args)
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}

