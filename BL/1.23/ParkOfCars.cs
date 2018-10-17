using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class ParkOfCars
    {
        private List<SimpleCar> cars = new List<SimpleCar>();

        public void AddSimpleCar(string name, string number, int price, int fuelConsumption, int speed)
        {
            cars.Add(new SimpleCar(name, number, price, fuelConsumption, speed));
        }

        public void AddGoodCar(string name, string number, int price, int fuel_consumption, int speed)
        {
            cars.Add(new GoodCar(name, number, price, fuel_consumption, speed));
        }

        public void AddVIPCar(string name, string number, int price, int fuel_consumption, int speed)
        {
            cars.Add(new VIPCar(name, number, price, fuel_consumption, speed));
        }

        public string GetSortedCars()
        {
            cars.Sort();
            string output = "";
            foreach (var car in cars)
                output += car.Name + " " + car.FuelConsumption + "\n";
            return output;
        }

        public string GetSpeedCar(int min, int max)
        {
            string output = null;
            foreach (var car in cars)
            {
                if (car.Speed >= min && car.Speed <= max)
                    output += car.Name + " " + car.Speed + "\n";
            }
            if (output == null)
                output = "car not found";

            return output;
        }

        public string GetCost()
        {
            int output = 0;
            foreach (var car in cars)
            {
                output += car.Price;
            }
            return Convert.ToString(output);
        }

    }
}
