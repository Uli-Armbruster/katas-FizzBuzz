using System;

namespace FizzBuzzKata.Domain
{
    internal class FizzBuzzRegelwerk : IchBinEineRegel
    {
        private readonly RegelFuer3Und5 _fizzbuzzRegeln;

        public FizzBuzzRegelwerk(Action<string> ausgabe)
        {
            var fallbackRegel = new RegelFallback(ausgabe);
            var regelF�r3 = new RegelFuer3(ausgabe, fallbackRegel);
            var regelF�r5 = new RegelFuer5(ausgabe, regelF�r3);
            var regelF�r3Und5 = new RegelFuer3Und5(ausgabe, regelF�r5);

            _fizzbuzzRegeln = regelF�r3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzRegeln.Anwenden(zahl);
        }
    }
}
