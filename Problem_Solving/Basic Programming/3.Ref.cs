using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paritalclass
{
    internal class Program
    {
        public void method(ref int i)
        {
            i =i*i;
            Console.WriteLine("During Operation-->"+i);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int b=25 ;
            Console.WriteLine("Before Passing-->"+b);
           obj.method(ref b);
            Console.WriteLine("After Passing-->"+b);
        }
    }
}
