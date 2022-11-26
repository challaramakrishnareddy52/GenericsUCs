namespace GenericsUCs
{
    public class FindMaxGenericClass<T> where T : IComparable //UC3-refactor 2  Generic Class
    {
        public T first, second, third;
        public FindMaxGenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMaxValue(T first, T second, T third)  
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)  
            {
                Console.WriteLine($"{first} is greater");
                return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{second} is greater");
                return second;
            }
            else
            {
                Console.WriteLine($"{third} is greater ");
                return third;
            }
        }
        public void TestMaximum()
        {
            Console.WriteLine("The Max Value is : " + FindMaxValue(first, second, third)); //calling implicitly FindMaxValue() as per said condition.
        }
    }
}
