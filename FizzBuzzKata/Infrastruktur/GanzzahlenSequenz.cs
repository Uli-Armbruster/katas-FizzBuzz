using System;
using System.Linq;

using FizzBuzzKata.Domain;

namespace FizzBuzzKata.Infrastruktur
{
    internal class GanzzahlenSequenz
    {
        private readonly int _start;
        private readonly int _ende;

        public GanzzahlenSequenz(int start, int ende)
        {
            _start = start;
            _ende = ende;
        }

        public void RegelnAnwenden(FizzBuzzRegelwerk regelwerk)
        {
            Enumerable
                .Range(1, 18)
                .ToList()
                .ForEach(regelwerk.Anwenden);
        }
    }
}