// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Remove Duplicate Character From a string
        string word = "csharpcorner";
        string s = string.Empty;
        foreach (var w in word.ToLower())
        {
            if (!s.Contains(w))
            {
                s += w;
            }
        }
        Console.WriteLine(s);

        //Using Distinct
        Console.WriteLine(new string(word.ToCharArray().Distinct().ToArray()));

    }
}