namespace PracticeNamespace
{
	class Practice
	{
        static void Main(string[] args)
        {
            //Revesre a string using LINQ
            string name = "Subhasis";
            Console.WriteLine(new string(name.ToCharArray().Reverse().ToArray()));

            //Using Loop
            string reversed = string.Empty; 
            for(int i = name.Length -1;i >= 0; i--)
            {
                reversed += name[i];
            }
            Console.WriteLine(reversed);

        }

    }
}
