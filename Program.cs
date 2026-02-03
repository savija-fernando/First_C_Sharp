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

/*int value = 1;

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
Console.WriteLine("Third decrement: " + value);*/

//challenge //m for decimal places 
/*int fahrenheit = 94;
decimal celcius=(fahrenheit-32m)*5m/9m;
Console.WriteLine("The temperature is "+celcius+ 7+" Celcius.");
Console.Write("Windows " + 1 + 1);
Console.WriteLine(5 / 10);

Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory); */

//guided project
// initialize variables - graded assignments 
/*int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = 0;
int nicolasSum = 0;
int zahirahSum = 0;
int jeongSum = 0;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine("Sophia: "+sophiaSum);
Console.WriteLine("Nicolas: "+nicolasSum);
Console.WriteLine("Zahirah: "+zahirahSum);
Console.WriteLine("Jeong: "+jeongSum);

decimal sophiaScore=(decimal)sophiaSum / currentAssignments;
decimal nicolasScore=(decimal)nicolasSum / currentAssignments;
decimal zahirahScore=(decimal)zahirahSum / currentAssignments;
decimal jeongScore=(decimal)jeongSum / currentAssignments;

/*Console.WriteLine("Sophia's average score: "+sophiaScore);
Console.WriteLine("Nicolas's average score: "+nicolasScore);  
Console.WriteLine("Zahirah's average score: "+zahirahScore);
Console.WriteLine("Jeong's average score: "+jeongScore);*/

/*Console.WriteLine("\nStudent\t\tGrade\n");
Console.WriteLine("Sophia:\t\t " + sophiaScore + " \tA");
Console.WriteLine("Nicolas:\t " + nicolasScore + " \tB");
Console.WriteLine("Zahirah:\t " + zahirahScore + " \tB");
Console.WriteLine("Jeong:\t\t " + jeongScore + " \tA");*/

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA=4;
int gradeB=3;

int course1NameGrade = gradeA;
int course2NameGrade = gradeB;
int course3NameGrade = gradeB;
int course4NameGrade = gradeB;
int course5NameGrade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
int totalGradePoints = 0;
totalGradePoints += course1Credit * course1NameGrade;

totalGradePoints += course2Credit * course2NameGrade;
totalGradePoints += course3Credit * course3NameGrade;
totalGradePoints += course4Credit * course4NameGrade;
totalGradePoints += course5Credit * course5NameGrade;

//Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

Console.WriteLine($"{course1Name} {course1NameGrade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2NameGrade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3NameGrade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4NameGrade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5NameGrade} {course5Credit}");

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
//Console.WriteLine($"Final GPA: {gradePointAverage}");

int leadingDigit = (int) gradePointAverage;

int firstDigit = (int) (gradePointAverage * 10) % 10;

int secondDigit = (int) (gradePointAverage * 100 ) % 10;


Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1NameGrade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2NameGrade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3NameGrade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4NameGrade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5NameGrade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");