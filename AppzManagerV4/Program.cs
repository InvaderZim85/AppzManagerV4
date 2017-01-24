using System;
using System.IO;
using System.Windows.Forms;
using AppzManagerV4.Forms;
using AppzManagerV4.Global;

namespace AppzManagerV4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitProgram();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void InitProgram()
        {
            // Set the base folder
            Properties.Settings.Default.BaseFolder = Path.Combine(Functions.GetBaseFolder(), "Data");
            Properties.Settings.Default.Save();

            if (!Directory.Exists(Properties.Settings.Default.BaseFolder))
            {
                Directory.CreateDirectory(Properties.Settings.Default.BaseFolder);
            }            

        }
    }
}
