using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 => 1
            //2 => 2
            //3 => Fizz
            //4 => 4
            //5 => 5
            //....
            //15 => FizzBuzz

            var zahlen = Enumerable.Range(1, 18);
            foreach (var zahl in zahlen)
            {
                if (zahl % 3 == 0 && zahl % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }

                if (zahl % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                if (zahl % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }

                Console.WriteLine(zahl);
            }

            Console.ReadKey();
        }
    }
}
