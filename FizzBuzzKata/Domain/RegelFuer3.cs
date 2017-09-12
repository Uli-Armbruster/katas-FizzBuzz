using System;

namespace FizzBuzzKata.Domain
{
    internal class RegelFuer3 : Tuple<string, int[]>
    {
        public RegelFuer3() : base("Fizz", new[] { 3 })
        {
        }
    }
}
