using System;

using FizzBuzzKata.Domain.Algorithmen;
using FizzBuzzKata.Domain.Regeln;

namespace FizzBuzzKata.Domain.Regelwerke
{
    internal class FizzBuzzModifiziert : IchBinEineRegel
    {
        private readonly IchBinEineRegel _fizzbuzzModifiedRegeln;

        public FizzBuzzModifiziert(Action<string> ausgabe)
        {
            var regelFactory = new Regeln.Regeln(ausgabe, new RestGleich2());

            var fallbackRegel = new RegelFallback(ausgabe);
            var regelFür3 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3(), fallbackRegel);
            var regelFür5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer5(), regelFür3);
            var regelFür3Und5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3Und5(), regelFür5);

            _fizzbuzzModifiedRegeln = regelFür3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzModifiedRegeln.Anwenden(zahl);
        }
    }
}
