using var client = new HttpClient();
client.BaseAddress = new Uri("https://datausa.io/api/");
HttpResponseMessage response = await client.GetAsync(
    "data?drilldowns=Nation&measures=Population");

response.EnsureSuccessStatusCode();

string json = await response.Content.ReadAsStringAsync();


Console.ReadKey();
