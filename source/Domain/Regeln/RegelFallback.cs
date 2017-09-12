using System;

namespace FizzBuzzKata.Domain.Regeln
{
    internal class RegelFallback : IchBinEineRegel
    {
        private readonly Action<string> _ausgabe;

        public RegelFallback(Action<string> ausgabe)
        {
            _ausgabe = ausgabe;
        }

        public void Anwenden(int zuPr�fendeZahl)
        {
            _ausgabe(zuPr�fendeZahl.ToString());
        }
    }
}
