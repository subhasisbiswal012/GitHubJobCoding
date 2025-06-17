public class HelloWorld
{
    public static void Main(string[] args)
    {
        //swap two values without third variable
        int a = 15; int b = 5;
        //Set the Bigger one for sum fisrt
        a = a + b; // a = 20
        //Set the smaller first for subtract
        b = a - b; //b = 15
        a = a - b;// a = 5
        Console.WriteLine($"a = {a}, b = {b}");

    }
}
