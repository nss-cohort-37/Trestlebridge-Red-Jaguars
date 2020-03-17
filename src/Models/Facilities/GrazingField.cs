using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
  public class GrazingField : IFacility<IGrazing>
  {
    private int _capacity = 20;
    private Guid _id = Guid.NewGuid ();

    private List<IGrazing> _animals = new List<IGrazing> ();
    public int AnimalCount ()
    {
      return _animals.Count;
    }

    public List<IGrazing> AnimalList ()
    {
      return _animals;
    }

    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource (IGrazing animal)
    {

      try
      {
        _animals.Add (animal);
      }
      catch
      {
        Console.WriteLine ("That animal does not belong in this facility!");
      }
    }

    public void AddResource (List<IGrazing> animals)
    {
      // TODO: implement this...
      throw new NotImplementedException ();
    }

    public override string ToString ()
    {
      StringBuilder output = new StringBuilder ();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append ($"Grazing field {shortId} has {this._animals.Count} animals\n");
      this._animals.ForEach (a => output.Append ($"   {a}\n"));

      return output.ToString ();
    }

  }
}