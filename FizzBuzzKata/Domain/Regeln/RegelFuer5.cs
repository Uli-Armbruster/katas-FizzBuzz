using System;

namespace FizzBuzzKata.Domain.Regeln
{
    internal class RegelFuer5 : Tuple<string, int[]>
    {
        public RegelFuer5() : base("Buzz", new[] { 5 })
        {
        }
    }
}
