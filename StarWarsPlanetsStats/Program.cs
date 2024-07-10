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

        json ??= await _secondaryApiDataReader.Read(
                "https://swapi.dev", "api/planets");

        var root = JsonSerializer.Deserialize<Root>(json);
        var planets = ToPlanets(root);

        foreach (var planet in planets)
        {
            Console.WriteLine(planet);
        }
        var propertyNamesToSelectorMapping =
            new Dictionary<string, Func<Planet, int?>>
            {
                ["population"] = planet => planet.Population,
                ["diameter"] = planet => planet.Diameter,
                ["surface water"] = planet => planet.SurfaceWater,
            };
        Console.WriteLine();
        Console.WriteLine("The statistics of which property " +
            "would you like to see?");
        Console.WriteLine(
            string.Join(
                Environment.NewLine, propertyNamesToSelectorMapping.Keys));


        var userChoice = Console.ReadLine();

        if(userChoice is null ||
            !propertyNamesToSelectorMapping.ContainsKey(userChoice))
        {
            Console.WriteLine("Invalid choice.");
        }
        else
        {
            ShowStatistics(
                planets,
                userChoice,
                propertyNamesToSelectorMapping[userChoice]);
        }

        
        
    }
    private static void ShowStatistics(
        IEnumerable<Planet> planets,
        string propertyName,
        Func<Planet, int?> propertySelector)
    {
        ShowStatistics(
            "Max",
            planets.MaxBy(propertySelector),
            propertySelector,
            propertyName);

        ShowStatistics(
            "Min",
            planets.MinBy(propertySelector),
            propertySelector,
            propertyName);

        

    }

    private static void ShowStatistics(
        string description,
        Planet selectedPlanet,
        Func<Planet, int?> propertySelector,
        string propertyName)
    {
        Console.WriteLine($"{description} {propertyName} is: " +
            $"{propertySelector(selectedPlanet)} " +
            $"(planet: {selectedPlanet.Name})");
    }

    private static IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root is null)
        {
            throw new NotImplementedException();

        }
        return root.results.Select(
            planetDto => (Planet)planetDto);
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
        return int.TryParse(input, out int resultParsed) ?
            resultParsed :
            null;
    }
}
