using static System.Console;
public class ReverseStringProblem
{
    static void Main(string[] args)
    {
        //Using LINQ
        string str = "Automation";
        WriteLine(new string(str.ToCharArray().Reverse().ToArray()));

        //Or
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));

        //Using Loop
        string reversed = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }
        WriteLine(reversed);
    }
}

