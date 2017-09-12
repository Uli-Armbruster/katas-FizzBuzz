using System;

namespace FizzBuzzKata.Domain
{
    public interface IchBinEinAlgorithmus
    {
        Func<int, int[], bool> IstAnwendbar { get; }
    }
}