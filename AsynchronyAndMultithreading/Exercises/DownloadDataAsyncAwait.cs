namespace AsynchronyAndMultithreading.Exercises
{
    public class DownloadDataAsyncAwait
    {
        public async void Test()
        {
            string data = await DownloadDataAsync("test.com", "some content");
            Console.WriteLine(data);
        }

        //your code goes here
        public async Task<string> DownloadDataAsync(string url, string content)
        {
            await Task.Delay(1000);
            return $"Content from URL '{url}' is '{content}'";

        }
    }
}
