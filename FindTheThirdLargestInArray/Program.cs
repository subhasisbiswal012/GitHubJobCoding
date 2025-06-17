// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Find the third Largest of an array
        int[] arr = { 23, 65, 12, 67, 89 };
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        int thirdLargest = int.MinValue;
        foreach (int i in arr)
        {
            if (i > largest)
            {
                thirdLargest = secondLargest;
                secondLargest = largest;
                largest = i;
            }
            else if (i > secondLargest && i != largest)
            {
                thirdLargest = secondLargest;
                secondLargest = i;
            }
            else if (i > thirdLargest && i != secondLargest && i != largest)
            {
                thirdLargest = i;
            }
        }
        Console.WriteLine(thirdLargest);//65

    }
}