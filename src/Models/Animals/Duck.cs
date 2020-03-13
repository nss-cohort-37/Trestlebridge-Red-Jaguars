using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IEggProducing , IFeatherProducing, IGrazing{

        private Guid _id = Guid.NewGuid();
        private double _eggProduced = 6;
        private double _featherProduced = .75;


        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double GatherEggs () {
            return _eggProduced;
        }
        public double GatherFeathers () {
            return _featherProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}