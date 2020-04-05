using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nl.hyperdata.gamemaker.builder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ErrorHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void ErrorHandler(object sender, UnhandledExceptionEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
