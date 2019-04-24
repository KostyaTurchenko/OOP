using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL._3._23
{
    public class WorkWithConstructionEquipment
    {
        List<IСonstructionEquipment> Equipments = new List<IСonstructionEquipment>();
        public void AddEquipment (IСonstructionEquipment eq)
        {
            Equipments.Add(eq);
        }
        public string GetInformation()
        {
            string outputStr = "Список техники:\n";
            foreach (var eq in Equipments)
            {
                outputStr += String.Format("{0}\n", eq.GetTypeInformation());
            }
            return outputStr;
        }
    }
}
