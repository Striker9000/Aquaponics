namespace Aquaponics
{
    partial class PlantProfilesForm
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
            components = new System.ComponentModel.Container();
            plantProfileBindingSource = new BindingSource(components);
            dgvPlantProfiles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)plantProfileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlantProfiles).BeginInit();
            SuspendLayout();
            // 
            // plantProfileBindingSource
            // 
            plantProfileBindingSource.DataSource = typeof(AquaponicsWinForms.PlantProfile);
            // 
            // dgvPlantProfiles
            // 
            dgvPlantProfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlantProfiles.Location = new Point(12, 63);
            dgvPlantProfiles.Name = "dgvPlantProfiles";
            dgvPlantProfiles.RowHeadersWidth = 51;
            dgvPlantProfiles.Size = new Size(776, 323);
            dgvPlantProfiles.TabIndex = 0;
            // 
            // PlantProfilesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPlantProfiles);
            Name = "PlantProfilesForm";
            Text = "PlantProfilesForm";
            Load += PlantProfilesForm_Load;
            ((System.ComponentModel.ISupportInitialize)plantProfileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlantProfiles).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource plantProfileBindingSource;
        private DataGridView dgvPlantProfiles;
    }
}