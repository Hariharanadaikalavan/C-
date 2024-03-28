namespace duplicate
{
    internal class Program
    {
        public void duplicate()
        {
            string name = "hariharan";
            int count = 0;
            String s1 = "";
            String s2 = "";
            while (name.Length > 0)
            {
                char c = name[0];
                string s = name.Replace(c + "", "");
                 count = name.Length - s.Length;
                name = s;
                Console.WriteLine(c + "-->" + count);


                if (count == 1)
                {
                    s1 += c + ",";
                }
                else
                {
                    s2 += c + ",";
                }
                //Console.WriteLine();
                //Console.Write("Unique...." + s1);

            }
            Console.WriteLine("unique..."+s1);
            Console.WriteLine("duplicate..."+s2);  
        }
               static void Main(string[] args)
        {
            Program dupli= new Program();
            dupli.duplicate();   
      }
    }
}
