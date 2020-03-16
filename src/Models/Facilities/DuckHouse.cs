using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IDucks>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid ();

        private List<IDucks> _animals = new List<IDucks> ();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource (IDucks animal)
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

        public void AddResource (List<IDucks> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException ();
        }

        public override string ToString ()
        {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append ($"Duck House {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();
        }

    }
}