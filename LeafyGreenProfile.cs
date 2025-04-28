using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsWinForms
{
    public class LeafyGreenProfile : PlantProfile
    {
        // Example of subclass-specific field (optional)
        private int harvestDays;

        // Encapsulated property
        public int HarvestDays
        {
            get { return harvestDays; }
            set
            {
                if (value < 0) harvestDays = 0;
                else harvestDays = value;
            }
        }

        // Display all attributes
        public override string Display()
        {
            return base.Display() + $"\nHarvest Days: {HarvestDays}";
        }

        // Display only a subset based on input
        public override string Display(int num)
        {
            if (num == 1)
                return $"Name: {Name}";
            else if (num == 2)
                return $"Name: {Name}\nHarvest Days: {HarvestDays}";
            else
                return Display(); // default full
        }
    }
}