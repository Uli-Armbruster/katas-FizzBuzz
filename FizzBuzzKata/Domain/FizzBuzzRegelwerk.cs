using System;

namespace FizzBuzzKata.Domain
{
    internal class FizzBuzzRegelwerk
    {
        private readonly Action<string> _ausgabe;

        public FizzBuzzRegelwerk(Action<string> ausgabe)
        {
            _ausgabe = ausgabe;
        }

        public void Anwenden(int zahl)
        {
            if (zahl % 3 == 0 && zahl % 5 == 0) //Domain
            {
                var ausgabe = "FizzBuzz"; //Domain
                _ausgabe(ausgabe); //Infrastruktur
                return; //Domain
            }

            if (zahl % 5 == 0) //Domain
            {
                var ausgabe = "Buzz"; //Domain
                _ausgabe(ausgabe); //Infrastruktur
                return; //Domain
            }

            if (zahl % 3 == 0) //Domain
            {
                var ausgabe = "Fizz"; //Domain
                _ausgabe(ausgabe); //Infrastruktur
                return; //Domain
            }

            _ausgabe(zahl.ToString()); //Domain
        }
    }
}