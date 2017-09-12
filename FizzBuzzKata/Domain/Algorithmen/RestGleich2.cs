using System;
using System.Linq;

namespace FizzBuzzKata.Domain.Algorithmen
{
    public class RestGleich2:IchBinEinAlgorithmus
    {
        public Func<int, int[], bool> IstAnwendbar
            => (dividend, divisoren)
                => divisoren.All(divisor => dividend % divisor == 2);
    }
}
