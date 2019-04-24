using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL._3._23
{
    public interface IСonstructionEquipment
    {
        bool Movable { get; }
        string GetTypeInformation();
        double GetCosts(double FuelCost, int liters);
    }
}
