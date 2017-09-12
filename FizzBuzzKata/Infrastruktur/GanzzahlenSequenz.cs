using System.Linq;

using FizzBuzzKata.Domain.Regeln;
using FizzBuzzKata.Domain.Regelwerke;

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

        public void RegelnAnwenden(IchBinEineRegel standard)
        {
            Enumerable
                .Range(_start, _ende)
                .ToList()
                .ForEach(standard.Anwenden);
        }
    }
}
