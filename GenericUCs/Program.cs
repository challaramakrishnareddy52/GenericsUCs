using GenericsUCs;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Generic Use Case's ");
        Console.WriteLine("Choose any one from below options");
        Console.WriteLine("1:Find Max Num\n" +
            "2:FindMax using Generic Method\n" +
            "3:FindMax using Generic Class\n" +
            "4:Param Concept~takes any no of parameters");

        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                FindMaximum.FindMaxValue(20, 30, 40);
                FindMaximum.FindMaxValue(20.20f, 30.20f, 40.40f);
                FindMaximum.FindMaxValue("abc", "def", "ghi");
                break;
            case 2:
                FindMaxGenericMethod<int>.FindMaxValue(11, 23, 30);
                FindMaxGenericMethod<float>.FindMaxValue(20.45f, 30.11f, 12.99f);
                FindMaxGenericMethod<string>.FindMaxValue("abc", "def", "ghi");
                break;
            case 3:
                new FindMaxGenericClass<int>(20, 30, 12).TestMaximum();
                new FindMaxGenericClass<float>(20.45f, 30.11f, 12.99f).TestMaximum();
                new FindMaxGenericClass<string>("abc", "def", "ghi").TestMaximum();
                break;
            case 4:     //UC4 
                FindMaxParams.MaxValue(45, 23, 54, 6, 23, 43);
                FindMaxParams.MaxValue(45, 6, 23, 43);
                break;
            default:
                Console.WriteLine("Please choose number within given range!");
                break;
        }
    }
}