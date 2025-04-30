using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atelier2.view;

namespace Atelier2
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
            FormAutentification auth = new FormAutentification();
            if (auth.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormPersonnel());
            }
        }
    }
}
