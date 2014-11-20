using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATSim
{
    class Motorcycle
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private float weight;

        public float Weight
        {
            get { return weight; }
        }

        private float mileage;

        public float Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        private float speed;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int oil;

        public int Oil
        {
            get { return oil; }
        }

        private int battery;

        public int Battery
        {
            get { return battery; }
        }

        private int lights;

        public int Lights
        {
            get { return lights; }
        }

        private Tire tires;

        public Tire Tires
        {
            get { return tires; }
        }

        private Tank gasTank;

        public Tank GasTank
        {
            get { return gasTank; }
        }

        private Image image;

        public Image Image
        {
            get { return image}
        }

        public Motorcycle(string newName, float newWeight, float newMileage, float newSpeed, int newOil, int newBattery, int newLights, Tire newTires, Tank newTank, Image newImage)
        {
            name = newName;
            weight = newWeight;
            mileage = newMileage;
            speed = newSpeed;
            oil = newOil;
            battery = newBattery;
            lights = newLights;
            tires = newTires;
            gasTank = newTank;
            image = newImage;
        }
    }
}
