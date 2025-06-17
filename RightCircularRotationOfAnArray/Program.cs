// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
   
    public static void Main(string[] args)
    {
        //Perform Right Circular Rotation of an array
        int[] arr = { 1, 2, 3, 4, 5 };
        int size = arr.Length;
        int temp = 0;
        for (int i = 0; i < size - 1; i++)
        {
            temp = arr[0];
            arr[0] = arr[i + 1];
            arr[i + 1] = temp;
        }
        foreach (var j in arr)
        {
            Console.Write(j + ", ");
        }//5, 1, 2, 3, 4, 
    }
}