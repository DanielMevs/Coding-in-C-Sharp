using System.Text.Json;

var app = new GameDataParserApp();
var logger = new Logger("log.txt");
try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine(
        "Sorry! The application has experienced an unexpected error " +
        "and will have to be closed.");
    logger.Log(ex);
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class GameDataParserApp
{
    public void Run()
    {

        bool isFileRead = false;
        var fileContents = default(string);
        var fileName = default(string);
        do
        {

            Console.WriteLine("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("The file name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name cannot be empty");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("The file does not exist.");
            }
            else
            {
                fileContents = File.ReadAllText(fileName);
                isFileRead = true;
            }



        }
        while (!isFileRead);

        List<VideoGame> videoGames = default;

        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"JSON in {fileName} file was not " +
                $"in a valid format. JSON body:");
            Console.WriteLine(fileContents);
            Console.ForegroundColor = originalColor;

            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }


        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Loaded games are:");
            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }

        }
        else
        {
            Console.WriteLine("No games are present in the input file.");
        }
    }
}

public class VideoGame
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString() =>
        $"{Title}, released in {ReleaseYear}, rating: {Rating}";
}
