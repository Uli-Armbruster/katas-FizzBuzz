using System;

using FizzBuzzKata.Domain.Algorithmen;

namespace FizzBuzzKata.Domain.Regeln
{
    internal class Regeln
    {
        private readonly Action<string> _ausgabe;
        private readonly IchBinEinAlgorithmus _algorithmus;

        public Regeln(Action<string> ausgabe, IchBinEinAlgorithmus algorithmus)
        {
            _ausgabe = ausgabe;
            _algorithmus = algorithmus;
        }

        public IchBinEineRegel ErzeugeZahlenZuTextRegel(Tuple<string, int[]> regel,
                                                        IchBinEineRegel nächsteRegel)
        {
            Action ausgabe = () => _ausgabe(regel.Item1);

            return new ZahlenZuTextRegel(
                                         ausgabe,
                                         regel.Item2,
                                         nächsteRegel,
                                         _algorithmus
                                        );
        }

        private class ZahlenZuTextRegel : IchBinEineRegel
        {
            private readonly Action _ausgabe;
            private readonly int[] _divisoren;
            private readonly IchBinEineRegel _nächsteRegel;
            private readonly IchBinEinAlgorithmus _algorithmus;

            public ZahlenZuTextRegel(
                Action ausgabe,
                int[] divisoren,
                IchBinEineRegel nächsteRegel,
                IchBinEinAlgorithmus algorithmus)
            {
                _ausgabe = ausgabe;
                _divisoren = divisoren;
                _nächsteRegel = nächsteRegel;
                _algorithmus = algorithmus;
            }

            public void Anwenden(int dividend)
            {
                if (_algorithmus.IstAnwendbar(dividend, _divisoren))
                {
                    _ausgabe();
                    return;
                }

                _nächsteRegel.Anwenden(dividend);
            }
        }
    }
}
