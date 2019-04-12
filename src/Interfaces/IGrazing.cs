namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        double GrassPerDay { get; set; }
        void Graze();
    }
}