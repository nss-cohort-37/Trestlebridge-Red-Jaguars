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
                if (farm.NaturalFields[i].PlantCount() < farm.NaturalFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Natural Field");
                    Console.WriteLine($"\t This field has {farm.NaturalFields[i].PlantCount()} plants currently!\n");
                    var SunflowerCount = 0;
                    SunflowerCount = farm.NaturalFields[i].NaturalPlantList()
                      .Where(plantType => plantType.Type == "Sunflower")
                      .Count();
                    Console.WriteLine($"\t \t There are {SunflowerCount} rows of Sunflowers!");
                    var WildflowerCount = 0;
                    WildflowerCount = farm.NaturalFields[i].NaturalPlantList()
                      .Where(plantType => plantType.Type == "Wildflower")
                      .Count();
                    Console.WriteLine($"\t \t There are {WildflowerCount} rows of Wildflowers!");
                }
            }
            for (int i = farm.NaturalFields.Count; i < farm.PlowedFields.Count + farm.NaturalFields.Count; i++)
            {
                var plowedFieldIndex = i - farm.NaturalFields.Count;
                if (farm.PlowedFields[plowedFieldIndex].PlantCount() < farm.PlowedFields[plowedFieldIndex].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Plowed Field");
                    Console.WriteLine($"\t This field has {farm.PlowedFields[plowedFieldIndex].PlantCount()} plants currently!\n");
                    var SunflowerCount = 0;
                    SunflowerCount = farm.PlowedFields[plowedFieldIndex].PlowedPlantList()
                      .Where(plantType => plantType.Type == "Sunflower")
                      .Count();
                    Console.WriteLine($"\t \t There are {SunflowerCount} rows of Sunflowers!");
                    var SesameCount = 0;
                    SesameCount = farm.PlowedFields[plowedFieldIndex].PlowedPlantList()
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