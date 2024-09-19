// Chars
using System.Text;

char letter = 'a';
char digit = '4';
char symbol = '!';
char newLine = '\n';

var isUppercase = char.IsUpper(letter);
var isLetter = char.IsLetter(letter);
var isDigit = char.IsDigit(letter);
var isWhitespace = char.IsWhiteSpace(letter);
var aToUpper = char.ToUpper(letter);

char someChar = (char)100;
int asInt = (int)'t';

for(char c = 'A'; c <= 'z'; c++)
{
    Console.WriteLine(c + ", ");
}

Console.OutputEncoding = Encoding.Unicode;

var currentEncoding = Console.OutputEncoding;


char omega = 'Ω';
Console.WriteLine(omega);
Console.WriteLine((int)omega);

char dal = 'د';
Console.WriteLine(dal);
Console.WriteLine((int)dal);



Console.ReadKey();
