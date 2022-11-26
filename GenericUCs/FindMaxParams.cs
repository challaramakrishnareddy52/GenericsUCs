namespace GenericsUCs;


public class FindMaxParams
{
    public static void MaxValue(params int[] values)
    {
        Array.Sort(values);
        Console.WriteLine("Maximum Value : " + values[values.Length - 1]);
    }
}
