using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paritalclass
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string age=Console.ReadLine();

            if (double.TryParse(age,out double updatedage))
            {
                int variable=(int)updatedage;
                Console.WriteLine(variable);
            }
            else
            {
                Console.WriteLine("enter valid input");
            }

        }
    }
}
