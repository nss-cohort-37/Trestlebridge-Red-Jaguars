using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
  public class ChickenHouse : IFacility<Chicken>
  {
    private int _capacity = 15;
    private Guid _id = Guid.NewGuid();

    private List<Chicken> _animals = new List<Chicken>();



    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(Chicken animal)
    {

      try
      {
        _animals.Add(animal);
      }
      catch
      {
        Console.WriteLine("That animal does not belong in this facility!");
      }
    }

    public void AddResource(List<Chicken> animals)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append($"Chicken House {shortId} has {this._animals.Count} animals\n");
      this._animals.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }

  }
}