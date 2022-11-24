namespace GenericsUCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Use Case's ");
            FindMaximum.FindMaxValue(10, 20, 30);
            FindMaximum.FindMaxValue(20.20f, 30.20f, 40.40f);
            FindMaximum.FindMaxValue("abc", "pqr", "xyz");
        }
    }
}
