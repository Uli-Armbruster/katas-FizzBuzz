using System;

namespace FizzBuzzKata.Domain
{
    internal class RegelFuer3Und5 : Tuple<string, int[]>
    {
        public RegelFuer3Und5() : base("FizzBuzz", new[] { 3, 5 })
        {
        }
    }
}
