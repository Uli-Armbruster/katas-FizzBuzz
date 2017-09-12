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
            var regelFür3 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3(), fallbackRegel);
            var regelFür5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer5(), regelFür3);
            var regelFür3Und5 = regelFactory.ErzeugeZahlenZuTextRegel(new RegelFuer3Und5(), regelFür5);

            _fizzbuzzRegeln = regelFür3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzRegeln.Anwenden(zahl);
        }
    }
}
