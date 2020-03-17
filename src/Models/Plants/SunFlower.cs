using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Sunflower : IResource, ISeedProducing, ICompostProducing, INatural, IPlowing
  {
    public int SeedsProduced { get; set; } = 650;
    public double CompostProduced { get; set; } = 21.6;
    public string Type { get; } = "Sunflower";

    public double Compost()
    {
      return CompostProduced;
    }
    public double Harvest()
    {
      return SeedsProduced;
    }

    public override string ToString()
    {
      return $"Sunflower. Nice!";
    }
  }
}