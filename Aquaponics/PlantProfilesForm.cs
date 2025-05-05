using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aquaponics
{

    public partial class PlantProfilesForm : Form
    {
        private string strDbPath = "Aquaponics.db";
        public PlantProfilesForm()
        {
            InitializeComponent();
        }

        private void PlantProfilesForm_Load(object sender, EventArgs e)
        {
            IntializeDatabase(); // Uncommenting to initialize the database
           
            LoadPlantProfiles();
            /*
            AddPlantProfile("Tomatoes", "Fruit", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Lettuce", "Vegetable", "Fast", "Medium", "High", "60", "70", "30", "50", "6.0", "7.0", "400", "600", "40", "70");
            AddPlantProfile("Strawberry Cough", "Cannabis", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Blue Dream", "Cannabis", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Northern Lights", "Cannabis", "Fast", "Low", "Low", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("White Widow", "Cannabis", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Sour Diesel", "Cannabis", "Fast", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Microgreens", "Leafy Green", "Fast", "High", "Moderate", "70", "75", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Lettuce", "Leafy Green", "Fast", "High", "Moderate", "70", "75", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Spinach", "Leafy Green", "Fast", "High", "Moderate", "70", "75", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Kale", "Leafy Green", "Medium", "High", "Moderate", "70", "75", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Swiss Chard", "Leafy Green", "Medium", "High", "Moderate", "70", "75", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Grapes", "Fruit", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Tomatoes", "Fruit", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Cucumbers", "Fruit", "Fast", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Bell Peppers", "Fruit", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            AddPlantProfile("Strawberries", "Fruit", "Medium", "High", "Moderate", "70", "80", "40", "60", "5.8", "6.5", "600", "900", "50", "80");
            */
        }

        /// <summary>
        /// Initializes the SQLite database, creating it if it doesn't exist,
        /// configuring the table structure, and adding default plant profiles if needed.
        /// </summary>
        private void IntializeDatabase()
        {
            // Check if the database file exists, and create it if it doesn't
            if (!File.Exists(strDbPath))
            {
                SQLiteConnection.CreateFile(strDbPath); // Creates a new SQLite database file
            }

            // Define connection string with the database path
            string connectionString = $"Data Source={strDbPath};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                // Open a connection to the database
                connection.Open();

                // SQL query to create PlantProfiles table if it doesn't already exist
                // The table includes columns for plant characteristics and growth parameters
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS PlantProfiles (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT, -- Unique identifier for each plant profile
                        Name TEXT NOT NULL,                   -- Name of the plant species
                        Type TEXT NOT NULL,                   -- Category/type of plant
                        GrowthRate TEXT NOT NULL,             -- How quickly the plant grows (Fast/Medium/Slow)
                        TempMinF TEXT NOT NULL,               -- Minimum temperature tolerance in Fahrenheit
                        TempMaxF TEXT NOT NULL,               -- Maximum temperature tolerance in Fahrenheit
                        MoistureMin TEXT NOT NULL,            -- Minimum moisture level requirement
                        MoistureMax TEXT NOT NULL,            -- Maximum moisture level tolerance
                        PhMin TEXT NOT NULL,                  -- Minimum pH level requirement
                        PhMax TEXT NOT NULL,                  -- Maximum pH level tolerance
                        LightRequirements TEXT NOT NULL,      -- General light intensity needs (Low/Medium/High)
                        LightMin TEXT NOT NULL,               -- Minimum light intensity in specific units
                        LightMax TEXT NOT NULL,               -- Maximum light intensity in specific units
                        WaterRequirements TEXT NOT NULL,      -- General water needs (Low/Moderate/High)
                        WaterLevelMin TEXT NOT NULL,          -- Minimum water level requirement
                        WaterLevelMax TEXT NOT NULL           -- Maximum water level tolerance
                    )";

                // Execute the create table SQL command
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Check if the table is empty by counting rows
                string countQuery = "SELECT COUNT(*) FROM PlantProfiles";
                using (var command = new SQLiteCommand(countQuery, connection))
                {
                    // Get the number of existing plant profiles
                    long count = Convert.ToInt64(command.ExecuteScalar());

                    // Only add default data if the table is empty (no existing records)
                    if (count == 0)
                    {
                        // Define a list of default plant profiles using tuple syntax for compact representation
                        // Each tuple contains all plant properties in the same order as the database columns
                        var plantProfiles = new List<(string Name, string Type, string GrowthRate, string LightRequirements, string WaterRequirements, string TempMinF, string TempMaxF, string MoistureMin, string MoistureMax, string PhMin, string PhMax, string LightMin, string LightMax, string WaterLevelMin, string WaterLevelMax)>
                        {
                            // Add the default plant profile "Gorilla Glue #4" with its characteristics
                            ("Gorilla Glue #4", "Cannabis", "Fast", "High", "Moderate", "75", "82", "40", "60", "5.8", "6.5", "600", "900", "50", "80"),
                            // Additional profiles can be added here by uncommenting and modifying the line below
                            // ("Plant Name", "Plant Type", "Growth Rate", "Light Req", "Water Req", "TempMin", "TempMax", "MoistMin", "MoistMax", "PhMin", "PhMax", "LightMin", "LightMax", "WaterMin", "WaterMax"),
                        };

                        // Insert each default profile into the database
                        foreach (var profile in plantProfiles)
                        {
                            // SQL query to insert a new plant profile with parameterized values for safety
                            string insertQuery = @"
                                INSERT INTO PlantProfiles (
                                    Name, Type, GrowthRate, LightRequirements, WaterRequirements, 
                                    TempMinF, TempMaxF, MoistureMin, MoistureMax, PhMin, PhMax, 
                                    LightMin, LightMax, WaterLevelMin, WaterLevelMax
                                ) VALUES (
                                    @Name, @Type, @GrowthRate, @LightRequirements, @WaterRequirements, 
                                    @TempMinF, @TempMaxF, @MoistureMin, @MoistureMax, @PhMin, @PhMax, 
                                    @LightMin, @LightMax, @WaterLevelMin, @WaterLevelMax
                                )";

                            // Create and execute the command with parameters to prevent SQL injection
                            using (var insertCmd = new SQLiteCommand(insertQuery, connection))
                            {
                                // Add each parameter with its value from the profile tuple
                                insertCmd.Parameters.AddWithValue("@Name", profile.Name);
                                insertCmd.Parameters.AddWithValue("@Type", profile.Type);
                                insertCmd.Parameters.AddWithValue("@GrowthRate", profile.GrowthRate);
                                insertCmd.Parameters.AddWithValue("@LightRequirements", profile.LightRequirements);
                                insertCmd.Parameters.AddWithValue("@WaterRequirements", profile.WaterRequirements);
                                insertCmd.Parameters.AddWithValue("@TempMinF", profile.TempMinF);
                                insertCmd.Parameters.AddWithValue("@TempMaxF", profile.TempMaxF);
                                insertCmd.Parameters.AddWithValue("@MoistureMin", profile.MoistureMin);
                                insertCmd.Parameters.AddWithValue("@MoistureMax", profile.MoistureMax);
                                insertCmd.Parameters.AddWithValue("@PhMin", profile.PhMin);
                                insertCmd.Parameters.AddWithValue("@PhMax", profile.PhMax);
                                insertCmd.Parameters.AddWithValue("@LightMin", profile.LightMin);
                                insertCmd.Parameters.AddWithValue("@LightMax", profile.LightMax);
                                insertCmd.Parameters.AddWithValue("@WaterLevelMin", profile.WaterLevelMin);
                                insertCmd.Parameters.AddWithValue("@WaterLevelMax", profile.WaterLevelMax);

                                // Execute the SQL command to insert the profile
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        // Log success message to console for debugging
                        Console.WriteLine("Default plant profiles added successfully.");
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves all plant profiles from the database and displays them in the DataGridView
        /// </summary>
        private void LoadPlantProfiles()
        {
            try
            {
                // Define connection string to the SQLite database
                string connectionString = $"Data Source={strDbPath};Version=3;";

                // Create connection with using statement to ensure proper disposal
                using var connection = new SQLiteConnection(connectionString);

                // Open the database connection
                connection.Open();

                // SQL query to select all records from the PlantProfiles table
                string selectQuery = "SELECT * FROM PlantProfiles";

                // Create a data adapter to fill a DataTable with query results
                using var adapter = new SQLiteDataAdapter(selectQuery, connection);

                // Create an empty DataTable to store the results
                DataTable dataTable = new();

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);

                // Set the DataGridView's data source to display the plant profiles
                dgvPlantProfiles.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Display an error message if loading fails for any reason
                MessageBox.Show($"Error loading plant profiles: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adds a new plant profile to the database with the specified parameters
        /// </summary>
        /// <param name="name">Name of the plant species</param>
        /// <param name="type">Category/type of plant</param>
        /// <param name="growthRate">How quickly the plant grows (Fast/Medium/Slow)</param>
        /// <param name="lightRequirements">General light needs (Low/Medium/High)</param>
        /// <param name="waterRequirements">General water needs (Low/Moderate/High)</param>
        /// <param name="tempMinF">Minimum temperature tolerance (°F)</param>
        /// <param name="tempMaxF">Maximum temperature tolerance (°F)</param>
        /// <param name="moistureMin">Minimum moisture level requirement (%)</param>
        /// <param name="moistureMax">Maximum moisture level tolerance (%)</param>
        /// <param name="phMin">Minimum pH level requirement</param>
        /// <param name="phMax">Maximum pH level tolerance</param>
        /// <param name="lightMin">Minimum light intensity (units)</param>
        /// <param name="lightMax">Maximum light intensity (units)</param>
        /// <param name="waterLevelMin">Minimum water level requirement (%)</param>
        /// <param name="waterLevelMax">Maximum water level tolerance (%)</param>
        private void AddPlantProfile(string name, string type, string growthRate, string lightRequirements, string waterRequirements, string tempMinF, string tempMaxF, string moistureMin, string moistureMax, string phMin, string phMax, string lightMin, string lightMax, string waterLevelMin, string waterLevelMax)
        {
            // Create and open a connection to the SQLite database
            using var connection = new SQLiteConnection($"Data Source={strDbPath};Version=3;");
            connection.Open();

            // SQL query to insert a new plant profile with all parameters
            string insertQuery = "INSERT INTO PlantProfiles (Name, Type, GrowthRate, LightRequirements, WaterRequirements, TempMinF, TempMaxF, MoistureMin, MoistureMax, PhMin, PhMax, LightMin, LightMax, WaterLevelMin, WaterLevelMax) " +
                "VALUES (@Name, @Type, @GrowthRate, @LightRequirements, @WaterRequirements, @TempMinF, @TempMaxF, @MoistureMin, @MoistureMax, @PhMin, @PhMax, @LightMin, @LightMax, @WaterLevelMin, @WaterLevelMax)";

            // Create a command with the insert query and connection
            using var command = new SQLiteCommand(insertQuery, connection);

            // Add parameters to the command to prevent SQL injection
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@GrowthRate", growthRate);
            command.Parameters.AddWithValue("@LightRequirements", lightRequirements);
            command.Parameters.AddWithValue("@WaterRequirements", waterRequirements);
            command.Parameters.AddWithValue("@TempMinF", tempMinF);
            command.Parameters.AddWithValue("@TempMaxF", tempMaxF);
            command.Parameters.AddWithValue("@MoistureMin", moistureMin);
            command.Parameters.AddWithValue("@MoistureMax", moistureMax);
            command.Parameters.AddWithValue("@PhMin", phMin);
            command.Parameters.AddWithValue("@PhMax", phMax);
            command.Parameters.AddWithValue("@LightMin", lightMin);
            command.Parameters.AddWithValue("@LightMax", lightMax);
            command.Parameters.AddWithValue("@WaterLevelMin", waterLevelMin);
            command.Parameters.AddWithValue("@WaterLevelMax", waterLevelMax);

            // Execute the insert command to add the new plant profile
            command.ExecuteNonQuery();

            // Reload the plant profiles to update the DataGridView with the new entry
            LoadPlantProfiles();
        }

        /// <summary>
        /// Event handler for cell click events in the plant profiles DataGridView.
        /// Currently empty - can be implemented to handle selection or edit operations.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data containing cell information</param>
        private void dvgPlantProfilesForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method is currently empty
            // Can be implemented to handle cell click events, such as:
            // - Selecting a plant profile for detailed view
            // - Editing a plant profile
            // - Deleting a plant profile
        }
    }
}
