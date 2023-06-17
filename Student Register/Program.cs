using System;
using System.IO;
using System.Windows.Forms;

namespace Student_Register
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupApp();
            Application.Run(new HomeForm());
        }

        private static void SetupApp()
        {
            const string fileDir = "C:\\Temporary Codes";
            //creates the folder that holds the access code .pdf files on the C drive
            if (!Directory.Exists(fileDir))
                Directory.CreateDirectory(fileDir);
        }
    }
}
