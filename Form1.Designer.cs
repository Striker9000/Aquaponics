namespace AquaponicsWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sensorStatusTextBox = new TextBox();
            startButton = new Button();
            stopButton = new Button();
            clearLogButton = new Button();
            statusLabel = new Label();
            plantProfileComboBox = new ComboBox();
            tabControl1 = new TabControl();
            MonitorPage = new TabPage();
            AddPlantPage = new TabPage();
            addProfileButton = new Button();
            waterLevelMaxTextBox = new TextBox();
            waterLevelMinTextBox = new TextBox();
            lightMaxTextBox = new TextBox();
            lightMinTextBox = new TextBox();
            phMaxTextBox = new TextBox();
            phMinTextBox = new TextBox();
            moistureMaxTextBox = new TextBox();
            moistureMinTextBox = new TextBox();
            tempMaxTextBox = new TextBox();
            tempMinTextBox = new TextBox();
            nameTextBox = new TextBox();
            WatLevMax = new Label();
            WatLevMin = new Label();
            LitMax = new Label();
            LitMin = new Label();
            pHMax = new Label();
            pHMin = new Label();
            MoistMax = new Label();
            MoistMin = new Label();
            TempMax = new Label();
            TempMin = new Label();
            PlantName = new Label();
            AddPlant = new Label();
            tabControl1.SuspendLayout();
            MonitorPage.SuspendLayout();
            AddPlantPage.SuspendLayout();
            SuspendLayout();
            // 
            // sensorStatusTextBox
            // 
            sensorStatusTextBox.Font = new Font("Consolas", 10F);
            sensorStatusTextBox.Location = new Point(6, 6);
            sensorStatusTextBox.Multiline = true;
            sensorStatusTextBox.Name = "sensorStatusTextBox";
            sensorStatusTextBox.ReadOnly = true;
            sensorStatusTextBox.ScrollBars = ScrollBars.Vertical;
            sensorStatusTextBox.Size = new Size(320, 197);
            sensorStatusTextBox.TabIndex = 0;
            sensorStatusTextBox.TextChanged += sensorStatusTextBox_TextChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(332, 6);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 30);
            startButton.TabIndex = 1;
            startButton.Text = "Start Monitoring";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(332, 42);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop Monitoring";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // clearLogButton
            // 
            clearLogButton.Location = new Point(332, 78);
            clearLogButton.Name = "clearLogButton";
            clearLogButton.Size = new Size(120, 30);
            clearLogButton.TabIndex = 3;
            clearLogButton.Text = "Clear Log";
            clearLogButton.UseVisualStyleBackColor = true;
            clearLogButton.Click += clearLogButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(6, 209);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(45, 15);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status: ";
            // 
            // plantProfileComboBox
            // 
            plantProfileComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            plantProfileComboBox.FormattingEnabled = true;
            plantProfileComboBox.Location = new Point(6, 227);
            plantProfileComboBox.Name = "plantProfileComboBox";
            plantProfileComboBox.Size = new Size(120, 23);
            plantProfileComboBox.TabIndex = 5;
            plantProfileComboBox.SelectedIndexChanged += plantProfileComboBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MonitorPage);
            tabControl1.Controls.Add(AddPlantPage);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(642, 336);
            tabControl1.TabIndex = 6;
            // 
            // MonitorPage
            // 
            MonitorPage.Controls.Add(sensorStatusTextBox);
            MonitorPage.Controls.Add(plantProfileComboBox);
            MonitorPage.Controls.Add(statusLabel);
            MonitorPage.Controls.Add(clearLogButton);
            MonitorPage.Controls.Add(startButton);
            MonitorPage.Controls.Add(stopButton);
            MonitorPage.Location = new Point(4, 24);
            MonitorPage.Name = "MonitorPage";
            MonitorPage.Padding = new Padding(3);
            MonitorPage.Size = new Size(634, 308);
            MonitorPage.TabIndex = 0;
            MonitorPage.Text = "Monitor";
            MonitorPage.UseVisualStyleBackColor = true;
            // 
            // AddPlantPage
            // 
            AddPlantPage.Controls.Add(addProfileButton);
            AddPlantPage.Controls.Add(waterLevelMaxTextBox);
            AddPlantPage.Controls.Add(waterLevelMinTextBox);
            AddPlantPage.Controls.Add(lightMaxTextBox);
            AddPlantPage.Controls.Add(lightMinTextBox);
            AddPlantPage.Controls.Add(phMaxTextBox);
            AddPlantPage.Controls.Add(phMinTextBox);
            AddPlantPage.Controls.Add(moistureMaxTextBox);
            AddPlantPage.Controls.Add(moistureMinTextBox);
            AddPlantPage.Controls.Add(tempMaxTextBox);
            AddPlantPage.Controls.Add(tempMinTextBox);
            AddPlantPage.Controls.Add(nameTextBox);
            AddPlantPage.Controls.Add(WatLevMax);
            AddPlantPage.Controls.Add(WatLevMin);
            AddPlantPage.Controls.Add(LitMax);
            AddPlantPage.Controls.Add(LitMin);
            AddPlantPage.Controls.Add(pHMax);
            AddPlantPage.Controls.Add(pHMin);
            AddPlantPage.Controls.Add(MoistMax);
            AddPlantPage.Controls.Add(MoistMin);
            AddPlantPage.Controls.Add(TempMax);
            AddPlantPage.Controls.Add(TempMin);
            AddPlantPage.Controls.Add(PlantName);
            AddPlantPage.Controls.Add(AddPlant);
            AddPlantPage.Location = new Point(4, 24);
            AddPlantPage.Name = "AddPlantPage";
            AddPlantPage.Padding = new Padding(3);
            AddPlantPage.Size = new Size(634, 308);
            AddPlantPage.TabIndex = 1;
            AddPlantPage.Text = "Add Plant";
            AddPlantPage.UseVisualStyleBackColor = true;
            // 
            // addProfileButton
            // 
            addProfileButton.Location = new Point(317, 239);
            addProfileButton.Name = "addProfileButton";
            addProfileButton.Size = new Size(120, 41);
            addProfileButton.TabIndex = 23;
            addProfileButton.Text = "Add Plant Profile";
            addProfileButton.UseVisualStyleBackColor = true;
            addProfileButton.Click += addProfileButton_Click;
            // 
            // waterLevelMaxTextBox
            // 
            waterLevelMaxTextBox.Location = new Point(337, 198);
            waterLevelMaxTextBox.Name = "waterLevelMaxTextBox";
            waterLevelMaxTextBox.Size = new Size(100, 23);
            waterLevelMaxTextBox.TabIndex = 22;
            // 
            // waterLevelMinTextBox
            // 
            waterLevelMinTextBox.Location = new Point(337, 172);
            waterLevelMinTextBox.Name = "waterLevelMinTextBox";
            waterLevelMinTextBox.Size = new Size(100, 23);
            waterLevelMinTextBox.TabIndex = 21;
            // 
            // lightMaxTextBox
            // 
            lightMaxTextBox.Location = new Point(337, 123);
            lightMaxTextBox.Name = "lightMaxTextBox";
            lightMaxTextBox.Size = new Size(100, 23);
            lightMaxTextBox.TabIndex = 20;
            lightMaxTextBox.TextChanged += textBox9_TextChanged;
            // 
            // lightMinTextBox
            // 
            lightMinTextBox.Location = new Point(337, 94);
            lightMinTextBox.Name = "lightMinTextBox";
            lightMinTextBox.Size = new Size(100, 23);
            lightMinTextBox.TabIndex = 19;
            // 
            // phMaxTextBox
            // 
            phMaxTextBox.Location = new Point(102, 239);
            phMaxTextBox.Name = "phMaxTextBox";
            phMaxTextBox.Size = new Size(100, 23);
            phMaxTextBox.TabIndex = 18;
            // 
            // phMinTextBox
            // 
            phMinTextBox.Location = new Point(102, 210);
            phMinTextBox.Name = "phMinTextBox";
            phMinTextBox.Size = new Size(100, 23);
            phMinTextBox.TabIndex = 17;
            // 
            // moistureMaxTextBox
            // 
            moistureMaxTextBox.Location = new Point(102, 161);
            moistureMaxTextBox.Name = "moistureMaxTextBox";
            moistureMaxTextBox.Size = new Size(100, 23);
            moistureMaxTextBox.TabIndex = 16;
            // 
            // moistureMinTextBox
            // 
            moistureMinTextBox.Location = new Point(102, 132);
            moistureMinTextBox.Name = "moistureMinTextBox";
            moistureMinTextBox.Size = new Size(100, 23);
            moistureMinTextBox.TabIndex = 15;
            // 
            // tempMaxTextBox
            // 
            tempMaxTextBox.Location = new Point(102, 88);
            tempMaxTextBox.Name = "tempMaxTextBox";
            tempMaxTextBox.Size = new Size(100, 23);
            tempMaxTextBox.TabIndex = 14;
            // 
            // tempMinTextBox
            // 
            tempMinTextBox.Location = new Point(102, 59);
            tempMinTextBox.Name = "tempMinTextBox";
            tempMinTextBox.Size = new Size(100, 23);
            tempMinTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(50, 30);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 12;
            // 
            // WatLevMax
            // 
            WatLevMax.AutoSize = true;
            WatLevMax.Location = new Point(217, 198);
            WatLevMax.Name = "WatLevMax";
            WatLevMax.Size = new Size(114, 15);
            WatLevMax.TabIndex = 11;
            WatLevMax.Text = "Water Level Max (%)";
            // 
            // WatLevMin
            // 
            WatLevMin.AutoSize = true;
            WatLevMin.Location = new Point(218, 172);
            WatLevMin.Name = "WatLevMin";
            WatLevMin.Size = new Size(113, 15);
            WatLevMin.TabIndex = 10;
            WatLevMin.Text = "Water Level Min (%)";
            // 
            // LitMax
            // 
            LitMax.AutoSize = true;
            LitMax.Location = new Point(246, 126);
            LitMax.Name = "LitMax";
            LitMax.Size = new Size(85, 15);
            LitMax.TabIndex = 9;
            LitMax.Text = "Light Max (lux)";
            // 
            // LitMin
            // 
            LitMin.AutoSize = true;
            LitMin.Location = new Point(247, 97);
            LitMin.Name = "LitMin";
            LitMin.Size = new Size(84, 15);
            LitMin.TabIndex = 8;
            LitMin.Text = "Light Min (lux)";
            // 
            // pHMax
            // 
            pHMax.AutoSize = true;
            pHMax.Location = new Point(48, 242);
            pHMax.Name = "pHMax";
            pHMax.Size = new Size(48, 15);
            pHMax.TabIndex = 7;
            pHMax.Text = "pH Max";
            // 
            // pHMin
            // 
            pHMin.AutoSize = true;
            pHMin.Location = new Point(49, 213);
            pHMin.Name = "pHMin";
            pHMin.Size = new Size(47, 15);
            pHMin.TabIndex = 6;
            pHMin.Text = "pH Min";
            // 
            // MoistMax
            // 
            MoistMax.AutoSize = true;
            MoistMax.Location = new Point(-4, 164);
            MoistMax.Name = "MoistMax";
            MoistMax.Size = new Size(100, 15);
            MoistMax.TabIndex = 5;
            MoistMax.Text = "\tMoisture Max (%)";
            // 
            // MoistMin
            // 
            MoistMin.AutoSize = true;
            MoistMin.Location = new Point(-3, 140);
            MoistMin.Name = "MoistMin";
            MoistMin.Size = new Size(99, 15);
            MoistMin.TabIndex = 4;
            MoistMin.Text = "Moisture Min (%)";
            // 
            // TempMax
            // 
            TempMax.AutoSize = true;
            TempMax.Location = new Point(12, 88);
            TempMax.Name = "TempMax";
            TempMax.Size = new Size(84, 15);
            TempMax.TabIndex = 3;
            TempMax.Text = "Temp Max (°F)";
            // 
            // TempMin
            // 
            TempMin.AutoSize = true;
            TempMin.Location = new Point(13, 67);
            TempMin.Name = "TempMin";
            TempMin.Size = new Size(83, 15);
            TempMin.TabIndex = 2;
            TempMin.Text = "Temp Min (°F)";
            // 
            // PlantName
            // 
            PlantName.AutoSize = true;
            PlantName.Location = new Point(6, 33);
            PlantName.Name = "PlantName";
            PlantName.Size = new Size(39, 15);
            PlantName.TabIndex = 1;
            PlantName.Text = "Name";
            // 
            // AddPlant
            // 
            AddPlant.AutoSize = true;
            AddPlant.Font = new Font("Segoe UI", 16F);
            AddPlant.Location = new Point(0, 3);
            AddPlant.Name = "AddPlant";
            AddPlant.Size = new Size(106, 30);
            AddPlant.TabIndex = 0;
            AddPlant.Text = "Add Plant";
            AddPlant.Click += label1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(666, 360);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Aquaponics Monitor";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            MonitorPage.ResumeLayout(false);
            MonitorPage.PerformLayout();
            AddPlantPage.ResumeLayout(false);
            AddPlantPage.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sensorStatusTextBox;
        private System.Windows.Forms.ComboBox plantProfileComboBox;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Label statusLabel;
        private TabControl tabControl1;
        private TabPage MonitorPage;
        private TabPage AddPlantPage;
        private Label AddPlant;
        private Label PlantName;
        private TextBox phMinTextBox;
        private TextBox moistureMaxTextBox;
        private TextBox moistureMinTextBox;
        private TextBox tempMaxTextBox;
        private TextBox tempMinTextBox;
        private TextBox nameTextBox;
        private Label WatLevMax;
        private Label WatLevMin;
        private Label LitMax;
        private Label LitMin;
        private Label pHMax;
        private Label pHMin;
        private Label MoistMax;
        private Label MoistMin;
        private Label TempMax;
        private Label TempMin;
        private TextBox waterLevelMaxTextBox;
        private TextBox waterLevelMinTextBox;
        private TextBox lightMaxTextBox;
        private TextBox lightMinTextBox;
        private TextBox phMaxTextBox;
        private Button addProfileButton;
    }
}
