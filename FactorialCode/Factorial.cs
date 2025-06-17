
class FactorialCode
{
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateFactorial(0));
        Console.WriteLine(CalculateFactorial(3));
        Console.WriteLine(CalculateFactorial(4));
    }

    private static int CalculateFactorial(int v)
    {
        if (v == 0) 
        {
            return 1;
        }
        else
        {
            return v*CalculateFactorial(v-1);
        }
    }
}
