// Get the current working directory
namespace TicketsDataAggregator.FileAccess;

public interface IDocumentsReader
{
    IEnumerable<string> Read(string directory);
}
