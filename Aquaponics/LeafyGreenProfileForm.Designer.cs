namespace Aquaponics
{
    partial class LeafyGreenProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dbgLeafyGreenProfile = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dbgLeafyGreenProfile).BeginInit();
            SuspendLayout();
            // 
            // dbgLeafyGreenProfile
            // 
            dbgLeafyGreenProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgLeafyGreenProfile.Location = new Point(12, 51);
            dbgLeafyGreenProfile.Name = "dbgLeafyGreenProfile";
            dbgLeafyGreenProfile.RowHeadersWidth = 51;
            dbgLeafyGreenProfile.Size = new Size(776, 343);
            dbgLeafyGreenProfile.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 37);
            label1.TabIndex = 1;
            label1.Text = "\"Leafy Greens Growth Data\"";
            // 
            // LeafyGreenProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dbgLeafyGreenProfile);
            Name = "LeafyGreenProfileForm";
            Text = "LeafyGreenProfileForm";
            Load += LeafyGreenProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)dbgLeafyGreenProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dbgLeafyGreenProfile;
        private Label label1;
    }
}