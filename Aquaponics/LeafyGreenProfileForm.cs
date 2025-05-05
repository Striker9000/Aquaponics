using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aquaponics
{
    public partial class LeafyGreenProfileForm : Form // Defining a partial class for the form
    {
        private string strDbPath = "Aquaponics.db"; // Path to the SQLite database file

        public LeafyGreenProfileForm() // Constructor for the form
        {
            InitializeComponent(); // Initialize the form components
            this.Load += LeafyGreenProfileForm_Load; // Attach the Load event handler
        }

        private void LeafyGreenProfileForm_Load(object sender, EventArgs e) // Event handler for form load
        {
            LoadCannabisProfiles(); // Call the method to load cannabis profiles
        }

        private void LoadCannabisProfiles() // Method to load cannabis profiles from the database
        {
            try // Start of try block to handle exceptions
            {
                string connectionString = $"Data Source={strDbPath};Version=3;"; // Define the connection string for SQLite
                using var connection = new SQLiteConnection(connectionString); // Create a new SQLite connection
                connection.Open(); // Open the database connection

                // SQL query to select only cannabis profiles from the PlantProfiles table
                string selectQuery = "SELECT * FROM PlantProfiles WHERE Type = 'Cannabis'";

                using var adapter = new SQLiteDataAdapter(selectQuery, connection); // Create a data adapter for the query
                DataTable dataTable = new(); // Create a new DataTable to hold the query results
                adapter.Fill(dataTable); // Fill the DataTable with the query results
                dbgLeafyGreenProfile.DataSource = dataTable; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex) // Catch block to handle exceptions
            {
                // Show an error message if an exception occurs
                MessageBox.Show($"Error loading cannabis profiles: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to add a new cannabis profile to the database
        private void AddCannabisProfile(string name, string growthRate, string lightRequirements, string waterRequirements, string tempMinF, string tempMaxF, string moistureMin, string moistureMax, string phMin, string phMax, string lightMin, string lightMax, string waterLevelMin, string waterLevelMax)
        {
            using var connection = new SQLiteConnection($"Data Source={strDbPath};Version=3;"); // Create a new SQLite connection
            connection.Open(); // Open the database connection

            // SQL query to insert a new cannabis profile into the PlantProfiles table
            string insertQuery = "INSERT INTO PlantProfiles (Name, Type, GrowthRate, LightRequirements, WaterRequirements, TempMinF, TempMaxF, MoistureMin, MoistureMax, PhMin, PhMax, LightMin, LightMax, WaterLevelMin, WaterLevelMax) " +
                "VALUES (@Name, @Type, @GrowthRate, @LightRequirements, @WaterRequirements, @TempMinF, @TempMaxF, @MoistureMin, @MoistureMax, @PhMin, @PhMax, @LightMin, @LightMax, @WaterLevelMin, @WaterLevelMax)";

            using var command = new SQLiteCommand(insertQuery, connection); // Create a new SQLite command for the query
            command.Parameters.AddWithValue("@Name", name); // Add the name parameter to the query
            command.Parameters.AddWithValue("@Type", "Cannabis"); // Add the type parameter (always "Cannabis") to the query
            command.Parameters.AddWithValue("@GrowthRate", growthRate); // Add the growth rate parameter to the query
            command.Parameters.AddWithValue("@LightRequirements", lightRequirements); // Add the light requirements parameter to the query
            command.Parameters.AddWithValue("@WaterRequirements", waterRequirements); // Add the water requirements parameter to the query
            command.Parameters.AddWithValue("@TempMinF", tempMinF); // Add the minimum temperature parameter to the query
            command.Parameters.AddWithValue("@TempMaxF", tempMaxF); // Add the maximum temperature parameter to the query
            command.Parameters.AddWithValue("@MoistureMin", moistureMin); // Add the minimum moisture parameter to the query
            command.Parameters.AddWithValue("@MoistureMax", moistureMax); // Add the maximum moisture parameter to the query
            command.Parameters.AddWithValue("@PhMin", phMin); // Add the minimum pH parameter to the query
            command.Parameters.AddWithValue("@PhMax", phMax); // Add the maximum pH parameter to the query
            command.Parameters.AddWithValue("@LightMin", lightMin); // Add the minimum light parameter to the query
            command.Parameters.AddWithValue("@LightMax", lightMax); // Add the maximum light parameter to the query
            command.Parameters.AddWithValue("@WaterLevelMin", waterLevelMin); // Add the minimum water level parameter to the query
            command.Parameters.AddWithValue("@WaterLevelMax", waterLevelMax); // Add the maximum water level parameter to the query

            command.ExecuteNonQuery(); // Execute the query to insert the new profile

            LoadCannabisProfiles(); // Reload the cannabis profiles to reflect the new addition
        }
    }
}