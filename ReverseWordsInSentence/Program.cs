namespace RevWords
{
    class RevWord
    {
        static void Main(string[] args)
        {
            //Revrse the order of the word in sentence
            string sentence = "This is a bike";
            string[] splitstr = sentence.Split(' ');
            //Using For loop
            string revSen = string.Empty;
            for (int i = splitstr.Length - 1; i >= 0; i--)
            {
                revSen += splitstr[i];
                if (i > 0)
                {
                    revSen += " ";
                }
            }
            //Using Reverse Scenario
            Array.Reverse(splitstr);
            Console.WriteLine(String.Join(" ", splitstr));
            Console.WriteLine(revSen);
        }
    }
}
