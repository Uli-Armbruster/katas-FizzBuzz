using System;

using FizzBuzzKata.Domain.Algorithmen;
using FizzBuzzKata.Domain.Regeln;

namespace FizzBuzzKata.Domain.Regelwerke
{
    public class FizzBuzzOnSteroids : IchBinEineRegel
    {
        private readonly IchBinEineRegel _fizzbuzzOnSteroidsRegeln;

        public FizzBuzzOnSteroids(Action<string> ausgabe)
        {
            var regelFactory = new Regeln.Regeln(ausgabe, new RestGleich2());

            var fallbackRegel = new RegelFallback(ausgabe);
            var regelFür3 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3(), fallbackRegel);
            var regelFür5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer5(), regelFür3);
            var regelFür3Und5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3Und5(), regelFür5);

            var fizzBuzzExtended = Tuple.Create("FizzBuzzExtended", new[] { 3, 5, 10 });
            var regelFür3Und5Und10 = regelFactory.ErzeugeZahlenZuTextRegel(fizzBuzzExtended, regelFür3Und5);

            _fizzbuzzOnSteroidsRegeln = regelFür3Und5Und10;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzOnSteroidsRegeln.Anwenden(zahl);
        }
    }
}
