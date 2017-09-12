using System;

namespace FizzBuzzKata.Domain.Algorithmen
{
    public interface IchBinEinAlgorithmus
    {
        Func<int, int[], bool> IstAnwendbar { get; }
    }
}
