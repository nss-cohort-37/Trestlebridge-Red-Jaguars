using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
  public class Chicken : IResource, IMeatProducing, IEggProducing, IFeatherProducing, IChicken
  {

    private Guid _id = Guid.NewGuid();
    private double _meatProduced = 7;
    private double _featherProduced = .5;
    private double _eggProduced = 1.7;

    //KG

    private string _shortId
    {
      get
      {
        return this._id.ToString().Substring(this._id.ToString().Length - 6);
      }
    }

    public double GrassPerDay { get; set; } = 0.9;
    public string Type { get; } = "Chicken";

    // Methods
    public void Graze()
    {
      Console.WriteLine($"Chicken {this._shortId} just ate {this.GrassPerDay}kg of grass");
    }

    public double Butcher()
    {
      return _meatProduced;
    }

    public double GatherEggs()
    {
      return _eggProduced;
    }
    public double GatherFeathers()
    {
      return _featherProduced;
    }

    public override string ToString()
    {
      return $"Chicken {this._shortId}. Cluck!";
    }
  }
}