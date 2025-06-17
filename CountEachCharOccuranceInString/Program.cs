// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Count the occurance of each character in a string
        Dictionary<char, int> charcount = new Dictionary<char, int>();
        string word = "Hello, World";
        foreach (char c in word)
        {
            if (charcount.ContainsKey(c))
            {
                charcount[c]++;
            }
            else
            {
                charcount[c] = 1;
            }
        }

        foreach (var ele in charcount)
        {
            Console.WriteLine($"Character {ele.Key} count is {ele.Value}");
        }

    }
}

//Character H count is 1
//Character e count is 1
//Character l count is 3
//Character o count is 2
//Character , count is 1
//Character   count is 1
//Character W count is 1
//Character r count is 1
//Character d count is 1

