using SingleResponsibilityPrinciple.DataAccess;


var stopWatch = Stopwatch.StartNew();

for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"Loop number {i}");
}

stopWatch.Stop();
Console.WriteLine("Time in ms: " + stopWatch.ElapsedMilliseconds);
//var names = new Names();
//var path = new NamesFilePathBuilder().BuildFilePath();
//var stringsTextualRepository = new StringsTextualRepository();
//if (File.Exists(path))
//{
//    Console.WriteLine("Names file alread exists. Loading names.");
//    var stringsFromFile = stringsTextualRepository.Read(path);
//    names.AddNames(stringsFromFile);
//}
//else
//{
//    Console.WriteLine("Names file does not yet exist.");

//    // Let's imagine they are given by the user
//    names.AddName("John");
//    names.AddName("not a valid name");
//    names.AddName("Claire");
//    names.AddName("123 definitely not a valid name");

//    Console.WriteLine("Saving names to a file.");
//    stringsTextualRepository.Write(path, names.All);
    
//}
//Console.WriteLine(new NamesFormatter().Format(names.All));

Console.ReadKey();
