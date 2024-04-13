namespace AdvancedUseOfMethods.Exercises
{
    public class FuncAction
    {
        public void TestMethod()
        {
            Func<int, bool, double> Method1;

            Func<DateTime> Method2;

            Action<string, string> Method3;

        }

        public double Method1(int a, bool b) => 0;
        public DateTime Method2() => default(DateTime);
        public void Method3(string a, string b) { }
    }
}
