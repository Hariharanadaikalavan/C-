class reverse
{
    public void reversestring()
    {
        string name = "kasadara technology is a good company";
        string empty = "";

        for (int i = name.Length - 1; i > 0; i--)
        {
            empty = empty + name[i];
        }
        Console.WriteLine(empty);
    }

    public void removedeachwords()
    {
        string name = "i am from karikudi";
        string[] words = name.Split(' ');
        string reversestring = "";


        foreach (string word in words)
            Console.WriteLine(word);

        for (int j = 0; j < words.Length; j++)
        {
            string word = words[j];
            string reverseword = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseword = reverseword + word[i];
            }

            reversestring = reversestring + reverseword + " ";
        }

        Console.WriteLine(reversestring);



    }
    public void ReverseAtPlace()
    {
        string name = "i am mechanical engineer";
        string[] names = name.Split(' ');
        string reverseword = "";

        for (int i = 0; i < names.Length; i++)
        {
            string reversed = "";
            for (int j = names[i].Length - 1; j >= 0; j--)
            {
                reversed += names[i][j];
            }
            reverseword += reversed + " ";
        }

        Console.WriteLine(reverseword);
    }
}

        public class mainmethod
    {
        static void Main(string[] args)
        {
        rever.ReverseAtPlace();
         }
    }
}

