using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsWinForms
{
    public class FruitBearingPlantProfile : PlantProfile
    {
        // Example of subclass-specific field (optional)
        private string fruitType;

        // Encapsulated property
        public string FruitType
        {
            get { return fruitType; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    fruitType = value;
                else
                    fruitType = "Unknown";
            }
        }

        // Display all attributes
        public override string Display()
        {
            return base.Display() + $"\nFruit Type: {FruitType}";
        }

        // Display only a subset based on input
        public override string Display(int num)
        {
            if (num == 1)
                return $"Name: {Name}";
            else if (num == 2)
                return $"Name: {Name}\nFruit Type: {FruitType}";
            else
                return Display(); // default full
        }
    }
}
