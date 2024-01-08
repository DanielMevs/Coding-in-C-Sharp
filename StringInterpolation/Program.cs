int a = 4, b = 2, c = 3;
//Instead of 
Console.WriteLine(
    "First is: " + a + ", second is: " + b + ", third is: " + c);

// Use String inpolation
Console.WriteLine($"First is: {a}, second is {b}, third is: {c}");
Console.ReadKey();