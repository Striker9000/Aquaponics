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
            button2 = new Button();
            button1 = new Button();
            waterRequirementsTextBox = new TextBox();
            LighRequirementsTextBox = new TextBox();
            grwRateLabel1 = new Label();
            wtrReqsLabel = new Label();
            LightReqlabel1 = new Label();
            growthRateTextBox = new TextBox();
            typeTextBox = new TextBox();
            typeLabel = new Label();
            plantProfilesFormButton = new Button();
            plantTypeComboBox = new ComboBox();
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
            statusLabel.BackColor = Color.Yellow;
            statusLabel.Location = new Point(6, 209);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(56, 20);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status: ";
            // 
            // plantProfileComboBox
            // 
            plantProfileComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            plantProfileComboBox.FormattingEnabled = true;
            plantProfileComboBox.Location = new Point(6, 227);
            plantProfileComboBox.Name = "plantProfileComboBox";
            plantProfileComboBox.Size = new Size(120, 28);
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
            MonitorPage.BackColor = SystemColors.ActiveCaptionText;
            MonitorPage.Controls.Add(sensorStatusTextBox);
            MonitorPage.Controls.Add(plantProfileComboBox);
            MonitorPage.Controls.Add(statusLabel);
            MonitorPage.Controls.Add(clearLogButton);
            MonitorPage.Controls.Add(startButton);
            MonitorPage.Controls.Add(stopButton);
            MonitorPage.Location = new Point(4, 29);
            MonitorPage.Name = "MonitorPage";
            MonitorPage.Padding = new Padding(3);
            MonitorPage.Size = new Size(634, 303);
            MonitorPage.TabIndex = 0;
            MonitorPage.Text = "Monitor";
            MonitorPage.Click += MonitorPage_Click;
            // 
            // AddPlantPage
            // 
            AddPlantPage.BackColor = Color.Gold;
            AddPlantPage.Controls.Add(button2);
            AddPlantPage.Controls.Add(button1);
            AddPlantPage.Controls.Add(waterRequirementsTextBox);
            AddPlantPage.Controls.Add(LighRequirementsTextBox);
            AddPlantPage.Controls.Add(grwRateLabel1);
            AddPlantPage.Controls.Add(wtrReqsLabel);
            AddPlantPage.Controls.Add(LightReqlabel1);
            AddPlantPage.Controls.Add(growthRateTextBox);
            AddPlantPage.Controls.Add(typeTextBox);
            AddPlantPage.Controls.Add(typeLabel);
            AddPlantPage.Controls.Add(plantProfilesFormButton);
            AddPlantPage.Controls.Add(plantTypeComboBox);
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
            AddPlantPage.Location = new Point(4, 29);
            AddPlantPage.Name = "AddPlantPage";
            AddPlantPage.Padding = new Padding(3);
            AddPlantPage.Size = new Size(634, 303);
            AddPlantPage.TabIndex = 1;
            AddPlantPage.Text = "Add Plant";
            AddPlantPage.Click += AddPlantPage_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 75);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 35;
            button2.Text = "LeafProfile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(523, 40);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "FruitProfile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // waterRequirementsTextBox
            // 
            waterRequirementsTextBox.Location = new Point(296, 96);
            waterRequirementsTextBox.Name = "waterRequirementsTextBox";
            waterRequirementsTextBox.Size = new Size(100, 27);
            waterRequirementsTextBox.TabIndex = 33;
            // 
            // LighRequirementsTextBox
            // 
            LighRequirementsTextBox.Location = new Point(139, 96);
            LighRequirementsTextBox.Name = "LighRequirementsTextBox";
            LighRequirementsTextBox.Size = new Size(100, 27);
            LighRequirementsTextBox.TabIndex = 32;
            // 
            // grwRateLabel1
            // 
            grwRateLabel1.AutoSize = true;
            grwRateLabel1.Location = new Point(183, 45);
            grwRateLabel1.Name = "grwRateLabel1";
            grwRateLabel1.Size = new Size(91, 20);
            grwRateLabel1.TabIndex = 31;
            grwRateLabel1.Text = "Growth Rate";
            // 
            // wtrReqsLabel
            // 
            wtrReqsLabel.AutoSize = true;
            wtrReqsLabel.Location = new Point(296, 73);
            wtrReqsLabel.Name = "wtrReqsLabel";
            wtrReqsLabel.Size = new Size(143, 20);
            wtrReqsLabel.TabIndex = 30;
            wtrReqsLabel.Text = "Water Requirements";
            wtrReqsLabel.Click += label1_Click_1;
            // 
            // LightReqlabel1
            // 
            LightReqlabel1.AutoSize = true;
            LightReqlabel1.Location = new Point(139, 73);
            LightReqlabel1.Name = "LightReqlabel1";
            LightReqlabel1.Size = new Size(137, 20);
            LightReqlabel1.TabIndex = 29;
            LightReqlabel1.Text = "Light Requirements";
            // 
            // growthRateTextBox
            // 
            growthRateTextBox.Location = new Point(280, 42);
            growthRateTextBox.Name = "growthRateTextBox";
            growthRateTextBox.Size = new Size(125, 27);
            growthRateTextBox.TabIndex = 28;
            growthRateTextBox.Text = "Moderate";
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(52, 45);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(125, 27);
            typeTextBox.TabIndex = 27;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(6, 45);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(40, 20);
            typeLabel.TabIndex = 26;
            typeLabel.Text = "Type";
            // 
            // plantProfilesFormButton
            // 
            plantProfilesFormButton.Location = new Point(523, 5);
            plantProfilesFormButton.Name = "plantProfilesFormButton";
            plantProfilesFormButton.Size = new Size(94, 29);
            plantProfilesFormButton.TabIndex = 25;
            plantProfilesFormButton.Text = "PlantProfile";
            plantProfilesFormButton.UseVisualStyleBackColor = true;
            plantProfilesFormButton.Click += plantProfilesFormButton_Click;
            // 
            // plantTypeComboBox
            // 
            plantTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            plantTypeComboBox.FormattingEnabled = true;
            plantTypeComboBox.Items.AddRange(new object[] { "PlantProfile", "LeafyGreenProfile", "FruitBearingPlantProfile" });
            plantTypeComboBox.Location = new Point(383, 6);
            plantTypeComboBox.Name = "plantTypeComboBox";
            plantTypeComboBox.Size = new Size(121, 28);
            plantTypeComboBox.TabIndex = 24;
            plantTypeComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addProfileButton
            // 
            addProfileButton.BackColor = Color.Chartreuse;
            addProfileButton.Location = new Point(497, 258);
            addProfileButton.Name = "addProfileButton";
            addProfileButton.Size = new Size(120, 27);
            addProfileButton.TabIndex = 23;
            addProfileButton.Text = "Add Plant Profile";
            addProfileButton.UseVisualStyleBackColor = false;
            addProfileButton.Click += addProfileButton_Click;
            // 
            // waterLevelMaxTextBox
            // 
            waterLevelMaxTextBox.Location = new Point(296, 202);
            waterLevelMaxTextBox.Name = "waterLevelMaxTextBox";
            waterLevelMaxTextBox.Size = new Size(100, 27);
            waterLevelMaxTextBox.TabIndex = 22;
            // 
            // waterLevelMinTextBox
            // 
            waterLevelMinTextBox.Location = new Point(296, 149);
            waterLevelMinTextBox.Name = "waterLevelMinTextBox";
            waterLevelMinTextBox.Size = new Size(100, 27);
            waterLevelMinTextBox.TabIndex = 21;
            // 
            // lightMaxTextBox
            // 
            lightMaxTextBox.Location = new Point(139, 202);
            lightMaxTextBox.Name = "lightMaxTextBox";
            lightMaxTextBox.Size = new Size(100, 27);
            lightMaxTextBox.TabIndex = 20;
            lightMaxTextBox.TextChanged += textBox9_TextChanged;
            // 
            // lightMinTextBox
            // 
            lightMinTextBox.Location = new Point(139, 149);
            lightMinTextBox.Name = "lightMinTextBox";
            lightMinTextBox.Size = new Size(100, 27);
            lightMinTextBox.TabIndex = 19;
            // 
            // phMaxTextBox
            // 
            phMaxTextBox.Location = new Point(296, 258);
            phMaxTextBox.Name = "phMaxTextBox";
            phMaxTextBox.Size = new Size(100, 27);
            phMaxTextBox.TabIndex = 18;
            // 
            // phMinTextBox
            // 
            phMinTextBox.Location = new Point(139, 258);
            phMinTextBox.Name = "phMinTextBox";
            phMinTextBox.Size = new Size(100, 27);
            phMinTextBox.TabIndex = 17;
            // 
            // moistureMaxTextBox
            // 
            moistureMaxTextBox.Location = new Point(6, 258);
            moistureMaxTextBox.Name = "moistureMaxTextBox";
            moistureMaxTextBox.Size = new Size(100, 27);
            moistureMaxTextBox.TabIndex = 16;
            // 
            // moistureMinTextBox
            // 
            moistureMinTextBox.Location = new Point(6, 202);
            moistureMinTextBox.Name = "moistureMinTextBox";
            moistureMinTextBox.Size = new Size(100, 27);
            moistureMinTextBox.TabIndex = 15;
            // 
            // tempMaxTextBox
            // 
            tempMaxTextBox.Location = new Point(6, 149);
            tempMaxTextBox.Name = "tempMaxTextBox";
            tempMaxTextBox.Size = new Size(100, 27);
            tempMaxTextBox.TabIndex = 14;
            // 
            // tempMinTextBox
            // 
            tempMinTextBox.Location = new Point(6, 96);
            tempMinTextBox.Name = "tempMinTextBox";
            tempMinTextBox.Size = new Size(100, 27);
            tempMinTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(52, 7);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(186, 27);
            nameTextBox.TabIndex = 12;
            // 
            // WatLevMax
            // 
            WatLevMax.AutoSize = true;
            WatLevMax.Location = new Point(296, 175);
            WatLevMax.Name = "WatLevMax";
            WatLevMax.Size = new Size(144, 20);
            WatLevMax.TabIndex = 11;
            WatLevMax.Text = "Water Level Max (%)";
            // 
            // WatLevMin
            // 
            WatLevMin.AutoSize = true;
            WatLevMin.Location = new Point(296, 126);
            WatLevMin.Name = "WatLevMin";
            WatLevMin.Size = new Size(141, 20);
            WatLevMin.TabIndex = 10;
            WatLevMin.Text = "Water Level Min (%)";
            // 
            // LitMax
            // 
            LitMax.AutoSize = true;
            LitMax.Location = new Point(139, 179);
            LitMax.Name = "LitMax";
            LitMax.Size = new Size(107, 20);
            LitMax.TabIndex = 9;
            LitMax.Text = "Light Max (lux)";
            // 
            // LitMin
            // 
            LitMin.AutoSize = true;
            LitMin.Location = new Point(139, 126);
            LitMin.Name = "LitMin";
            LitMin.Size = new Size(104, 20);
            LitMin.TabIndex = 8;
            LitMin.Text = "Light Min (lux)";
            // 
            // pHMax
            // 
            pHMax.AutoSize = true;
            pHMax.Location = new Point(296, 235);
            pHMax.Name = "pHMax";
            pHMax.Size = new Size(61, 20);
            pHMax.TabIndex = 7;
            pHMax.Text = "pH Max";
            // 
            // pHMin
            // 
            pHMin.AutoSize = true;
            pHMin.Location = new Point(139, 235);
            pHMin.Name = "pHMin";
            pHMin.Size = new Size(58, 20);
            pHMin.TabIndex = 6;
            pHMin.Text = "pH Min";
            // 
            // MoistMax
            // 
            MoistMax.AutoSize = true;
            MoistMax.Location = new Point(3, 235);
            MoistMax.Name = "MoistMax";
            MoistMax.Size = new Size(125, 20);
            MoistMax.TabIndex = 5;
            MoistMax.Text = "\tMoisture Max (%)";
            // 
            // MoistMin
            // 
            MoistMin.AutoSize = true;
            MoistMin.Location = new Point(6, 179);
            MoistMin.Name = "MoistMin";
            MoistMin.Size = new Size(122, 20);
            MoistMin.TabIndex = 4;
            MoistMin.Text = "Moisture Min (%)";
            // 
            // TempMax
            // 
            TempMax.AutoSize = true;
            TempMax.Location = new Point(3, 126);
            TempMax.Name = "TempMax";
            TempMax.Size = new Size(105, 20);
            TempMax.TabIndex = 3;
            TempMax.Text = "Temp Max (°F)";
            // 
            // TempMin
            // 
            TempMin.AutoSize = true;
            TempMin.Location = new Point(3, 73);
            TempMin.Name = "TempMin";
            TempMin.Size = new Size(102, 20);
            TempMin.TabIndex = 2;
            TempMin.Text = "Temp Min (°F)";
            // 
            // PlantName
            // 
            PlantName.AutoSize = true;
            PlantName.Location = new Point(6, 10);
            PlantName.Name = "PlantName";
            PlantName.Size = new Size(49, 20);
            PlantName.TabIndex = 1;
            PlantName.Text = "Name";
            PlantName.Click += PlantName_Click;
            // 
            // AddPlant
            // 
            AddPlant.AutoSize = true;
            AddPlant.Font = new Font("Segoe UI", 16F);
            AddPlant.Location = new Point(244, 2);
            AddPlant.Name = "AddPlant";
            AddPlant.Size = new Size(133, 37);
            AddPlant.TabIndex = 0;
            AddPlant.Text = "Add Plant";
            AddPlant.Click += label1_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlText;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(663, 358);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Aquaponics Monitor";
            TransparencyKey = Color.FromArgb(255, 128, 0);
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
        private ComboBox plantTypeComboBox;
        private Button plantProfilesFormButton;
        private Label typeLabel;
        private Label wtrReqsLabel;
        private Label LightReqlabel1;
        private TextBox growthRateTextBox;
        private TextBox typeTextBox;
        private Label grwRateLabel1;
        private TextBox waterRequirementsTextBox;
        private TextBox LighRequirementsTextBox;
        private Button button2;
        private Button button1;
    }
}
