using System;
using System.Collections.Generic;

namespace FizzBuzzKata.Domain
{
    internal class FizzBuzzRegelwerk
    {
        private readonly RegelFuer3Und5 _fizzbuzzRegeln;

        public FizzBuzzRegelwerk(Action<string> ausgabe)
        {
            var fallbackRegel = new RegelFallback(ausgabe);
            var regelFür3 = new RegelFuer3(ausgabe, fallbackRegel);
            var regelFür5 = new RegelFuer5(ausgabe, regelFür3);
            var regelFür3Und5 = new RegelFuer3Und5(ausgabe, regelFür5);

            _fizzbuzzRegeln = regelFür3Und5;
        }

        public void Anwenden(int zahl)
        {
            _fizzbuzzRegeln.Anwenden(zahl);
        }
    }
}
