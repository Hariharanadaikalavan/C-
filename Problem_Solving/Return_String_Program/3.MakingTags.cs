    internal class Program
    {
        
        public string MakingTag(string tag,string element)
        {
            return ($"<{tag}>{element}<{tag}/>");
        }
        static void Main(string[] args)
        {
            Program obj= new Program(); 
            Console.WriteLine(obj.MakingTag("h1","hari"));


        }
    }
}
output:-
makeTags("i", "Yay") → "<i>Yay</i>"
makeTags("i", "Hello") → "<i>Hello</i>"
makeTags("cite", "Yay") → "<cite>Yay</cite>"
