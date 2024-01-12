bool isValidOption;
List<string> todos = new List<string>();

do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine().ToUpper();

    isValidOption = IsValidOption(userInput);
    if (isValidOption)
    {
        if(userInput == "S")
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("All todos:");
                foreach (var todo in todos)
                {
                    Console.WriteLine(todo);
                }
                Console.WriteLine();
            }
        }
        else if (userInput == "A")
        {
            if (!todos.Contains(userInput))
            {
                var description = "";

                do
                {
                    Console.WriteLine("Enter the TODO description:");
                    description = Console.ReadLine();

                } while (description.Length == 0);

                todos.Add(description);
                Console.WriteLine($"TODO successfully added: {description}");
            }
            else
            {
                Console.WriteLine("The description must be unique!");
            }
        }
        else if (userInput == "R")
        {
            
            bool isParsingSuccessful;

            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                do
                {
                    Console.WriteLine("Select the index of the TODO you want to remove: ");
                    Console.WriteLine();
                    Console.WriteLine("Options:");
                    int count = 1;

                    foreach (var todo in todos)
                    {
                        Console.WriteLine($"{count}: {todo}");
                        count++;
                    }
                    Console.WriteLine();


                    var indexInput = Console.ReadLine();

                    isParsingSuccessful = int.TryParse(
                        indexInput, out int index);


                    if (isParsingSuccessful && index >= 1 && index <= todos.Count)
                    {
                        var item = todos[index - 1];
                        Console.WriteLine($"TODO removed: {item}");
                        todos.Remove(item);

                    }
                    else if (indexInput == "")
                    {
                        Console.WriteLine("Selected index cannot be empty.");
                    }

                    else
                    {
                        Console.WriteLine("The given index is not valid");
                    }
                } while (!isParsingSuccessful);
                
            }

        }
        // Option E
        else
        {
            break;

        }
    }
    else
    {
        Console.WriteLine("Incorrect input");
    }

    isValidOption = false;

} while (!isValidOption);



bool IsValidOption(string selectedOption)
{
    if (selectedOption == "S" || 
        selectedOption == "A" || 
        selectedOption == "R" || 
        selectedOption == "E" )
    {
        return true;
    }
    return false;
}





//Console.ReadKey();