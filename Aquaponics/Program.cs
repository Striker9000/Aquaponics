using System;
using System.Windows.Forms;
using Aquaponics;
using AquaponicsWinForms;

namespace AquaponicsWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the aquaponics monitoring application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();       // Enables modern Windows visual styles
            Application.SetCompatibleTextRenderingDefault(false); // Use GDI+ text rendering
            //Application.Run(new PlantProfilesForm()); // Launch the main form
            Application.Run(new Form1());           // Launch Form1
        }
    }
}
