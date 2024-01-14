var intnlPizzaDay23 = new DateTime(2023, 2, 9);

Console.WriteLine($"Year is {intnlPizzaDay23.Year}");
Console.WriteLine($"Month is {intnlPizzaDay23.Month}");
Console.WriteLine($"Day is {intnlPizzaDay23.Day}");
Console.WriteLine($"Day of the week is {intnlPizzaDay23.DayOfWeek}");

var intnlPizzaDay24 = intnlPizzaDay23.AddYears(1);

Console.WriteLine($"Year is {intnlPizzaDay24.Year}");
Console.WriteLine($"Month is {intnlPizzaDay24.Month}");
Console.WriteLine($"Day is {intnlPizzaDay24.Day}");
Console.WriteLine($"Day of the week is {intnlPizzaDay24.DayOfWeek}");

Console.ReadKey();
