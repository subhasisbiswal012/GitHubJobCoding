// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a = "hello";//5
        string b = "world";//5
        a = a + b;//helloworld//10
        b = a.Substring(0, a.Length - b.Length);
        a = a.Substring(b.Length);
        Console.WriteLine($"a = {a}, b = {b}");


        string val1 = "Hellore";
        string val2 = "There";
        val2 = val1 + val2;
        val1 = val2.Substring(val1.Length);
        val2 = val2.Substring(0, val2.Length - val1.Length);
        Console.WriteLine(val1);
        Console.WriteLine(val2);
    }

}