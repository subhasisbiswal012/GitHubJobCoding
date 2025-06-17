// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 34, 2, 87, 1 };//1, 2
        Dictionary<int, int> dc = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();
        foreach (int i in a)
        {
            if (dc.ContainsKey(i))
            {
                duplicates.Add(dc[i]);
            }
            else
            {
                dc[i] = 1;
            }
        }
       
        foreach (var j in duplicates)
        {
            Console.WriteLine(j + ", ");
        }
    }
}
