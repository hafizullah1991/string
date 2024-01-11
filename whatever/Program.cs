using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "hafiz";
            int Number = 10;
            string company = "google";
             char A = 'A';
             double Poeple= 2.50;
            decimal dec = 22.33m;
            bool isTrue = true;
            bool isFale= false;

            Console.WriteLine($"my name is {Name}, I promise in next {Number} years I wil be an owner of a big company like {company}");
            Console.WriteLine($"I want get my Scores {A}+");
            Console.WriteLine($" {company} compnay has {Poeple} people working per shift" );
            Console.WriteLine($" I have over{dec}Million dollars , oh I's dream");
            Console.WriteLine($"I'm going to be Software engeenir very soon{isTrue} or {isFale}");
            Console.ReadLine();
        }
    }
}
