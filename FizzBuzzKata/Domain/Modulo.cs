using System;
using System.Linq;

namespace FizzBuzzKata.Domain
{
    public class Modulo : IchBinEinAlgorithmus
    {
        public Func<int, int[], bool> IstAnwendbar
            => (dividend, divisoren)
                => divisoren.All(divisor => dividend % divisor == 0);
    }
}
