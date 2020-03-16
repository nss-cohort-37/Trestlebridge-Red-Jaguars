using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {

        public List<GrazingField> GrazingFields { get; } = new List<GrazingField> ();
        public List<DuckHouse> DuckHouse { get; } = new List<DuckHouse> ();
        // foreach (string value in GrazingFields) {
        //     Console.WriteLine (value);
        // }
        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine (typeof (T).ToString ());

            switch (typeof (T).ToString ())
            {
                case "Cow":
                    GrazingFields[index].AddResource ((IGrazing)resource);
                    break;
                case "Duck":
                    DuckHouse[index].AddResource ((IDucks)resource);
                    break;
                default:
                    break;

            }
        }

        public void AddGrazingField (GrazingField field) => GrazingFields.Add (field);

        public void AddDuckHouse (DuckHouse field) => DuckHouse.Add (field);

        public override string ToString ()
        {
            StringBuilder report = new StringBuilder ();

            GrazingFields.ForEach (gf => report.Append (gf));
            DuckHouse.ForEach (dh => report.Append (dh));

            return report.ToString ();
        }
    }
}