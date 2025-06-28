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