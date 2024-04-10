    internal class Program
    {
        
        public string abba(string str,string str2)
        {
            return ($"{str} {str2} {str2} {str}");
        }
        static void Main(string[] args)
        {
            Program obj= new Program(); 
            Console.WriteLine(obj.abba("hi","bye"));


        }
    }
}

Output:-
  makeAbba("Hi", "Bye") → "HiByeByeHi"
makeAbba("Yo", "Alice") → "YoAliceAliceYo"
makeAbba("What", "Up") → "WhatUpUpWhat"
