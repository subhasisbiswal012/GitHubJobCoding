// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Find the Second Largest of an array
        int[] arr = { 23, 65, 12, 67, 89 };
        //Take largest and second largest as MinValue
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        foreach (int i in arr)
        {
            if (i > largest)
            {
                secondLargest = largest;//Update Second Largest
                largest = i;//Update Largest
            }
            else if (i >= secondLargest && i != largest)
            {
                secondLargest = i; //Update Second Largest
            }
        }
        Console.WriteLine(secondLargest);//67
    }
}