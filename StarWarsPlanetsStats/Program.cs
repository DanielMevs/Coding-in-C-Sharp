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
        string? json = null;
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
        var planets = ToPlanets(root);
    }

    private IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root is null)
        {
            throw new NotImplementedException();

        }
        var planets = new List<Planet>();

        foreach(var planetDto in root.results)
        {
            Planet planet = (Planet)planetDto;
            planets.Add(planet);
        }
        return planets;
    }
}

public readonly record struct Planet
{
    public string Name { get; }
    public int Diameter { get; }
    public int? SurfaceWater { get; }
    public int? Population { get; }

    public Planet(
        string name,
        int diameter,
        int? surfaceWater,
        int? population)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }

    public static explicit operator Planet(Result planetDto)
    {
        var name = planetDto.name;
        var diameter = int.Parse(planetDto.diameter);

        int? population = planetDto.population.ToIntOrNull();

        int? surfaceWater = planetDto.surface_water.ToIntOrNull();

        return new Planet(name, diameter, surfaceWater, population);
    }
    
}

public static class StringExpression
{
    public static int? ToIntOrNull(this string? input)
    {
        int? result = null;
        if (int.TryParse(input, out int resultParsed))
        {
            result = resultParsed;
        }
        return result;
    }
}
