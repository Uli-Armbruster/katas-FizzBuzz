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
            //Eingabe: Zahlen sammeln/erzeugen
            //Verarbeitung: Zahl => Text
            //Ausgabe: Text

            //API First
            var ausgabe = Ausgabe.Konsole;
            var zahlen = new GanzzahlenSequenz(1, 18);
            var regelwerk = FizzBuzzRegelwerk(ausgabe);
            zahlen.Anwenden(regelwerk);

            var zahlen = Enumerable.Range(1, 18); //Infrastruktur
            foreach (var zahl in zahlen) //Infrastruktur
            {
                if (zahl % 3 == 0 && zahl % 5 == 0) //Domain
                {
                    var ausgabe = "FizzBuzz"; //Domain
                    Console.WriteLine(ausgabe); //Infrastruktur
                    continue; //Domain
                }

                if (zahl % 5 == 0) //Domain
                {
                    var ausgabe = "Buzz"; //Domain
                    Console.WriteLine(ausgabe); //Infrastruktur
                    continue; //Domain
                }

                if (zahl % 3 == 0) //Domain
                {
                    var ausgabe = "Fizz"; //Domain
                    Console.WriteLine(ausgabe); //Infrastruktur
                    continue; //Domain
                }

                Console.WriteLine(zahl); //Domain
            }

            Console.ReadKey();
        }
    }
}
