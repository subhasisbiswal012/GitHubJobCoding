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
    }

}