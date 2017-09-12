using System.Linq;

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

        public void RegelnAnwenden(FizzBuzzRegelwerk regelwerk)
        {
            Enumerable
                .Range(_start, _ende)
                .ToList()
                .ForEach(regelwerk.Anwenden);
        }
    }
}
