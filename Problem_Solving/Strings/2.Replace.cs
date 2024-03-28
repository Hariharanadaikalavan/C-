 namespace practics
{
    internal class Program
    {
      public void Replace()
 {
     string name = "kasadara";
     char[] ch=name.ToCharArray();
     for (int i = 0; i < ch.Length; i++)
     {
         if (ch[i] == 'a')
         {
             ch[i] = '$';
         }
     }
    
     Console.WriteLine(ch);    
 }

       static void Main(string[] args)
 {
     Program dupli= new Program();
     dupli.Replace(5);
       }
 }
