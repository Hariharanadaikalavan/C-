namespace Enumeration
{
    internal class Program
    {
        
        public string helloName(string str)
        {
            return ($"Vankada maapla eppadi iruka {str}");
        }
        static void Main(string[] args)
        {
            Program obj= new Program(); 
            Console.WriteLine(obj.helloName("hariharan"));


        }
    }
