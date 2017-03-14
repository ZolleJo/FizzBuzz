using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int zahl = 0; zahl < 100; zahl++)
            {
                Console.Write(zahl);
                Console.Write(" ");
                int fizz = zahl % 3;
                int buzz = zahl % 5;
       
                if (fizz == 0) { Console.Write("Fizz");}
                if (buzz == 0) { Console.Write("Buzz"); }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
