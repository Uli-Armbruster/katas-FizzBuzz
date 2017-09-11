using System;

namespace FizzBuzzKata.Infrastruktur
{
    internal static class Ausgabe
    {
        public static Action<string> Konsole()
        {
            return Console.WriteLine;
        }
    }
}