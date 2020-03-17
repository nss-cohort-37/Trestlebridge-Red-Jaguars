using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChoosePlowingField
    {
        public static void CollectInput(Farm farm, IPlowing plant)
        {
            Utils.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                if (farm.PlowedFields[i].PlantCount() < farm.PlowedFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Plowing Field");
                    Console.WriteLine($"\t This field has {farm.PlowedFields[i].PlantCount()} plants currently!\n");
                    var SunflowerCount = 0;
                    SunflowerCount = farm.PlowedFields[i].PlowedPlantList()
                      .Where(plantType => plantType.Type == "Sunflower")
                      .Count();
                    Console.WriteLine($"\t \t There are {SunflowerCount} rows of Sunflowers!");
                    var SesameCount = 0;
                    SesameCount = farm.PlowedFields[i].PlowedPlantList()
                      .Where(plantType => plantType.Type == "Sesame")
                      .Count();
                    Console.WriteLine($"\t \t There are {SesameCount} rows of Sesame!");
                }
            }



            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.PlowedFields[choice - 1].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IPlowing>(plant, choice);

        }
    }
}