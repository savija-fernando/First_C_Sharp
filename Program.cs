// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Savija!");
//Console.Write("Congragulations, ");
//Console.Write(" ");
//Console.Write("You wrote your first lines of code.");
//Console.WriteLine("Congratulations!");
//Console.Write("You wrote your first lines of code.");
//Console.WriteLine("This is the first line");
//Console.Write("This is the second line");

//1.0Use character literals
//Console.WriteLine('H');

//2.0Use integer literals
//Console.WriteLine(100);

//3.0Use floating-point literals
//Console.WriteLine(99.99F);
//Console.WriteLine(12.39816m);

//4.0Use Boolean literals
//Console.WriteLine(true);
//Console.WriteLine(false);

//5.0Declare a variable
//string firstName="Savija";
//or firstName = "Savija";
//Console.WriteLine(firstName);
//char userOption;
//int gameScore;

//6.0Declare implicitly typed local variables

//string name="Bob";
//var value=3;
//decimal temprerature=34.4m;
//Console.WriteLine($"Hello, {name}! You have {value} messages in your inbox. The Temperature is {temprerature} celcius.");

//7.0Format literal strings in C#
//7.1Character escape sequences
//Console.WriteLine("Hello,\nSavija!");
//Console.WriteLine("Hello,\tSavija!");
//7.3display a file path?
//Console.WriteLine("C:\\Program Files\\MyApp\\app.exe");

//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\tComplete!");
//Console.WriteLine("Invoice: 1022\tComplete!");
//Console.Write("\nOutput Directory:");

//8.0Verbatim string literal @
//Console.WriteLine(@"    c:\source\repos");
//9.0Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

//10.0Combine strings using string interpolation
//string message="${greeting} {firstName}!";

//challenge
using System.IO.Compression;

//string projectName = "ACME";
//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
//Console.WriteLine($@"View English output:
  //      c:\Exercise\{projectName}\data.txt");
//Console.WriteLine($@"{russianMessage}:
  //      c:\Exercise\{projectName}\data.txt");

//directory = directory + @"\";

//Add two numeric values
//int firstNumber = 12;
//int secondNumber = 7;
//Console.WriteLine(firstNumber+secondNumber);

//string firstName = "Bob";
//int widgetsSold = 7;
//Console.WriteLine(firstName+" sold "+widgetsSold+ 7 +" widgets.");

//Perform math operations
/*int sum=7+5;
int difference=7-5;
int product=7*5;
int quotient=7/5;
int remainder=7%5;

Console.WriteLine("Sum: "+sum);
Console.WriteLine("Difference: "+difference);
Console.WriteLine("Product: "+product);
Console.WriteLine("Quotient: "+quotient);
Console.WriteLine("Remainder: "+remainder);*/

/*int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);*/

//Increment and decrement
/*int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
Console.WriteLine(value);*/

/*int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.
Console.WriteLine(value);*/

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);