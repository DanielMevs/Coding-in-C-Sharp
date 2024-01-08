Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine().ToUpper();

switch (userChoice)
{
    case "S":
        Console.WriteLine("Another line");
        PrintSelectedOption("See all TODOS");
        break;
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
        PrintSelectedOption("Remove");
        break;
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}


void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}





Console.ReadKey();


class Exercise
{
    string DescribeDay(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                return "Working day";
            case 6:
            case 7:
                return "Weekend";
            default:
                return "Invalid day number";
        }
    }
}

class Challenge
{
    char ConvertPointsToGrade(int points)
    {
        switch(points)
        {
            case 10:
            case 9:
                return 'A';
            case 8:
            case 7:
            case 6:
                return 'B';
            case 5:
            case 4:
            case 3:
                return 'C';
            case 2:
            case 1:
                return 'D';
            case 0:
                return 'F';

            default:
                return '!';
        }
    }
}
