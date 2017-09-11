namespace FizzBuzzKata.Domain
{
    internal class RegelFallback : IchBinEineRegel
    {
        public string Text { get; private set; }

        public bool IstAnwendbar(int zahl)
        {
            Text = zahl.ToString();
            return true;
        }
    }
}