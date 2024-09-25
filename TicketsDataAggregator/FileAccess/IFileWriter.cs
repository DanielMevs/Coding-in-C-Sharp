namespace TicketsDataAggregator.FileAccess;

public interface IFileWriter
{
    void WriteTo(
        string content, params string[] pathParts);
}
