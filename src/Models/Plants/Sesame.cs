using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Sesame : IResource, ISeedProducing, IPlowing
  {
    public int SeedsProduced { get; set; } = 520;
    public string Type { get; } = "Sesame";

    public double Harvest()
    {
      return SeedsProduced;
    }

    public override string ToString()
    {
      return $"Sesame. Yum!";
    }
  }
}