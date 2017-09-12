using System;

namespace FizzBuzzKata.Domain
{
    internal class RegelFuer5 : IchBinEineRegel
    {
        private readonly Action<string> _ausgabe;
        private readonly IchBinEineRegel _nächsteRegel;

        public RegelFuer5(Action<string> ausgabe, IchBinEineRegel nächsteRegel)
        {
            _ausgabe = ausgabe;
            _nächsteRegel = nächsteRegel;
        }

        public void Anwenden(int zuPrüfendeZahl)
        {
            if (zuPrüfendeZahl % 5 == 0)
            {
                _ausgabe("Buzz");
                return;
            }

            _nächsteRegel.Anwenden(zuPrüfendeZahl);
        }
    }
}