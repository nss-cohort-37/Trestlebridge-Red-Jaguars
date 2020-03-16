using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{


  public class Farm
  {

    public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

    public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

    public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();

    public List<DuckHouse> DuckHouse { get; } = new List<DuckHouse>();
    public List<ChickenHouse> ChickenHouse { get; } = new List<ChickenHouse>();
    // foreach (string value in GrazingFields) {
    //     Console.WriteLine (value);
    // }
    /*
        This method must specify the correct product interface of the
        resource being purchased.
     */
    public void PurchaseResource<T>(IResource resource, int index)
    {
      Console.WriteLine(typeof(T).ToString());

      switch (typeof(T).ToString())
      {
        case "Cow":
          GrazingFields[index].AddResource((IGrazing)resource);
          break;
        case "Duck":
          DuckHouse[index].AddResource((IDucks)resource);
          break;
        case "Chicken":
          ChickenHouse[index].AddResource((IChicken)resource);
          break;
        default:
          break;

      }
    }

    public void AddGrazingField(GrazingField field) => GrazingFields.Add(field);

    public void AddPlowedField(PlowedField field) => PlowedFields.Add(field);

    public void AddNaturalField(NaturalField field) => NaturalFields.Add(field);


    public void AddDuckHouse(DuckHouse field) => DuckHouse.Add(field);

    public void AddChickenHouse(ChickenHouse field) => ChickenHouse.Add(field);

    public override string ToString()
    {
      StringBuilder report = new StringBuilder();

      GrazingFields.ForEach(gf => report.Append(gf));
      PlowedFields.ForEach(pf => report.Append(pf));
      NaturalFields.ForEach(nf => report.Append(nf));
      DuckHouse.ForEach(dh => report.Append(dh));
      ChickenHouse.ForEach(ch => report.Append(ch));

      return report.ToString();
    }
  }



}
