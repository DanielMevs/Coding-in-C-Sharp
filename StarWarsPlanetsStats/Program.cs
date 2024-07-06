using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.DTOs;
using System.Text.Json;

try
{
    await new StarWarsPlanetsStatsApp(
        new ApiDataReader(),
        new MockStarWarsApiDataReader()).Run();
}
catch(Exception ex)
{
    Console.WriteLine("An error occured. " +
        "Exception message: " + ex.Message);
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;

    public StarWarsPlanetsStatsApp(
        IApiDataReader apiDataReader,
        IApiDataReader secondaryApiDataReader)
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
    }

    
    public async Task Run()
    {
        string json = null;
        try
        {
            json = await _apiDataReader.Read(
                "https://swapi.dev", "api/planets");
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("API request was unsuccessful. " +
                "Switch to mock data. " +
                "Exception message: " + ex.Message);
        }

        if (json is null)
        {
            json = await _secondaryApiDataReader.Read(
                "https://swapi.dev", "api/planets");
        }

        var root = JsonSerializer.Deserialize<Root>(json);
    }
}
