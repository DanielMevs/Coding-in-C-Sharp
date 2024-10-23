namespace AsynchronyAndMultithreading.Exercises
{
    public class TasksAndWaiting
    {
        public static void RunSimpleTask()
        {
            Console.WriteLine("Before task starting.");

            var task = Task.Run(() => {
                for (int i = 1; i <= 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Iteration number {i}");
                }
            });

            task.Wait();

            Console.WriteLine("The task has finished.");
        }
    }
}
