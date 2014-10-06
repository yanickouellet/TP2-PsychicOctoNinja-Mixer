using System;
using System.Windows.Forms;
using DJ.Core.Controllers;

namespace DJ.Winforms
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frm = new FrmApp();

            Application.Run(frm);
        }
    }
}
