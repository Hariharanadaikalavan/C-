using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace After_1_review
{
    internal class Program
    {
        public void primenumber(int k)
        {
            while (true)
            {
                Console.WriteLine("Enter the number you want to check");
                int number = int.Parse(Console.ReadLine());
                if (number>=1 && number<=999) {
                    string choice;

  int counter = 0;

                    for (int i= 1; i <=number/2; i++)
                    {

                        if (number % i == 0)
                        {
                            counter++;
                        }
                    }

                    if (counter > 2)
                    {
                        Console.WriteLine("not prime numeber");
                    }
                    else
                    {
                        Console.WriteLine(" prime number");
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }

        }

        public void primenumber()
        {
            int number = int.Parse(Console.ReadLine());
            bool isprime = true;

            if (number < 2)
            {
                isprime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }
            string result = (isprime) ? "prime number" : "not a Prime Number";
            Console.WriteLine(result);
        }
        public void date()
        {
           
        }
        static void Main(string[] args)
        {
            Program prime = new Program();
           // prime.primenumber(55);
           prime.date();
        }
    }
}
