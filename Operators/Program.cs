//When the operators have the same precedance,
//it is evaluated from left to right

int a = 10;
int b = 5;

Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Subtraction: " + (a - b));
Console.WriteLine("Multiplication" + a * b);
Console.WriteLine("Division " + a / b);
Console.WriteLine("John" + " " + "Smith");



var result = "abc" + "def" + "ghi";

var userChoice = Console.ReadLine();

bool isNotUserInputAbc = userChoice != "ABC";
bool isUserInputAbc = userChoice == "ABC";

Console.WriteLine(isNotUserInputAbc);
Console.WriteLine(isUserInputAbc);

var number = 10;

var isLargerThan5 = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number  >= 10;
var isSmallerOrEqualTo6 =  number <= 6;

Console.WriteLine("is number larger than five? " + isLargerThan5);


var is10Modulo3EqualTo1 = 10 % 3 == 1;

Console.WriteLine(is10Modulo3EqualTo1);

var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;

Console.WriteLine(isLargerThan4AndSmallerThan9);

var isEqualTo123OrEvenAndSmallerThan20 =
    number == 123 || (number % 2 == 0 && number < 20);

Console.WriteLine(isEqualTo123OrEvenAndSmallerThan20);

Console.ReadKey();
