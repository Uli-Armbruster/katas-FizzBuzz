using System;

using FizzBuzzKata.Domain.Algorithmen;
using FizzBuzzKata.Domain.Regeln;

namespace FizzBuzzKata.Domain.Regelwerke
{
    internal class FizzBuzzErweitert : IchBinEineRegel
    {
        private readonly IchBinEineRegel _fizzbuzzExtendedRegeln;

        public FizzBuzzErweitert(Action<string> ausgabe)
        {
            var regelFactory = new Regeln.Regeln(ausgabe, new RestGleich0());

            var fallbackRegel = new RegelFallback(ausgabe);
            var regelF�r3 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3(), fallbackRegel);
            var regelF�r5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer5(), regelF�r3);
            var regelF�r3Und5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3Und5(), regelF�r5);

            var fizzBuzzExtended = Tuple.Create("FizzBuzzExtended", new[] { 3, 5, 10 });
            var regelF�r3Und5Und10 = regelFactory.ErzeugeZahlenZuTextRegel(fizzBuzzExtended, regelF�r3Und5);

            _fizzbuzzExtendedRegeln = regelF�r3Und5Und10;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzExtendedRegeln.Anwenden(zahl);
        }
    }
}
