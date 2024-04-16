//var countryToCurrencyMapping = new Dictionary<string, string>
//{
//    ["USA"] = "USD",
//    ["India"] = "INR",
//    ["Spain"] = "EUR",
//};

//var countryToCurrencyMapping = new Dictionary<string, string>
//{
//    { "USA", "USD" },
//    { "India", "INR" },
//    { "Spain", "EUR" },
//};

var countryToCurrencyMapping = new Dictionary<string, string>();
countryToCurrencyMapping.Add("USA", "USD");
countryToCurrencyMapping.Add("India", "INR");
countryToCurrencyMapping.Add("Spain", "EUR");
countryToCurrencyMapping.Add("Italy", "EUR");

//Console.WriteLine("Currency in Spain is " +
//    countryToCurrencyMapping["Spain"]);

//if (countryToCurrencyMapping.ContainsKey("Italy"))
//{
//    Console.WriteLine("Currency in Italy is " +
//        countryToCurrencyMapping["Italy"]);
//}

countryToCurrencyMapping["Poland"] = "PLN";

foreach (var country in countryToCurrencyMapping)
{
    Console.WriteLine(
        $"Country: {country.Key}, "+
        $"currency: {country.Value}");
}
Console.ReadKey();
