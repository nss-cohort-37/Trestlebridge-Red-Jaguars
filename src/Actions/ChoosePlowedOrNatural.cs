using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class ChoosePlowedOrNatural
  {

    // figure out a way for natural and plowed fields to exist in the same list 
    // or
    // run another for loop
    public static void CollectInput(Farm farm, Sunflower plant)
    {
      Utils.Clear();

      for (int i = 0; i < farm.NaturalFields.Count; i++)
      {
        Console.WriteLine($"{i + 1}. Natural Field");
        Console.WriteLine($"\t This field has {farm.NaturalFields[i].PlantCount()} plants currently!\n");
      }
      for (int i = farm.NaturalFields.Count; i < farm.PlowedFields.Count + farm.NaturalFields.Count; i++)
      {
        Console.WriteLine($"{i + 1}. Plowed Field");
        var plowedFieldIndex = i - farm.NaturalFields.Count;
        Console.WriteLine($"\t This field has {farm.PlowedFields[plowedFieldIndex].PlantCount()} plants currently!\n");

      }



      Console.WriteLine();

      // How can I output the type of plant chosen here?
      Console.WriteLine($"Place the plant where?");

      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine());

      if (choice <= farm.NaturalFields.Count)
      {
        farm.NaturalFields[choice - 1].AddResource(plant);
      }
      else if (choice > farm.NaturalFields.Count)
      {
        farm.PlowedFields[choice - 1 - farm.NaturalFields.Count].AddResource(plant);
      }

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IPlowing>(plant, choice);

    }
  }
}