using System.Threading;

namespace AsynchronyAndMultithreading.Exercises
{
    public class RunThreeThreads
    {
        public static void RunThreads()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(
                () => Console.Write(
                    $"Hello from thread with ID: {Thread.CurrentThread.ManagedThreadId}"));

                thread.Start();
            }
        }
        
    }
}
