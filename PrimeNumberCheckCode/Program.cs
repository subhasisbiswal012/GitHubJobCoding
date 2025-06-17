class PrimeNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is Prime: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsPrime(number));
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}