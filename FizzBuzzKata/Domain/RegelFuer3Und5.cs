namespace FizzBuzzKata.Domain
{
    internal class RegelFuer3Und5 : IchBinEineRegel
    {
        public string Text => "FizzBuzz";

        public bool IstAnwendbar(int zahl)
        {
            return zahl % 3 == 0
                   && zahl % 5 == 0;
        }
    }
}