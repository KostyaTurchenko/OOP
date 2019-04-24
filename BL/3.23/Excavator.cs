using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL._3._23
{
    public class Excavator : HeavyMachine
    {
        public string Name { get; set; }
        public int Year { get; }
        public override int Cost { get; set; }
        public override double FuelConsumption { get; set; }
        public double Capacity { get; set; }
        public int Power { get; set; }
        public Excavator(string name, int year, int cost, double fuel, double capacity, int power)
        {
            Name = name;
            Year = year;
            Cost = cost;
            FuelConsumption = fuel;
            Capacity = capacity;
            Power = power;
        }
        public override string GetEfficiency()
        {
            return Convert.ToString(Capacity * Power);
        }
        public string ShowBaseInformationAboutExcavator()
        {
            return String.Format("{0} Year-{1}", Name, Year);
        }
        public string GetHowOldIs()
        {
            DateTime moment = new DateTime();
            int year = moment.Year;
            return Convert.ToString(year - Year);
        }
    }
}
