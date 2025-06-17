class FibonacciSeries
{
    static void Main(string[] args)
    {
        //The Fibonacci series is a sequence of numbers in which each number is the sum of the two preceding ones, typically starting with 0 and 1. Thus, the sequence begins: 0, 1, 1, 2, 3, 5, 8, 13, 21, and so on.
        int numberCount = 10, first = 0, second = 1, next;
        Console.Write($"Fibonacci Series..{first}, {second}");
        for (int i = 2; i < numberCount; i++)
        {
            next = first + second;
            Console.Write($", {next}");
            first = second;
            second = next;
        }
    }
}
