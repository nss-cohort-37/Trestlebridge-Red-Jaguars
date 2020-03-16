namespace Trestlebridge.Interfaces
{
    public interface IPlowing
    {
        double SeedsPerDay { get; set; }
        void Plowing();
    }
}