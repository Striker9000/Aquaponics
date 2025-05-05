using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsWinForms
{
    // Declaring a class that inherits from PlantProfile
    public class FruitBearingPlantProfile : PlantProfile
    {
        // Private field to store the type of fruit
        private string fruitType;

        // Public property to encapsulate the fruitType field
        public string FruitType
        {
            get { return fruitType; } // Getter to return the value of fruitType
            set
            {
                // If the value is not null or empty, assign it to fruitType
                if (!string.IsNullOrEmpty(value))
                    fruitType = value;
                else
                    fruitType = "Unknown"; // Otherwise, assign "Unknown" as the default value
            }
        }

        // Method to display all attributes of the plant profile
        public override string Display()
        {
            // Call the base class's Display method and append the fruit type
            return base.Display() + $"\nFruit Type: {FruitType}";
        }

        // Method to display a subset of attributes based on the input parameter
        public override string Display(int num)
        {
            // If the input is 1, display only the name
            if (num == 1)
                return $"Name: {Name}";
            // If the input is 2, display the name and fruit type
            else if (num == 2)
                return $"Name: {Name}\nFruit Type: {FruitType}";
            // For any other input, call the default Display method
            else
                return Display();
        }
    }
}
