using System;
using System.Linq;

namespace FizzBuzzKata.Domain
{
    internal class Regeln
    {
        private readonly Action<string> _ausgabe;

        public Regeln(Action<string> ausgabe)
        {
            _ausgabe = ausgabe;
        }

        public IchBinEineRegel Erzeuge(Tuple<string, int[]> regel,
                                       IchBinEineRegel nächsteRegel)
        {
            Action ausgabe = () => _ausgabe(regel.Item1);

            return new ZahlenZuTextRegel(
                                         ausgabe,
                                         regel.Item2,
                                         nächsteRegel
                                        );
        }

        private class ZahlenZuTextRegel : IchBinEineRegel
        {
            private readonly Action _ausgabe;
            private readonly int[] _divisoren;
            private readonly IchBinEineRegel _nächsteRegel;

            public ZahlenZuTextRegel(Action ausgabe, int[] divisoren, IchBinEineRegel nächsteRegel)
            {
                _ausgabe = ausgabe;
                _divisoren = divisoren;
                _nächsteRegel = nächsteRegel;
            }

            public void Anwenden(int dividend)
            {
                if (_divisoren.All(divisor => dividend % divisor == 0))
                {
                    _ausgabe();
                    return;
                }

                _nächsteRegel.Anwenden(dividend);
            }
        }
    }
}
