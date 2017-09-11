namespace FizzBuzzKata.Domain
{
    internal interface IchBinEineRegel
    {
        string Text { get; }

        bool IstAnwendbar(int zahl);
    }
}