using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
  public class ChooseChickenHouse
  {
    public static void CollectInput(Farm farm, IChicken animal)
    {
      Utils.Clear();

      for (int i = 0; i < farm.ChickenHouse.Count; i++)
      {
        Console.WriteLine($"{i + 1}. Chicken House");
      }

      Console.WriteLine();

      // How can I output the type of animal chosen here?
      Console.WriteLine($"Place the animal where?");

      Console.Write("> ");
      int choice = Int32.Parse(Console.ReadLine());

      farm.ChickenHouse[choice - 1].AddResource(animal);

      /*
          Couldn't get this to work. Can you?
          Stretch goal. Only if the app is fully functional.
       */
      // farm.PurchaseResource<IGrazing>(animal, choice);

    }
  }
}