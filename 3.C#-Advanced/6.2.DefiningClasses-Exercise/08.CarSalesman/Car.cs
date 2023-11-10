using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;
        public Car(string model, Engine engine, int? weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int? Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public override string ToString()
        {
            return $"{Model}:" +
               $"\n  {Engine.Model}:" +
               $"\n    Power: {Engine.Power}" +
               $"\n    Displacement: {Engine.Displacement?.ToString() ?? "n/a"}" +
               $"\n    Efficiency: {Engine.Efficiency ?? "n/a"}" +
               $"\n  Weight: {Weight?.ToString() ?? "n/a"}" +
               $"\n  Color: {Color ?? "n/a"}";
        }
    }
}
