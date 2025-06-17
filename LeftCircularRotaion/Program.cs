
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Left Circular Rotaion
        int[] arr = { 1, 2, 3, 4, 5 };
        int size = arr.Length;
        int temp = 0;
        for (int i = size - 1; i > 0; i--)
        {
            temp = arr[size - 1];
            arr[size - 1] = arr[i - 1];
            arr[i - 1] = temp;
        }
        foreach (var c in arr)
        {
            Console.Write(c + ", ");
        }//2, 3, 4, 5, 1, 
    }
}