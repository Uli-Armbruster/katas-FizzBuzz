using System;

namespace FizzBuzzKata.Domain
{
    internal class RegelFuer3 : IchBinEineRegel
    {
        private readonly Action<string> _ausgabe;
        private readonly IchBinEineRegel _nächsteRegel;

        public RegelFuer3(Action<string> ausgabe, IchBinEineRegel nächsteRegel)
        {
            _ausgabe = ausgabe;
            _nächsteRegel = nächsteRegel;
        }

        public void Anwenden(int zuPrüfendeZahl)
        {
            if (zuPrüfendeZahl % 3 == 0)
            {
                _ausgabe("Fizz");
                return;
            }

            _nächsteRegel.Anwenden(zuPrüfendeZahl);
        }
    }
}
