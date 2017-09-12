using System;

namespace FizzBuzzKata.Domain
{
    internal class RegelFuer3Und5 : IchBinEineRegel
    {
        private readonly Action<string> _ausgabe;
        private readonly IchBinEineRegel _nächsteRegel;

        public RegelFuer3Und5(Action<string> ausgabe, IchBinEineRegel nächsteRegel)
        {
            _ausgabe = ausgabe;
            _nächsteRegel = nächsteRegel;
        }

        public void Anwenden(int zuPrüfendeZahl)
        {
            if (zuPrüfendeZahl % 3 == 0
                && zuPrüfendeZahl % 5 == 0)
            {
                _ausgabe("FizzBuzz");
                return;
            }

            _nächsteRegel.Anwenden(zuPrüfendeZahl);
        }
    }
}