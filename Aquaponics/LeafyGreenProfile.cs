using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsWinForms
{
    // Declaring the LeafyGreenProfile class, which inherits from PlantProfile  
    public class LeafyGreenProfile : PlantProfile
    {
        private int harvestDays; // Private field to store the number of days until harvest  

        public double LightMin { get; set; }

        /*public LeafyGreenProfile(string name, int days, double lightMin)
        {
            Name = name; // Corrected from PlantName to Name  
            HarvestDays = days;
            LightMin = lightMin;
        }
        */
        // Public property to encapsulate the harvestDays field  
        public int HarvestDays
        {
            get { return harvestDays; } // Getter to retrieve the value of harvestDays  
            set
            {
                if (value < 0) // Check if the value is less than 0  
                    harvestDays = 0; // If true, set harvestDays to 0  
                else
                    harvestDays = value; // Otherwise, set harvestDays to the provided value  
            }
        }

        // Method to display all attributes of the plant profile  
        public override string Display()
        {
            // Call the base class's Display method and append the harvestDays information  
            return base.Display() + $"\nHarvest Days: {HarvestDays}";
        }

        // Method to display a subset of attributes based on the input parameter  
        public override string Display(int num)
        {
            if (num == 1) // Check if the input parameter is 1  
                return $"Name: {Name}"; // Return only the Name attribute  
            else if (num == 2) // Check if the input parameter is 2  
                return $"Name: {Name}\nHarvest Days: {HarvestDays}"; // Return Name and HarvestDays attributes  
            else
                return Display(); // Default case: return the full display  
        }
    }
}