// Get the current working directory
namespace TicketsDataAggregator.FileAccess;

public interface IFileWriter
{
    void WriteTo(
        string content, params string[] pathParts);
}
