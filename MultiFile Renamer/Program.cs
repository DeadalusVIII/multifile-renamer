using System;
using System.Windows.Forms;

namespace MultiFile_Renamer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(args.Length > 0 ? new FormMain(args[0]) : new FormMain());
        }
    }
}