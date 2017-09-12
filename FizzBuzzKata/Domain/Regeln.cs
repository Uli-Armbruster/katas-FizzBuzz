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
            Func<int, int[], bool> moduloAlgorithmus = (dividend, divisoren)
                => divisoren.All(divisor => dividend % divisor == 0);
             
            return new ZahlenZuTextRegel(
                                         ausgabe,
                                         regel.Item2,
                                         nächsteRegel,
                                         moduloAlgorithmus
                                        );
        }

        private class ZahlenZuTextRegel : IchBinEineRegel
        {
            private readonly Action _ausgabe;
            private readonly int[] _divisoren;
            private readonly IchBinEineRegel _nächsteRegel;
            private readonly Func<int, int[], bool> _algorithmus;

            public ZahlenZuTextRegel(
                Action ausgabe, 
                int[] divisoren, 
                IchBinEineRegel nächsteRegel,
                Func<int, int[], bool> algorithmus)
            {
                _ausgabe = ausgabe;
                _divisoren = divisoren;
                _nächsteRegel = nächsteRegel;
                _algorithmus = algorithmus;
            }

            public void Anwenden(int dividend)
            {
                if (_algorithmus(dividend, _divisoren))
                {
                    _ausgabe();
                    return;
                }

                _nächsteRegel.Anwenden(dividend);
            }
        }
    }
}
