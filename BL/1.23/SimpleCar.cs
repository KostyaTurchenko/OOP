using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class SimpleCar : IComparable
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int Price { get; set; }
        public int FuelConsumption { get; set; }
        public int Speed { get; set; }

        public bool Climate { get; protected set; }
        public bool Security { get; protected set; }

        
        


        public SimpleCar(string name, string number, int price, int fuelConsumption, int speed)
        {
            Name = name;
            Number = number;
            Price = price;
            fuelConsumption = FuelConsumption;
            Speed = speed;
            Climate = false;
            Security = false;
        }
        public int CompareTo(object obj)
        {
            SimpleCar OtherCar = obj as SimpleCar;
            if (this.FuelConsumption == OtherCar.FuelConsumption)
                return 0;
            if (this.FuelConsumption > OtherCar.FuelConsumption)
                return 1;
            else
                return -1;
        }


    }
}
