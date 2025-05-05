namespace Aquaponics
{
    partial class FruitBearingPlantForm
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
            dgvFriutForm = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFriutForm).BeginInit();
            SuspendLayout();
            // 
            // dgvFriutForm
            // 
            dgvFriutForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFriutForm.Location = new Point(12, 55);
            dgvFriutForm.Name = "dgvFriutForm";
            dgvFriutForm.RowHeadersWidth = 51;
            dgvFriutForm.Size = new Size(776, 353);
            dgvFriutForm.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(425, 38);
            label1.TabIndex = 1;
            label1.Text = "Fruit Bearers Growing Conditions";
            // 
            // FruitBearingPlantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvFriutForm);
            Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Name = "FruitBearingPlantForm";
            Text = "FruitBearingPlantForm";
            Load += FruitBearingPlantForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFriutForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFriutForm;
        private Label label1;
    }
}