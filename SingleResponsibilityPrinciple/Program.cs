var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();
if (File.Exists(path))
{
    Console.WriteLine("Names file alread exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    // Let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to a file.");
    stringsTextualRepository.Write(path, names.All);
    
}
Console.WriteLine(new NamesFormatter().Format(names.All));

Console.ReadKey();

class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
        
    }

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Separator, strings));
    }
}
class NamesValidator
{
    public bool IsValid(string name)
    {
        return name.Length >= 2 && name.Length <= 25
            && char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}

class NamesFilePathBuilder
{
    public string BuildFilePath()
    {
        // We could imagine this is much more complicated,
        // for example provided by the user and validated
        return "names.txt";
    }
}

class NamesFormatter
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine, names);
    }
}
class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();
    public void AddNames(List<string> stringsFromFile)
    {
        foreach(var name in stringsFromFile)
        {
            AddName(name);
        }
    }
    public void AddName(string name)
    {

        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }
    
    
    
    

    
}