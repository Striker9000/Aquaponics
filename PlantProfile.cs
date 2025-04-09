using System.Collections.Generic;

namespace AquaponicsWinForms
{
    public class PlantProfile
    {
        public string Name { get; set; } = string.Empty;
        public double TempMinF { get; set; }
        public double TempMaxF { get; set; }
        public double MoistureMin { get; set; }
        public double MoistureMax { get; set; }
        public double PhMin { get; set; }
        public double PhMax { get; set; }
        public double LightMin { get; set; }
        public double LightMax { get; set; }
        public double WaterLevelMin { get; set; }
        public double WaterLevelMax { get; set; }

        public static Dictionary<string, PlantProfile> GetDefaultProfiles()
        {
            return new Dictionary<string, PlantProfile>
            {
                ["Gorilla Glue #4"] = new PlantProfile
                {
                    Name = "Gorilla Glue #4",
                    TempMinF = 75,
                    TempMaxF = 82,
                    MoistureMin = 40,
                    MoistureMax = 60,
                    PhMin = 5.8,
                    PhMax = 6.5,
                    LightMin = 600,
                    LightMax = 900,
                    WaterLevelMin = 50,
                    WaterLevelMax = 80
                },

                ["Strawberries"] = new PlantProfile
                {
                    Name = "Strawberries",
                    TempMinF = 60,
                    TempMaxF = 75,
                    MoistureMin = 60,
                    MoistureMax = 80,
                    PhMin = 5.5,
                    PhMax = 6.5,
                    LightMin = 800,
                    LightMax = 1200,
                    WaterLevelMin = 50,
                    WaterLevelMax = 90
                },

                ["Jack Herrer"] = new PlantProfile
                {
                    Name = "Jack Herrer",
                    TempMinF = 72,
                    TempMaxF = 80,
                    MoistureMin = 45,
                    MoistureMax = 65,
                    PhMin = 5.8,
                    PhMax = 6.5,
                    LightMin = 700,
                    LightMax = 1000,
                    WaterLevelMin = 60,
                    WaterLevelMax = 85
                },

                ["Durban Poison"] = new PlantProfile
                {
                    Name = "Durban Poison",
                    TempMinF = 70,
                    TempMaxF = 85,
                    MoistureMin = 40,
                    MoistureMax = 60,
                    PhMin = 6.0,
                    PhMax = 6.8,
                    LightMin = 750,
                    LightMax = 1100,
                    WaterLevelMin = 55,
                    WaterLevelMax = 90
                }
            };
        }
    }
}
