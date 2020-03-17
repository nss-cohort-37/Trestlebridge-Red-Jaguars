using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class WildFlower : IResource, ICompostProducing, INatural
  {

    public string Type { get; } = "Wildflower";
    public double CompostProduced { get; set; } = 30.3;
    public double Compost()
    {
      return CompostProduced;
    }

    public override string ToString()
    {
      return $"Wildflower. Cool!";
    }
  }
}