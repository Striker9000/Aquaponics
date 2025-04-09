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
            SuspendLayout();
            // 
            // sensorStatusTextBox
            // 
            sensorStatusTextBox.Font = new Font("Consolas", 10F);
            sensorStatusTextBox.Location = new Point(12, 12);
            sensorStatusTextBox.Multiline = true;
            sensorStatusTextBox.Name = "sensorStatusTextBox";
            sensorStatusTextBox.ReadOnly = true;
            sensorStatusTextBox.ScrollBars = ScrollBars.Vertical;
            sensorStatusTextBox.Size = new Size(500, 274);
            sensorStatusTextBox.TabIndex = 0;
            sensorStatusTextBox.TextChanged += sensorStatusTextBox_TextChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(530, 20);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 30);
            startButton.TabIndex = 1;
            startButton.Text = "Start Monitoring";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(530, 60);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop Monitoring";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // clearLogButton
            // 
            clearLogButton.Location = new Point(530, 100);
            clearLogButton.Name = "clearLogButton";
            clearLogButton.Size = new Size(120, 30);
            clearLogButton.TabIndex = 3;
            clearLogButton.Text = "Clear Log";
            clearLogButton.UseVisualStyleBackColor = true;
            clearLogButton.Click += clearLogButton_Click;
            // 
            // plantProfileComboBox
            // 
            this.plantProfileComboBox = new System.Windows.Forms.ComboBox();
            this.plantProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantProfileComboBox.FormattingEnabled = true;
            this.plantProfileComboBox.Location = new System.Drawing.Point(530, 160);
            this.plantProfileComboBox.Name = "plantProfileComboBox";
            this.plantProfileComboBox.Size = new System.Drawing.Size(120, 23);
            this.plantProfileComboBox.TabIndex = 5;
            this.plantProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.plantProfileComboBox_SelectedIndexChanged);


            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(530, 135);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(56, 20);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status: ";
            // 
            // Form1
            // 
            ClientSize = new Size(664, 301);
            Controls.Add(statusLabel);
            Controls.Add(clearLogButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(sensorStatusTextBox);
            //this.Controls.Add(this.plantProfileComboBox);
            Controls.Add(plantProfileComboBox);
            Controls.Add(statusLabel);
            Controls.Add(clearLogButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(sensorStatusTextBox);
            Name = "Form1";
            Text = "Aquaponics Monitor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sensorStatusTextBox;
        private System.Windows.Forms.ComboBox plantProfileComboBox;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Label statusLabel;
    }
}
