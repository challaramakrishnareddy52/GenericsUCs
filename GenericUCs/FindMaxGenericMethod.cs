namespace GenericsUCs;

internal class FindMaxGenericMethod<T>where T : IComparable
{
    public static void FindMaxValue(T first, T second, T third)  
    {
        if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
        {
            Console.WriteLine($"{first} is greater");
        }
        else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
        {
            Console.WriteLine($"{second} is greater");
        }
        else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
        {
            Console.WriteLine($"{third} is greater ");
        }
        else
            Console.WriteLine("All Numbers are Equal! ");
    }
}
