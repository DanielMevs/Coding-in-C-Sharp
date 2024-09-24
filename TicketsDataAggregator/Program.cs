// Get the current working directory
using System.Reflection;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;


string assemblyPath = Assembly.GetExecutingAssembly().Location;
string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
string repositoryRoot = Directory.GetParent(assemblyDirectory).Parent.Parent.FullName;
string TicketsFolder = Path.Combine(repositoryRoot, "Tickets");

// Output the path
Console.WriteLine(TicketsFolder);


try
{
    var ticketsAggregator = new TicketsAggregator(
        TicketsFolder);
    ticketsAggregator.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An exception occurred. " +
        "Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class TicketsAggregator
{
    private readonly string _ticketsFolder;

    public TicketsAggregator(string ticketsFolder)
    {
        _ticketsFolder = ticketsFolder;
    }

    public void Run()
    {
        foreach (var filePath in Directory.GetFiles(
            _ticketsFolder, "*.pdf"))
        {
            using (PdfDocument document = PdfDocument.Open(filePath))
            {
                // Page number starts from 1, not 0.
                Page page = document.GetPage(1);
                string text = page.Text;
            }
        }
        
    }
}

