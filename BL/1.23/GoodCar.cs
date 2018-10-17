using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    class GoodCar : SimpleCar
    {
        public GoodCar(string name, string number, int price, int fuelConsumption, int speed) 
            : base (name, number, price, fuelConsumption, speed)
        {
            Climate = true;   
        }

        
        
    }
}
