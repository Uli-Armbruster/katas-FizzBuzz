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
            var regelF�r3 = regelFactory.Erzeuge(new RegelFuer3(), fallbackRegel);
            var regelF�r5 = regelFactory.Erzeuge(new RegelFuer5(), regelF�r3);
            var regelF�r3Und5 = regelFactory.Erzeuge(new RegelFuer3Und5(), regelF�r5);

            _fizzbuzzRegeln = regelF�r3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzRegeln.Anwenden(zahl);
        }
    }
}
