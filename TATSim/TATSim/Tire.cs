using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATSim
{
    class Tire
    {
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
        }

        private float durability;

        public float Durability
        {
            get { return durability; }
        }

        private float ware;

        public float Ware
        {
            get { return ware; }
            set { ware = value; }
        }

        private float cost;

        public float Cost
        {
            get { return cost; }
        }

        private float airPressure;

        public float AirPressuer
        {
            get { return airPressure; }
            set { airPressure = value; }
        }

        public Tire(string newManufacturer, float newDurability, float newWare, float newCost, float newAirPressure)
        {
            manufacturer = newManufacturer;
            durability = newDurability;
            ware = newWare;
            cost = newCost;
            airPressure = newAirPressure;
        }
    }
}
