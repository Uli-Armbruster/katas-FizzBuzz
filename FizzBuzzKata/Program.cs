using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FizzBuzzKata.Domain;
using FizzBuzzKata.Infrastruktur;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            //API First

            //Infrastruktur
            var ausgabe = Ausgabe.Konsole(); //Ausgabe: Text
            var zahlen = new GanzzahlenSequenz(1, 18); //Eingabe: Zahlen sammeln/erzeugen

            //Domain
            var regelwerk = new FizzBuzzRegelwerk(ausgabe); //Verarbeitung: Zahl => Text

            //Infrastruktur
            zahlen.RegelnAnwenden(regelwerk);
            Console.ReadKey();
        }

       
    }
}
