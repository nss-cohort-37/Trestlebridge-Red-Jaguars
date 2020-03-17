using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
  public class PlowedField : IFacility<IPlowing>
  {
    private int _rows = 13;
    private int _plantsPerRow = 5;
    private Guid _id = Guid.NewGuid();

    private List<IPlowing> _plants = new List<IPlowing>();
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

    public void AddResource(IPlowing plant)
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

    public void AddResource(List<IPlowing> plant)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append($"Plowed field {shortId} has {this._plants.Count} plants\n");
      this._plants.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }

  }
}