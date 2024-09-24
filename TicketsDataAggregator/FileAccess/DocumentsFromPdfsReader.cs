// Get the current working directory
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace TicketsDataAggregator.FileAccess;

public class DocumentsFromPdfsReader : IDocumentsReader
{
    public IEnumerable<string> Read(string directory)
    {
        foreach (var filePath in Directory.GetFiles(
            directory, "*.pdf"))
        {
            using PdfDocument document = PdfDocument.Open(filePath);
            // Page number starts from 1, not 0.
            Page page = document.GetPage(1);
            yield return page.Text;
        }
    }
}
