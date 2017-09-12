using System;
using System.Collections.Generic;

using FizzBuzzKata.Domain.Regeln;
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
            var zahlen = new GanzzahlenSequenz(1, 40); //Eingabe: Zahlen sammeln/erzeugen

            //Domain
            //Verarbeitung: Zahl => Text
            var regelwerke = new Dictionary<string, IchBinEineRegel>
            {
                { "FizzBuzz Standard", new FizzBuzzStandard(ausgabe) },
                { "FizzBuzz Erweitert", new FizzBuzzErweitert(ausgabe) },
                { "FizzBuzz Modifiziert", new FizzBuzzModifiziert(ausgabe) },
                { "FizzBuzz On Steroids", new FizzBuzzOnSteroids(ausgabe) }
            };


            foreach (var regelwerk in regelwerke)
            {
                Console.WriteLine($"Regelwerk: {regelwerk.Key}");

                zahlen.RegelnAnwenden(regelwerk.Value);
                
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Demo ist zu Ende");
            Console.ReadKey();
        }
    }
}
