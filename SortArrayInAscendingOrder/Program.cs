// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Sort an array in ascending order
        int[] a = { 5, 8, 1, 4, 3 };
        int temp = a[0];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])//Just This Part Change
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        foreach (var ele in a)
        {
            Console.Write(ele + ", ");
        }


    }
}