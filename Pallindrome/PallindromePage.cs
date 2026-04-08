using System.Net.Http.Headers;
using static System.Console;

class PallindromeClass
{
    static void Main(string[] args)
    {
        //Using Array
        string str = "madam";
        string pall = new string(str.ToCharArray().Reverse().ToArray());
        WriteLine(string.Equals(str, pall, StringComparison.OrdinalIgnoreCase));

        //Without LINQ

    }
}
