using System;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput (Farm farm)
        {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Natural Field");
            Console.WriteLine ("4. Chicken House");
            Console.WriteLine ("5. Duck House");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse (input))
            {
                case 1:
                    farm.AddGrazingField (new GrazingField ());
                    // foreach (var g in farm.GrazingFields) {
                    //     Console.WriteLine (g);
                    // }
                    Console.WriteLine ("Congratulations, new grazing field created!!!");
                    Thread.Sleep (TimeSpan.FromSeconds (2.5));
                    break;
                    // case 2:
                    //     farm.AddPlowedField (new PlowedField ());
                    //     Console.WriteLine ("Congratulations, new plowed field created!!!");
                    //     Thread.Sleep (TimeSpan.FromSeconds (2.5));
                    //     break;
                    // case 3:
                    //     farm.AddNaturalField (new NaturalField ());
                    //     Console.WriteLine ("Congratulations, new natural field created!!!");
                    //     Thread.Sleep (TimeSpan.FromSeconds (2.5));
                    //     break;
                    // case 4:
                    //     farm.AddChickenHouse (new ChickenHouse ());
                    //     Console.WriteLine ("Congratulations, new chicken house created!!!");
                    //     Thread.Sleep (TimeSpan.FromSeconds (2.5));
                    //     break;
                case 5:
                    farm.AddDuckHouse (new DuckHouse ());
                    Console.WriteLine ("Congratulations, new duck house created!!!");
                    Thread.Sleep (TimeSpan.FromSeconds (2.5));
                    break;
                default:
                    break;
            }
        }
    }
}