namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        double GrassPerDay { get; set; }
        string Type { get; }
        void Graze ();
    }
}