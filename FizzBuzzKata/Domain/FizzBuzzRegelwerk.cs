using System;
using System.Collections.Generic;

namespace FizzBuzzKata.Domain
{
    internal class FizzBuzzRegelwerk
    {
        private readonly Action<string> _ausgabe;
        private readonly List<IchBinEineRegel> _regeln;

        public FizzBuzzRegelwerk(Action<string> ausgabe)
        {
            _ausgabe = ausgabe;

            _regeln = new List<IchBinEineRegel>
            {
                new RegelFuer3Und5(),
                new RegelFuer5(),
                new RegelFuer3(),
                new RegelFallback()
            };
        }

        public void Anwenden(int zahl)
        {
            foreach (var regel in _regeln)
            {
                if (!regel.IstAnwendbar(zahl))
                {
                    continue;
                }

                _ausgabe(regel.Text);
                break;
            }
        }
    }
}
