// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Order a array descending order order
        int[] a = { 1, 5, 0, 2, 9 };
        int temp = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] < a[j])//Just This Part Change
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        foreach (var e in a)
        {
            Console.WriteLine(e);
        }

    }


}