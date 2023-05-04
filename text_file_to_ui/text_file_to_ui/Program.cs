using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using text_file_to_ui.Class;

namespace text_file_to_ui
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //do the run at the end
            UserInfoFrom userInfoFrom = new UserInfoFrom();

            Application.Run(userInfoFrom);
        }
    }
}
