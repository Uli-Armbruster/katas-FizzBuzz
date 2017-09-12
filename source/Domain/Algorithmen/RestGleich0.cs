using System;
using System.Linq;

namespace FizzBuzzKata.Domain.Algorithmen
{
    internal class RestGleich0 : IchBinEinAlgorithmus
    {
        public Func<int, int[], bool> IstAnwendbar
            => (dividend, divisoren)
                => divisoren.All(divisor => dividend % divisor == 0);
    }
}
