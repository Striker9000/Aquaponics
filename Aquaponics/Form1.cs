using Aquaponics; // Importing the Aquaponics namespace for accessing related classes and methods.
using System; // Importing the System namespace for basic functionalities like DateTime and EventArgs.
using System.Collections.Generic; // Importing the namespace for using generic collections like Dictionary.
using System.Data.SQLite; // Importing the namespace for SQLite database operations.
using System.Timers; // Importing the namespace for using Timer functionality.
using System.Windows.Forms; // Importing the namespace for Windows Forms UI components.

namespace AquaponicsWinForms // Defining the namespace for the application.
{
    public partial class Form1 : Form // Declaring the Form1 class, which inherits from the Form class.
    {
        private System.Timers.Timer? monitorTimer; // Timer to periodically monitor sensor data.
        private Random rand; // Random object for generating simulated sensor values.
        private bool isMonitoring = false; // Boolean flag to track if monitoring is active.
        private Dictionary<string, PlantProfile>? plantProfiles; // Dictionary to store plant profiles by name.
        private PlantProfile? currentProfile; // The currently selected plant profile.
        private string strDbPath = "Aquaponics.db"; // Path to the SQLite database file.

        private void InitializePlantProfiles() // Method to initialize plant profiles and populate the ComboBox.
        {
            plantProfiles = PlantProfile.GetDefaultProfiles(); // Fetching default plant profiles.

            foreach (var key in plantProfiles.Keys) // Iterating through the keys (profile names) in the dictionary.
            {
                plantProfileComboBox.Items.Add(key); // Adding each profile name to the ComboBox.
            }

            plantProfileComboBox.SelectedIndex = 0; // Setting the default selected item in the ComboBox.
            currentProfile = plantProfiles["Gorilla Glue #4"]; // Setting the default current profile.
        }



        public Form1() // Constructor for the Form1 class.
        {
            InitializeComponent(); // Initializing the form components (auto-generated by the designer).
            InitializePlantProfiles(); // Calling the method to initialize plant profiles.

            rand = new Random(); // Initializing the Random object for generating random values.
            InitializeTimer(); // Calling the method to initialize the monitoring timer.
        }
        private void InitializeTimer() // Method to set up the monitoring timer.
        {
            monitorTimer = new System.Timers.Timer(2000); // Creating a timer with a 2-second interval.
            monitorTimer.Elapsed += MonitorTick; // Subscribing the MonitorTick method to the Elapsed event.
            monitorTimer.AutoReset = true; // Ensuring the timer restarts automatically after each interval.
        }

        private void MonitorTick(object? sender, ElapsedEventArgs e) // Event handler for the timer's Elapsed event.
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

            // You�ll need to map these to actual GPIO pins and possibly use ADC converters
            // like MCP3008 if your sensor outputs are analog
            */

            // Simulate sensor values
            //double temp = 15 + rand.NextDouble() * 15; // 15�30 �C

        //
        // private void MonitorTick(object? sender, ElapsedEventArgs e) // Event handler for the timer's Elapsed event.
        //{
            // Simulate sensor values for testing purposes.
            double tempC = 15 + rand.NextDouble() * 15; // Generating a random temperature in Celsius (15-30°C).
            double temp = (tempC * 9 / 5) + 32; // Converting the temperature to Fahrenheit.
            double moisture = 10 + rand.NextDouble() * 50; // Generating a random moisture percentage (10-60%).
            double waterLevel = rand.NextDouble() * 100; // Generating a random water level percentage (0-100%).
            double light = 100 + rand.NextDouble() * 900; // Generating a random light intensity (100-1000 lux).
            double ph = 6.0 + rand.NextDouble() * 2.0; // Generating a random pH value (6.0-8.0).
            double tankLevel = rand.NextDouble() * 100; // Generating a random tank fill level percentage (0-100%).

            // Creating a list of formatted sensor readings.
            List<string> lines = new List<string>
            {
                $"[Sensor] Temperature: {temp:F1} °C", // Formatting the temperature reading.
                $"[Sensor] Moisture: {moisture:F1} %", // Formatting the moisture reading.
                $"[Sensor] Water Level: {waterLevel:F1} %", // Formatting the water level reading.
                $"[Sensor] Light: {light:F0} lux", // Formatting the light intensity reading.
                $"[Sensor] pH: {ph:F2}", // Formatting the pH reading.
                $"[Sensor] Tank Fill Level: {tankLevel:F1} %" // Formatting the tank fill level reading.
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

            if (tankLevel < 25) lines.Add("[Warning] Tank low � refill needed!");
            */
            PlantProfile plant = currentProfile!; // Accessing the current plant profile (non-nullable).

            // Adding control actions based on sensor readings and plant profile thresholds.
            if (light < plant.LightMin) lines.Add("[Action] Lights ON"); // Turn on lights if light is below minimum.
            else if (light > plant.LightMax) lines.Add("[Action] Lights OFF"); // Turn off lights if light is above maximum.

            if (waterLevel < plant.WaterLevelMin) lines.Add("[Action] Pump ON"); // Turn on pump if water level is low.
            else if (waterLevel > plant.WaterLevelMax) lines.Add("[Action] Pump OFF"); // Turn off pump if water level is high.

            if (temp < plant.TempMinF) lines.Add("[Action] Heater ON / Vents Closed"); // Turn on heater if temperature is low.
            else if (temp > plant.TempMaxF) lines.Add("[Action] Fan ON / Cooling"); // Turn on fan if temperature is high.

            if (moisture < plant.MoistureMin) lines.Add("[Action] Watering roots"); // Start irrigation if moisture is low.
            else if (moisture > plant.MoistureMax) lines.Add("[Action] Stop irrigation"); // Stop irrigation if moisture is high.

            if (ph < plant.PhMin) lines.Add("[Action] Dispensing pH UP"); // Adjust pH up if it is below minimum.
            else if (ph > plant.PhMax) lines.Add("[Action] Dispensing pH DOWN"); // Adjust pH down if it is above maximum.
            else lines.Add("[Action] pH Balanced"); // Indicate that pH is balanced.

            if (tankLevel < 25) lines.Add("[Warning] Tank low – refill needed!"); // Warn if the tank level is critically low.

            // Updating the UI with the sensor readings and actions in a thread-safe manner.
            string timestamp = DateTime.Now.ToString("T"); // Getting the current time as a string.
            string output = $"[{timestamp}] System Update:\r\n" + string.Join("\r\n", lines); // Formatting the output.

            BeginInvoke((Action)(() => // Invoking the UI update on the main thread.
            {
                sensorStatusTextBox.Text = output; // Displaying the output in the sensor status TextBox.
                sensorStatusTextBox.SelectionStart = sensorStatusTextBox.Text.Length; // Moving the cursor to the end.
                sensorStatusTextBox.ScrollToCaret(); // Scrolling to the latest entry.
            }));
        }

        private void plantProfileComboBox_SelectedIndexChanged(object sender, EventArgs e) // Event handler for ComboBox selection change.
        {
            string selected = plantProfileComboBox.SelectedItem.ToString(); // Getting the selected profile name.
            if (plantProfiles.ContainsKey(selected)) // Checking if the selected profile exists in the dictionary.
            {
                currentProfile = plantProfiles[selected]; // Setting the current profile to the selected one.
                statusLabel.Text = $"Status: {currentProfile.Name} profile active"; // Updating the status label.
            }
        }

        private void startButton_Click(object sender, EventArgs e) // Event handler for the Start button click.
        {
            if (!isMonitoring) // Checking if monitoring is not already active.
            {
                isMonitoring = true; // Setting the monitoring flag to true.
                monitorTimer.Start(); // Starting the monitoring timer.
                statusLabel.Text = "Status: Monitoring started"; // Updating the status label.
            }
        }

        private void stopButton_Click(object sender, EventArgs e) // Event handler for the Stop button click.
        {
            if (isMonitoring) // Checking if monitoring is currently active.
            {
                isMonitoring = false; // Setting the monitoring flag to false.
                monitorTimer.Stop(); // Stopping the monitoring timer.
                statusLabel.Text = "Status: Monitoring stopped"; // Updating the status label.
            }
        }

        private void clearLogButton_Click(object sender, EventArgs e) // Event handler for the Clear Log button click.
        {
            sensorStatusTextBox.Clear(); // Clearing the text in the sensor status TextBox.
        }


        private void Form1_Load(object sender, EventArgs e) // Event handler for the form's Load event.
        {
            /*plantTypeComboBox.Items.Add("PlantProfile");
            plantTypeComboBox.Items.Add("LeafyGreenProfile");
            plantTypeComboBox.Items.Add("FruitBearingPlantProfile");*/
            plantTypeComboBox.SelectedIndex = 0; // Setting the default selection in the plant type ComboBox.
        }

        private void sensorStatusTextBox_TextChanged(object sender, EventArgs e) // Event handler for TextBox text change.
        {
            // No implementation needed for now.
        }

        private void label1_Click(object sender, EventArgs e) // Event handler for label click.
        {
            // No implementation needed for now.
        }

        private void textBox9_TextChanged(object sender, EventArgs e) // Event handler for TextBox text change.
        {
            // No implementation needed for now.
        }

   
        private void addProfileButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                // Create a new PlantProfile using the user's input
                PlantProfile newPlant = new PlantProfile
                {
                    Name = nameTextBox.Text,
                    Type = plantTypeComboBox.SelectedItem.ToString(),
                    GrowthRate = growthRateTextBox.Text,

                   LightRequirements = lightRequirementsTextBox.Text,
                    WaterRequirements = waterRequirementsTextBox.Text,
                    // Assuming these are the correct properties
                    // for the PlantProfile class
                    // You may need to adjust these based on your actual class definition

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
                    leafy.GrowthRate = growthRateTextBox.Text; // Example default or you can ask user
                    leafy.LightRequirements = LighRequirementsTextBox.Text; // Example default or you can ask user

                    leafy.WaterRequirements = waterRequirementsTextBox.Text; // Example default or you can ask user

                    leafy.Type = typeTextBox.Text; // Example default or you can ask user


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
                    //leafy.HarvestDays = 30; // Example default or you can ask user
                    newPlant = leafy;
                }
                else if (selectedType == "FruitBearingPlantProfile")
                {
                    FruitBearingPlantProfile fruit = new FruitBearingPlantProfile();
                    fruit.Name = nameTextBox.Text;
                    fruit.GrowthRate = growthRateTextBox.Text;

                    fruit.LightRequirements = LighRequirementsTextBox.Text; // Example default or you can ask user
                    fruit.WaterRequirements = waterRequirementsTextBox.Text; // Example default or you can ask user
                    fruit.Type = typeTextBox.Text; // Example default or you can ask user
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
                    //fruit.FruitType = "Tomato"; // Example default or you can ask user
                    newPlant = fruit;
                }
                else
                {
                    PlantProfile plant = new PlantProfile();
                    plant.Name = nameTextBox.Text;
                    plant.GrowthRate = growthRateTextBox.Text; // Example default or you can ask user
                    plant.LightRequirements = LighRequirementsTextBox.Text; // Example default or you can ask user
                    plant.WaterRequirements = waterRequirementsTextBox.Text; // Example default or you can ask user
                    plant.Type = typeTextBox.Text; // Example default or you can ask user

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
                // Optionally, you can also add the new plant to the SQLite database
                // using SQLiteCommand to insert the new plant into the database
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=Aquaponics.db;Version=3;"))
                {
                    connection.Open();

                    //string createTableQuery = "CREATE TABLE IF NOT EXISTS PlantProfiles (Id INTEGER PRIMARY KEY, Name TEXT, Type TEXT, GrowthRate TEXT, LightRequirements TEXT, WaterRequirements TEXT)";

                    string createTableQuery = "CREATE TABLE IF NOT EXISTS PlantProfiles (Id INTEGER PRIMARY KEY, Name TEXT, Type TEXT, GrowthRate TEXT, LightRequirements TEXT, WaterRequirements TEXT, TempMinF REAL, TempMaxF REAL, MoistureMin REAL, MoistureMax REAL, PhMin REAL, PhMax REAL, LightMin REAL, LightMax REAL, WaterLevelMin REAL, WaterLevelMax REAL)";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    //string insertQuery = "INSERT INTO PlantProfiles (Name, Type, GrowthRate, LightRequirements, WaterRequirements) VALUES (@Name, @Type, @GrowthRate, @LightRequirements, @WaterRequirements)";
                    string insertQuery = "INSERT INTO PlantProfiles (Name, Type, GrowthRate, LightRequirements, WaterRequirements, TempMinF, TempMaxF, MoistureMin, MoistureMax, PhMin, PhMax, LightMin, LightMax, WaterLevelMin, WaterLevelMax) VALUES (@Name, @Type, @GrowthRate, @LightRequirements, @WaterRequirements, @TempMinF, @TempMaxF, @MoistureMin, @MoistureMax, @PhMin, @PhMax, @LightMin, @LightMax, @WaterLevelMin, @WaterLevelMax)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", newPlant.Name);
                        command.Parameters.AddWithValue("@Type", newPlant.Type);
                        command.Parameters.AddWithValue("@GrowthRate", newPlant.GrowthRate);
                        command.Parameters.AddWithValue("@LightRequirements", newPlant.LightRequirements);
                        command.Parameters.AddWithValue("@WaterRequirements", newPlant.WaterRequirements);
                        command.Parameters.AddWithValue("@TempMinF", newPlant.TempMinF);
                        command.Parameters.AddWithValue("@TempMaxF", newPlant.TempMaxF);
                        command.Parameters.AddWithValue("@MoistureMin", newPlant.MoistureMin);
                        command.Parameters.AddWithValue("@MoistureMax", newPlant.MoistureMax);
                        command.Parameters.AddWithValue("@PhMin", newPlant.PhMin);
                        command.Parameters.AddWithValue("@PhMax", newPlant.PhMax);
                        command.Parameters.AddWithValue("@LightMin", newPlant.LightMin);
                        command.Parameters.AddWithValue("@LightMax", newPlant.LightMax);
                        command.Parameters.AddWithValue("@WaterLevelMin", newPlant.WaterLevelMin);
                        command.Parameters.AddWithValue("@WaterLevelMax", newPlant.WaterLevelMax);

                        // Execute the insert
                        command.ExecuteNonQuery();
                    }
                }
                // Add to ComboBox
                plantProfileComboBox.Items.Add(newPlant.Name);
                // Show success message
                MessageBox.Show($"Plant Profile '{newPlant.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear input fields
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
                // Clear input fields




                // Update ComboBox or List
                plantProfileComboBox.Items.Add(newPlant.Name);

                MessageBox.Show($"{selectedType} '{newPlant.Name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Event handler for ComboBox selection change.
        {
            // No implementation needed for now.
        }

        private void MonitorPage_Click(object sender, EventArgs e) // Event handler for Monitor Page click.
        {
            // No implementation needed for now.
        }

        private void AddPlantPage_Click(object sender, EventArgs e) // Event handler for Add Plant Page click.
        {
            // No implementation needed for now.
        }

        private void plantProfilesFormButton_Click(object sender, EventArgs e) // Event handler for Plant Profiles Form button click.
        {
            PlantProfilesForm ppff = new PlantProfilesForm(); // Creating a new instance of the PlantProfilesForm.
            ppff.Show(); // Displaying the PlantProfilesForm.
        }

        private void label1_Click_1(object sender, EventArgs e) // Event handler for label click.
        {
            // No implementation needed for now.
        }

        private void PlantName_Click(object sender, EventArgs e) // Event handler for Plant Name label click.
        {
            // No implementation needed for now.
        }

        private void button1_Click(object sender, EventArgs e) // Event handler for Button1 click.
        {
            FruitBearingPlantForm fbpf = new FruitBearingPlantForm(); // Creating a new instance of the FruitBearingPlantForm.
            fbpf.Show(); // Displaying the FruitBearingPlantForm.
        }

        private void button2_Click(object sender, EventArgs e) // Event handler for Button2 click.
        {
            FruitBearingPlantForm fbpf = new FruitBearingPlantForm(); // Creating a new instance of the FruitBearingPlantForm.
            fbpf.Show(); // Displaying the FruitBearingPlantForm.
        }
    }
}
