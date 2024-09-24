// Get the current working directory
using System.Reflection;
using TicketsDataAgrregator.TicketsAggregator;


string assemblyPath = Assembly.GetExecutingAssembly().Location;
string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
string repositoryRoot = Directory.GetParent(assemblyDirectory).Parent.Parent.FullName;
string TicketsFolder = Path.Combine(repositoryRoot, "Tickets");

// Output the path
Console.WriteLine(TicketsFolder);


try
{
    var ticketsAggregator = new TicketsAggregator(
        TicketsFolder,
        new FileWriter(),
        new DocumentsFromPdfsReader());
    
}
catch (Exception ex)
{
    Console.WriteLine("An exception occurred. " +
        "Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

