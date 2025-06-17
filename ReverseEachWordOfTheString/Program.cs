namespace HelloSir;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Reverse Each Word in a string without chenging the order in sentence
        string sentence = "This is a Bike.";
        string[] arr = sentence.Split(' ');
        string rev = string.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            rev += new string(arr[i].ToCharArray().Reverse().ToArray());
            //for (int j = arr[i].Length - 1; j >= 0; j--)
            //{
            //    rev += arr[i][j];
            //}
            if (i < arr.Length)
            {
                rev += " ";
            }
        }
        Console.WriteLine(rev);
    }
}