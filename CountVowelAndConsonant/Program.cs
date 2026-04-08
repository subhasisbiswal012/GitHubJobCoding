class CountVowelAndConsonant
{
    static void Main(string[] args)
    {
        string str = "Automation";
        int vowel = 0, consonant = 0;
        foreach (char str2 in str)
        {
            if(char.IsLetter(str2))//Check if the char is letter or any other like space and special character
            {
                if ("aeiouAEIOU".IndexOf(str2) >= 0) // For Consonant this will return -1 we can also check"aeiouAEIOU".IndexOf(str2) != -1
                {
                    vowel++;
                }
                else 
                { 
                    consonant++; 
                } 
            }
        }
        Console.WriteLine($"Vowe Count = {vowel}, Consonant Count = {consonant}");
    }


    //Contains intead of IndexOf and use of tuple
    public static (int, int) CountVowelAndConstant(string str)
    {
        str = str.ToLower();
        int v = 0;
        int c = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if ("aeiouAEIOU".Contains(str[i]))
            {
                v++;
            }
            else
            {
                c++;
            }
        }
        return (v, c);
    }
}


