using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;
namespace Trestlebridge.Models.Facilities
{
  public class NaturalField : IFacility<INatural>
  {
    private int _rows = 10;
    private int _plantsPerRow = 6;
    private Guid _id = Guid.NewGuid();

    private List<INatural> _plants = new List<INatural>();
    public int PlantCount()
    {
      return _plants.Count;
    }

    public double Capacity
    {
      get
      {
        return _rows;
      }
    }

    public void AddResource(INatural plant)
    {

      try
      {
        _plants.Add(plant);
      }
      catch
      {
        Console.WriteLine("That plant does not belong in this field!");
      }
    }

    public void AddResource(List<INatural> plant)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
      this._plants.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }

  }
}