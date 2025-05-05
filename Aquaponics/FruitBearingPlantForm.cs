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
    public partial class FruitBearingPlantForm : Form // Defining a partial class for the form
    {
        private string strDbPath = "Aquaponics.db"; // Defining the database file path

        public FruitBearingPlantForm() // Constructor for the form
        {
            InitializeComponent(); // Initializing the form components
        }

        private void FruitBearingPlantForm_Load(object sender, EventArgs e) // Event handler for form load
        {
            LoadFruitProfiles(); // Calling the method to load fruit profiles
        }

        private void LoadFruitProfiles() // Method to load fruit profiles from the database
        {
            try // Starting a try block to handle potential exceptions
            {
                string connectionString = $"Data Source={strDbPath};Version=3;"; // Defining the SQLite connection string
                using var connection = new SQLiteConnection(connectionString); // Creating a new SQLite connection
                connection.Open(); // Opening the database connection

                string selectQuery = "SELECT * FROM PlantProfiles WHERE Type = 'Fruit'"; // SQL query to select only fruit profiles

                using var adapter = new SQLiteDataAdapter(selectQuery, connection); // Creating a data adapter for the query
                DataTable dataTable = new(); // Creating a new DataTable to hold the query results
                adapter.Fill(dataTable); // Filling the DataTable with the query results
                dgvFriutForm.DataSource = dataTable; // Setting the DataGridView's data source to the DataTable
            }
            catch (Exception ex) // Catching any exceptions that occur
            {
                MessageBox.Show($"Error loading fruit profiles: {ex.Message}", "Database Error", // Displaying an error message
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Configuring the message box buttons and icon
            }
        }

        private void AddFruitProfile( // Method to add a new fruit profile to the database
            string name, // Name of the fruit
            string growthRate, // Growth rate of the fruit
            string lightRequirements, // Light requirements for the fruit
            string waterRequirements, // Water requirements for the fruit
            string tempMinF, // Minimum temperature in Fahrenheit
            string tempMaxF, // Maximum temperature in Fahrenheit
            string moistureMin, // Minimum moisture level
            string moistureMax, // Maximum moisture level
            string phMin, // Minimum pH level
            string phMax, // Maximum pH level
            string lightMin, // Minimum light level
            string lightMax, // Maximum light level
            string waterLevelMin, // Minimum water level
            string waterLevelMax // Maximum water level
        )
        {
            using var connection = new SQLiteConnection($"Data Source={strDbPath};Version=3;"); // Creating a new SQLite connection
            connection.Open(); // Opening the database connection

            string insertQuery = "INSERT INTO PlantProfiles (Name, Type, GrowthRate, LightRequirements, WaterRequirements, TempMinF, TempMaxF, MoistureMin, MoistureMax, PhMin, PhMax, LightMin, LightMax, WaterLevelMin, WaterLevelMax) " +
                "VALUES (@Name, @Type, @GrowthRate, @LightRequirements, @WaterRequirements, @TempMinF, @TempMaxF, @MoistureMin, @MoistureMax, @PhMin, @PhMax, @LightMin, @LightMax, @WaterLevelMin, @WaterLevelMax)"; // SQL query to insert a new fruit profile

            using var command = new SQLiteCommand(insertQuery, connection); // Creating a new SQLite command for the query
            command.Parameters.AddWithValue("@Name", name); // Adding the name parameter to the query
            command.Parameters.AddWithValue("@Type", "Fruit"); // Adding the type parameter (always "Fruit") to the query
            command.Parameters.AddWithValue("@GrowthRate", growthRate); // Adding the growth rate parameter to the query
            command.Parameters.AddWithValue("@LightRequirements", lightRequirements); // Adding the light requirements parameter to the query
            command.Parameters.AddWithValue("@WaterRequirements", waterRequirements); // Adding the water requirements parameter to the query
            command.Parameters.AddWithValue("@TempMinF", tempMinF); // Adding the minimum temperature parameter to the query
            command.Parameters.AddWithValue("@TempMaxF", tempMaxF); // Adding the maximum temperature parameter to the query
            command.Parameters.AddWithValue("@MoistureMin", moistureMin); // Adding the minimum moisture parameter to the query
            command.Parameters.AddWithValue("@MoistureMax", moistureMax); // Adding the maximum moisture parameter to the query
            command.Parameters.AddWithValue("@PhMin", phMin); // Adding the minimum pH parameter to the query
            command.Parameters.AddWithValue("@PhMax", phMax); // Adding the maximum pH parameter to the query
            command.Parameters.AddWithValue("@LightMin", lightMin); // Adding the minimum light parameter to the query
            command.Parameters.AddWithValue("@LightMax", lightMax); // Adding the maximum light parameter to the query
            command.Parameters.AddWithValue("@WaterLevelMin", waterLevelMin); // Adding the minimum water level parameter to the query
            command.Parameters.AddWithValue("@WaterLevelMax", waterLevelMax); // Adding the maximum water level parameter to the query

            command.ExecuteNonQuery(); // Executing the query to insert the new fruit profile

            LoadFruitProfiles(); // Reloading the fruit profiles to reflect the new addition
        }
    }
}