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
        /// Start of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserInfoFrom userInfoFrom = new UserInfoFrom();

            Application.Run(userInfoFrom);
        }
    }
}
