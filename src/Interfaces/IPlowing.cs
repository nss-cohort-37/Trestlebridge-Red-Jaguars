namespace Trestlebridge.Interfaces
{
    public interface IPlowing
    {
        int SeedsProduced { get; set; }
        double Harvest();
        string Type { get; }
    }
}