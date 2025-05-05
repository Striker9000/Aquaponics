using System.Collections.Generic;

namespace AquaponicsWinForms
{
    public class PlantProfile
    {
        // Property to store the name of the plant
        public string Name { get; set; } = string.Empty;

        // Property to store the type of the plant
        public string Type { get; set; } = string.Empty;

        // Property to store the growth rate of the plant
        public string GrowthRate { get; set; } = string.Empty;

        // Property to store the light requirements of the plant
        public string LightRequirements { get; set; } = string.Empty;

        // Property to store the water requirements of the plant
        public string WaterRequirements { get; set; } = string.Empty;

        // Property to store the maximum temperature in Fahrenheit
        public double TempMaxF { get; set; }

        // Property to store the maximum moisture level
        public double MoistureMax { get; set; }

        // Property to store the maximum pH level
        public double PhMax { get; set; }

        // Property to store the minimum light level
        public double LightMin { get; set; }

        // Property to store the maximum light level
        public double LightMax { get; set; }

        // Property to store the minimum water level
        public double WaterLevelMin { get; set; }

        // Property to store the maximum water level
        public double WaterLevelMax { get; set; }

        // Private field to store the minimum temperature in Fahrenheit
        private double tempMinF;

        // Encapsulated property to get or set the minimum temperature in Fahrenheit
        public double TempMinF
        {
            get { return tempMinF; } // Getter for TempMinF
            set
            {
                // Ensure the value is not negative
                if (value < 0) tempMinF = 0;
                else tempMinF = value;
            }
        }

        // Private field to store the minimum moisture level
        private double moistureMin;

        // Encapsulated property to get or set the minimum moisture level
        public double MoistureMin
        {
            get { return moistureMin; } // Getter for MoistureMin
            set
            {
                // Ensure the value is between 0 and 100
                if (value < 0) moistureMin = 0;
                else if (value > 100) moistureMin = 100;
                else moistureMin = value;
            }
        }

        // Private field to store the minimum pH level
        private double phMin;

        // Encapsulated property to get or set the minimum pH level
        public double PhMin
        {
            get { return phMin; } // Getter for PhMin
            set
            {
                // Ensure the value is between 0 and 14
                if (value < 0) phMin = 0;
                else if (value > 14) phMin = 14;
                else phMin = value;
            }
        }

        // Static method to get default plant profiles
        public static Dictionary<string, PlantProfile> GetDefaultProfiles()
        {
            // Return a dictionary of default plant profiles
            return new Dictionary<string, PlantProfile>
            {
                // Default profile for "Gorilla Glue #4"
                ["Gorilla Glue #4"] = new PlantProfile
                {
                    Name = "Gorilla Glue #4", // Name of the plant
                    Type = "Cannabis", // Type of the plant
                    GrowthRate = "Fast", // Growth rate of the plant
                    LightRequirements = "High", // Light requirements
                    WaterRequirements = "Moderate", // Water requirements
                    TempMinF = 75, // Minimum temperature
                    TempMaxF = 82, // Maximum temperature
                    MoistureMin = 40, // Minimum moisture
                    MoistureMax = 60, // Maximum moisture
                    PhMin = 5.8, // Minimum pH
                    PhMax = 6.5, // Maximum pH
                    LightMin = 600, // Minimum light
                    LightMax = 900, // Maximum light
                    WaterLevelMin = 50, // Minimum water level
                    WaterLevelMax = 80 // Maximum water level
                },

                // Default profile for "Strawberries"
                ["Strawberries"] = new PlantProfile
                {
                    Name = "Strawberries", // Name of the plant
                    Type = "Fruit", // Type of the plant
                    GrowthRate = "Moderate", // Growth rate of the plant
                    LightRequirements = "Medium", // Light requirements
                    WaterRequirements = "Moderate", // Water requirements
                    TempMinF = 60, // Minimum temperature
                    TempMaxF = 75, // Maximum temperature
                    MoistureMin = 60, // Minimum moisture
                    MoistureMax = 80, // Maximum moisture
                    PhMin = 5.5, // Minimum pH
                    PhMax = 6.5, // Maximum pH
                    LightMin = 800, // Minimum light
                    LightMax = 1200, // Maximum light
                    WaterLevelMin = 50, // Minimum water level
                    WaterLevelMax = 90 // Maximum water level
                },

                // Default profile for "Jack Herrer"
                ["Jack Herrer"] = new PlantProfile
                {
                    Name = "Jack Herrer", // Name of the plant
                    Type = "Cannabis", // Type of the plant
                    GrowthRate = "Medium", // Growth rate of the plant
                    LightRequirements = "High", // Light requirements
                    WaterRequirements = "Moderate", // Water requirements
                    TempMinF = 72, // Minimum temperature
                    TempMaxF = 80, // Maximum temperature
                    MoistureMin = 45, // Minimum moisture
                    MoistureMax = 65, // Maximum moisture
                    PhMin = 5.8, // Minimum pH
                    PhMax = 6.5, // Maximum pH
                    LightMin = 700, // Minimum light
                    LightMax = 1000, // Maximum light
                    WaterLevelMin = 60, // Minimum water level
                    WaterLevelMax = 85 // Maximum water level
                },

                // Default profile for "Durban Poison"
                ["Durban Poison"] = new PlantProfile
                {
                    Name = "Durban Poison", // Name of the plant
                    Type = "Cannabis", // Type of the plant
                    GrowthRate = "Fast", // Growth rate of the plant
                    LightRequirements = "High", // Light requirements
                    WaterRequirements = "Moderate", // Water requirements
                    TempMinF = 70, // Minimum temperature
                    TempMaxF = 85, // Maximum temperature
                    MoistureMin = 40, // Minimum moisture
                    MoistureMax = 60, // Maximum moisture
                    PhMin = 6.0, // Minimum pH
                    PhMax = 6.8, // Maximum pH
                    LightMin = 750, // Minimum light
                    LightMax = 1100, // Maximum light
                    WaterLevelMin = 55, // Minimum water level
                    WaterLevelMax = 90 // Maximum water level
                }
            };
        }

        // Method to display all attributes of the plant profile
        public virtual string Display()
        {
            // Return a formatted string with all attributes
            return $"Name: {Name}\n" +
                   $"Type: {Type}\n" +
                   $"GrowthRate: {GrowthRate}\n" +
                   $"TempMinF: {TempMinF}\n" +
                   $"TempMaxF: {TempMaxF}\n" +
                   $"MoistureMin: {MoistureMin}\n" +
                   $"MoistureMax: {MoistureMax}\n" +
                   $"PhMin: {PhMin}\n" +
                   $"PhMax: {PhMax}\n" +
                   $"LightRequirements: {LightRequirements}\n" +
                   $"LightMin: {LightMin}\n" +
                   $"LightMax: {LightMax}\n" +
                   $"WaterRequirements: {WaterRequirements}\n" +
                   $"WaterLevelMin: {WaterLevelMin}\n" +
                   $"WaterLevelMax: {WaterLevelMax}";
        }

        // Method to display a selected number of attributes
        public virtual string Display(int num)
        {
            // If only one attribute is requested, return the name
            if (num == 1)
            {
                return $"Name: {Name}";
            }
            // If two attributes are requested, return the name and minimum temperature
            else if (num == 2)
            {
                return $"Name: {Name}\nTempMinF: {TempMinF}";
            }
            // Otherwise, return all attributes
            else
            {
                return Display(); // Default: full details
            }
        }
    }
}



