using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
  public class ChooseGrazingField
  {
    public static void CollectInput (Farm farm, IGrazing animal)
    {
      Utils.Clear ();

      for (int i = 0; i < farm.GrazingFields.Count; i++)
      {
        if (farm.GrazingFields[i].AnimalCount () < farm.GrazingFields[i].Capacity)
        {
          Console.WriteLine ($"{i + 1}. Grazing Field");
          Console.WriteLine ($"\t This field has {farm.GrazingFields[i].AnimalCount()} animals currently!\n");
          var CowCount = 0;
          CowCount = farm.GrazingFields[i].AnimalList ()
            .Where (animalType => animalType.Type == "Cow")
            .Count ();
          Console.WriteLine ($"\t \t There are {CowCount} Cows!");
          var GoatCount = 0;
          GoatCount = farm.GrazingFields[i].AnimalList ()
            .Where (animalType => animalType.Type == "Goat")
            .Count ();
          Console.WriteLine ($"\t \t There are {GoatCount} Goats!");
          var PigCount = 0;
          PigCount = farm.GrazingFields[i].AnimalList ()
            .Where (animalType => animalType.Type == "Pig")
            .Count ();
          Console.WriteLine ($"\t \t There are {PigCount} Pigs!");
          var SheepCount = 0;
          SheepCount = farm.GrazingFields[i].AnimalList ()
            .Where (animalType => animalType.Type == "Sheep")
            .Count ();
          Console.WriteLine ($"\t \t There are {SheepCount} Sheep!");
          var OstrichCount = 0;
          OstrichCount = farm.GrazingFields[i].AnimalList ()
            .Where (animalType => animalType.Type == "Ostrich")
            .Count ();
          Console.WriteLine ($"\t \t There are {OstrichCount} Ostriches!");
        }
      }

      Console.WriteLine ();

      // How can I output the type of animal chosen here?
      Console.WriteLine ($"Place the animal where?");

      Console.Write ("> ");
      int choice = Int32.Parse (Console.ReadLine ());

      farm.GrazingFields[choice - 1].AddResource (animal);

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IGrazing>(animal, choice);

    }
  }
}