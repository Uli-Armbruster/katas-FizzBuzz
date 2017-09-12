using System;

using FizzBuzzKata.Domain.Regelwerke;
using FizzBuzzKata.Infrastruktur;

namespace FizzBuzzKata
{
    internal class Program
    {
        private static void Main(string[] args)
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
