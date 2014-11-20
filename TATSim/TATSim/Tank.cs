using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATSim
{
    class Tank
    {
        private float gallons;

        public float Gallons
        {
            get { return gallons; }
            set { gallons = value; }
        }

        private float weight;

        public float Weight
        {
            get { return weight; }
        }

        private float cost;

        public float Cost
        {
            get { return cost; }
        }

        public Tank(float newGallons, float newWeight, float newCost)
        {
            gallons = newGallons;
            weight = newWeight;
            cost = newCost;
        }
    }
}
