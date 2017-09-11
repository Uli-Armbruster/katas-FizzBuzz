namespace FizzBuzzKata.Domain
{
    internal class RegelFuer5 : IchBinEineRegel
    {
        public string Text => "Buzz";

        public bool IstAnwendbar(int zahl)
        {
            return zahl % 5 == 0;
        }
    }
}