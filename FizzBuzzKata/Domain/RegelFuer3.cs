namespace FizzBuzzKata.Domain
{
    internal class RegelFuer3 : IchBinEineRegel
    {
        public string Text => "Fizz";

        public bool IstAnwendbar(int zahl)
        {
            return zahl % 3 == 0;
        }
    }
}