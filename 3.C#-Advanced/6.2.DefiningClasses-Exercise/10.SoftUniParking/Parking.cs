using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;
        private int count;
        public Parking(int capacity)
        {
            cars = new Dictionary<string, Car>();
            Capacity = capacity;
        }
        public int Count
        {
            get { return Cars.Count; }
            set { count = Cars.Count; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Dictionary<string, Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public string AddCar(Car car)
        {
            if (Cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count < Capacity)
            {
                cars[car.RegistrationNumber] = car;
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
            else
            {
                return "Parking is full!";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            if (Cars.ContainsKey(registrationNumber))
            {
                Cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return Cars.First(car=>car.Value.RegistrationNumber == registrationNumber).Value;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string registrationNumber in RegistrationNumbers)
            {
                if (Cars.ContainsKey(registrationNumber))
                {
                    Cars.Remove(registrationNumber);
                }
            }
        }
    }
}
