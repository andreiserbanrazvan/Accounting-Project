using Accounting_Project.Project;
using System;
using System.Windows.Forms;



namespace Accounting_Project
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
            Application.Run(new LoginFrm());

           // Application.Run(new MainFrm());
        }
    }
}
