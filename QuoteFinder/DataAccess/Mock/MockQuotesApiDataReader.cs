using QuoteFinder.Models;
using System.Text.Json;

namespace QuoteFinder.DataAccess.Mock;

public class MockQuotesApiDataReader : IQuotesApiDataReader
{
    private readonly Random _random = new Random();

    public Task<string> ReadAsync(int page, int quotesPerPage)
    {
        var root = new Root
        {
            data = GenerateRandomData(quotesPerPage)
        };

        return Task.FromResult(JsonSerializer.Serialize(root));
    }

    private List<Datum> GenerateRandomData(int quotesPerPage)
    {
        return Enumerable.Range(0, quotesPerPage).Select(i =>
        new Datum
        {
            quoteText = GenerateRandomQuote(),
            quoteAuthor = "Unknown"
        }).ToList();
    }

    private string GenerateRandomQuote()
    {
        var length = _random.Next(5, 30);

        return string
            .Join(" ", Enumerable.Range(0, length)
            .Select(i => GetRandomWord()));
    }

    private string GetRandomWord()
    {
        var index = _random.Next(0, Words.All.Length);
        return Words.All[index];
    }

    public void Dispose()
    {
    }
}
