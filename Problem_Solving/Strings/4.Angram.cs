
public class program{
  
   public void Anagram()
        {
            string str1 = "hariharan";
            char[]str=str1.ToCharArray();

            string str2 = "haranhari";
            char[]st=str2.ToCharArray();

            for (int i = 0; i < str.Length-1; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] > str[j])
                    {
                        char temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            for (int i = 0; i < st.Length - 1; i++)
            {
                for (int j = i + 1; j < st.Length; j++)
                {
                    if (st[i] > st[j])
                    {
                        char temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }

            string result = (Array.Equals(str.ToString(),st.ToString())) ? "Anagram" : "Not a Anagram";
            Console.WriteLine(st);  
            Console.WriteLine(str);
            Console.WriteLine(result);  

        }
        static void Main(string[] args)
        {
            Program gram = new Program();
            gram.Anagram();
        }
    }
}
