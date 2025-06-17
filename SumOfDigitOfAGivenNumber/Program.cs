// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Sum of digits of a given number
        int num = 12345;
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10; //Extract the last digit
            num = num / 10; //remove the last digit
        }
        Console.WriteLine(sum); //15
    }
}