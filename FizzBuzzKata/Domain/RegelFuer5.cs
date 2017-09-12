using System;

namespace FizzBuzzKata.Domain
{
    internal class RegelFuer5 : IchBinEineRegel
    {
        private readonly Action<string> _ausgabe;
        private readonly IchBinEineRegel _n�chsteRegel;

        public RegelFuer5(Action<string> ausgabe, IchBinEineRegel n�chsteRegel)
        {
            _ausgabe = ausgabe;
            _n�chsteRegel = n�chsteRegel;
        }

        public void Anwenden(int zuPr�fendeZahl)
        {
            if (zuPr�fendeZahl % 5 == 0)
            {
                _ausgabe("Buzz");
                return;
            }

            _n�chsteRegel.Anwenden(zuPr�fendeZahl);
        }
    }
}