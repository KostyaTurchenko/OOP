using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL._3._23
{
    public abstract class HeavyMachine : IСonstructionEquipment
    {
        public bool Movable
        {
            get { return true; }            
        }
        public abstract int Cost { get; set; }
        public abstract double FuelConsumption { get; set; }

        public string GetTypeInformation()
        {
            return String.Format("Movable - {0} Type - Heavy Machine", Movable);
        }

        public double GetCosts(double FuelCost, int liters)
        {
            return FuelCost * liters;
        }

        public abstract string GetEfficiency();

    }
}
