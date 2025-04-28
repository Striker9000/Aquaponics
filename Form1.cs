using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Timers;

namespace AquaponicsWinForms
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer? monitorTimer;
        private Random rand;
        private bool isMonitoring = false;
        private Dictionary<string, PlantProfile>? plantProfiles;
        private PlantProfile? currentProfile;

        private void InitializePlantProfiles()
        {
            plantProfiles = PlantProfile.GetDefaultProfiles();

            foreach (var key in plantProfiles.Keys)
            {
                plantProfileComboBox.Items.Add(key);
            }

            plantProfileComboBox.SelectedIndex = 0;
            currentProfile = plantProfiles["Gorilla Glue #4"];
        }



        public Form1()
        {
            InitializeComponent();
            InitializePlantProfiles();

            rand = new Random();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            monitorTimer = new System.Timers.Timer(5000); // 5 seconds
            monitorTimer.Elapsed += MonitorTick;
            monitorTimer.AutoReset = true;
        }

        private void MonitorTick(object? sender, ElapsedEventArgs e)
        {
            // ===== REAL SENSOR READINGS FOR RASPBERRY PI (placeholder) =====
            // Uncomment and implement when migrating to real sensors on Pi

            /*
            using System.Device.Gpio;
            using Iot.Device.Adc;
            using Iot.Device.Bmxx80; // Example: BMP280 temp sensor
            using Iot.Device.Common;
            using Iot.Device.Pwm;

            double temp = GetTemperatureFromPi();           // Replace with actual GPIO read
            double moisture = GetMoistureFromPi();          // Via ADC (e.g., MCP3008)
            double waterLevel = GetWaterLevelFromPi();      // Via ultrasonic or float sensor
            double light = GetLightSensorFromPi();          // e.g., TSL2561 or photoresistor
            double ph = GetPhValueFromPi();                 // Via analog pH sensor board
            double tankLevel = GetTankLevelFromPi();        // e.g., float switch or capacitive sensor

            // You’ll need to map these to actual GPIO pins and possibly use ADC converters
            // like MCP3008 if your sensor outputs are analog
            */

            // Simulate sensor values
            //double temp = 15 + rand.NextDouble() * 15; // 15–30 °C
            double tempC = 15 + rand.NextDouble() * 15;
            double temp = (tempC * 9 / 5) + 32; // Fahrenheit
            double moisture = 10 + rand.NextDouble() * 50; // 10–60%
            double waterLevel = rand.NextDouble() * 100; // 0–100%
            double light = 100 + rand.NextDouble() * 900; // 100–1000 lux
            double ph = 6.0 + rand.NextDouble() * 2.0; // 6.0–8.0
            double tankLevel = rand.NextDouble() * 100;

            // Format output
            List<string> lines = new List<string>
            {
                $"[Sensor] Temperature: {temp:F1} °C",
                $"[Sensor] Moisture: {moisture:F1} %",
                $"[Sensor] Water Level: {waterLevel:F1} %",
                $"[Sensor] Light: {light:F0} lux",
                $"[Sensor] pH: {ph:F2}",
                $"[Sensor] Tank Fill Level: {tankLevel:F1} %"
            };


            /*
            // Control Logic
            if (light < 300) lines.Add("[Action] Lights ON");
            else lines.Add("[Action] Lights OFF");

            if (waterLevel < 40) lines.Add("[Action] Pump ON");
            else if (waterLevel > 80) lines.Add("[Action] Pump OFF");

            if (temp > 28) lines.Add("[Action] Fan ON");
            else if (temp < 22) lines.Add("[Action] Fan OFF");

            if (ph < 6.5) lines.Add("[Action] Dispensing pH UP");
            else if (ph > 7.5) lines.Add("[Action] Dispensing pH DOWN");
            else lines.Add("[Action] pH Balanced");

            if (tankLevel < 25) lines.Add("[Warning] Tank low — refill needed!");
            */
            PlantProfile plant = currentProfile!;

            if (light < plant.LightMin) lines.Add("[Action] Lights ON");
            else if (light > plant.LightMax) lines.Add("[Action] Lights OFF");

            if (waterLevel < plant.WaterLevelMin) lines.Add("[Action] Pump ON");
            else if (waterLevel > plant.WaterLevelMax) lines.Add("[Action] Pump OFF");

            if (temp < plant.TempMinF) lines.Add("[Action] Heater ON / Vents Closed");
            else if (temp > plant.TempMaxF) lines.Add("[Action] Fan ON / Cooling");

            if (moisture < plant.MoistureMin) lines.Add("[Action] Watering roots");
            else if (moisture > plant.MoistureMax) lines.Add("[Action] Stop irrigation");

            if (ph < plant.PhMin) lines.Add("[Action] Dispensing pH UP");
            else if (ph > plant.PhMax) lines.Add("[Action] Dispensing pH DOWN");
            else lines.Add("[Action] pH Balanced");

            if (tankLevel < 25) lines.Add("[Warning] Tank low — refill needed!");



            // Update UI thread-safe
            string timestamp = DateTime.Now.ToString("T");
            string output = $"[{timestamp}] System Update:\r\n" + string.Join("\r\n", lines);

            BeginInvoke((Action)(() =>
            {
                sensorStatusTextBox.Text = output;
                sensorStatusTextBox.SelectionStart = sensorStatusTextBox.Text.Length;
                sensorStatusTextBox.ScrollToCaret();
            }));
        }

        private void plantProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = plantProfileComboBox.SelectedItem.ToString();
            if (plantProfiles.ContainsKey(selected))
            {
                currentProfile = plantProfiles[selected];
                statusLabel.Text = $"Status: {currentProfile.Name} profile active";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isMonitoring)
            {
                isMonitoring = true;
                monitorTimer.Start();
                statusLabel.Text = "Status: Monitoring started";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (isMonitoring)
            {
                isMonitoring = false;
                monitorTimer.Stop();
                statusLabel.Text = "Status: Monitoring stopped";
            }
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            sensorStatusTextBox.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*plantTypeComboBox.Items.Add("PlantProfile");
            plantTypeComboBox.Items.Add("LeafyGreenProfile");
            plantTypeComboBox.Items.Add("FruitBearingPlantProfile");*/
            plantTypeComboBox.SelectedIndex = 0; // Default selection
        }

        private void sensorStatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProfileButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                // Create a new PlantProfile using the user's input
                PlantProfile newPlant = new PlantProfile
                {
                    Name = nameTextBox.Text,
                    TempMinF = double.Parse(tempMinTextBox.Text),
                    TempMaxF = double.Parse(tempMaxTextBox.Text),
                    MoistureMin = double.Parse(moistureMinTextBox.Text),
                    MoistureMax = double.Parse(moistureMaxTextBox.Text),
                    PhMin = double.Parse(phMinTextBox.Text),
                    PhMax = double.Parse(phMaxTextBox.Text),
                    LightMin = double.Parse(lightMinTextBox.Text),
                    LightMax = double.Parse(lightMaxTextBox.Text),
                    WaterLevelMin = double.Parse(waterLevelMinTextBox.Text),
                    WaterLevelMax = double.Parse(waterLevelMaxTextBox.Text)
                };

                // Add the new plant to the dictionary
                plantProfiles.Add(newPlant.Name, newPlant);

                // Update the plant selection ComboBox
                plantProfileComboBox.Items.Add(newPlant.Name);

                // Show success message
                MessageBox.Show($"Plant Profile '{newPlant.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional: Clear the textboxes after adding
                nameTextBox.Clear();
                tempMinTextBox.Clear();
                tempMaxTextBox.Clear();
                moistureMinTextBox.Clear();
                moistureMaxTextBox.Clear();
                phMinTextBox.Clear();
                phMaxTextBox.Clear();
                lightMinTextBox.Clear();
                lightMaxTextBox.Clear();
                waterLevelMinTextBox.Clear();
                waterLevelMaxTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding plant profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            try
            {
                string selectedType = plantTypeComboBox.SelectedItem.ToString();
                PlantProfile newPlant;

                if (selectedType == "LeafyGreenProfile")
                {
                    LeafyGreenProfile leafy = new LeafyGreenProfile();
                    leafy.Name = nameTextBox.Text;
                    leafy.TempMinF = double.Parse(tempMinTextBox.Text);
                    leafy.TempMaxF = double.Parse(tempMaxTextBox.Text);
                    leafy.MoistureMin = double.Parse(moistureMinTextBox.Text);
                    leafy.MoistureMax = double.Parse(moistureMaxTextBox.Text);
                    leafy.PhMin = double.Parse(phMinTextBox.Text);
                    leafy.PhMax = double.Parse(phMaxTextBox.Text);
                    leafy.LightMin = double.Parse(lightMinTextBox.Text);
                    leafy.LightMax = double.Parse(lightMaxTextBox.Text);
                    leafy.WaterLevelMin = double.Parse(waterLevelMinTextBox.Text);
                    leafy.WaterLevelMax = double.Parse(waterLevelMaxTextBox.Text);
                    leafy.HarvestDays = 30; // Example default or you can ask user
                    newPlant = leafy;
                }
                else if (selectedType == "FruitBearingPlantProfile")
                {
                    FruitBearingPlantProfile fruit = new FruitBearingPlantProfile();
                    fruit.Name = nameTextBox.Text;
                    fruit.TempMinF = double.Parse(tempMinTextBox.Text);
                    fruit.TempMaxF = double.Parse(tempMaxTextBox.Text);
                    fruit.MoistureMin = double.Parse(moistureMinTextBox.Text);
                    fruit.MoistureMax = double.Parse(moistureMaxTextBox.Text);
                    fruit.PhMin = double.Parse(phMinTextBox.Text);
                    fruit.PhMax = double.Parse(phMaxTextBox.Text);
                    fruit.LightMin = double.Parse(lightMinTextBox.Text);
                    fruit.LightMax = double.Parse(lightMaxTextBox.Text);
                    fruit.WaterLevelMin = double.Parse(waterLevelMinTextBox.Text);
                    fruit.WaterLevelMax = double.Parse(waterLevelMaxTextBox.Text);
                    fruit.FruitType = "Tomato"; // Example default or you can ask user
                    newPlant = fruit;
                }
                else
                {
                    PlantProfile plant = new PlantProfile();
                    plant.Name = nameTextBox.Text;
                    plant.TempMinF = double.Parse(tempMinTextBox.Text);
                    plant.TempMaxF = double.Parse(tempMaxTextBox.Text);
                    plant.MoistureMin = double.Parse(moistureMinTextBox.Text);
                    plant.MoistureMax = double.Parse(moistureMaxTextBox.Text);
                    plant.PhMin = double.Parse(phMinTextBox.Text);
                    plant.PhMax = double.Parse(phMaxTextBox.Text);
                    plant.LightMin = double.Parse(lightMinTextBox.Text);
                    plant.LightMax = double.Parse(lightMaxTextBox.Text);
                    plant.WaterLevelMin = double.Parse(waterLevelMinTextBox.Text);
                    plant.WaterLevelMax = double.Parse(waterLevelMaxTextBox.Text);
                    newPlant = plant;
                }

                // Add to dictionary
                plantProfiles.Add(newPlant.Name, newPlant);

                // Update ComboBox or List
                plantProfileComboBox.Items.Add(newPlant.Name);

                MessageBox.Show($"{selectedType} '{newPlant.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional clear
                //ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
