using System;

using FizzBuzzKata.Domain.Algorithmen;
using FizzBuzzKata.Domain.Regeln;

namespace FizzBuzzKata.Domain.Regelwerke
{
    internal class FizzBuzzStandard : IchBinEineRegel
    {
        private readonly IchBinEineRegel _fizzbuzzRegeln;

        public FizzBuzzStandard(Action<string> ausgabe)
        {
            var regelFactory = new Regeln.Regeln(ausgabe, new RestGleich0());

            var fallbackRegel = new RegelFallback(ausgabe);
            var regelF�r3 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3(), fallbackRegel);
            var regelF�r5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer5(), regelF�r3);
            var regelF�r3Und5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3Und5(), regelF�r5);

            _fizzbuzzRegeln = regelF�r3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzRegeln.Anwenden(zahl);
        }
    }
}
