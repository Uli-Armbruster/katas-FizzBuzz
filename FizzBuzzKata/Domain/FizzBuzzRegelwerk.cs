using System;

namespace FizzBuzzKata.Domain
{
    internal class FizzBuzzRegelwerk : IchBinEineRegel
    {
        private readonly IchBinEineRegel _fizzbuzzRegeln;

        public FizzBuzzRegelwerk(Action<string> ausgabe)
        {
            var regelFactory = new Regeln(ausgabe, new Modulo());

            var fallbackRegel = new RegelFallback(ausgabe);
            var regelFür3 = regelFactory.Erzeuge(new RegelFuer3(), fallbackRegel);
            var regelFür5 = regelFactory.Erzeuge(new RegelFuer5(), regelFür3);
            var regelFür3Und5 = regelFactory.Erzeuge(new RegelFuer3Und5(), regelFür5);

            _fizzbuzzRegeln = regelFür3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzRegeln.Anwenden(zahl);
        }
    }
}
