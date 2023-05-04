using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using text_file_to_ui.Class;

namespace text_file_to_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            UserFileReader userFileReader = new UserFileReader();
            UserParser userParser = new UserParser();
            User user = new User();
            userFileReader.OpenFileExplorer();
            userParser.UserStringData = userFileReader.ReadFile();
            userParser.PaserData(user);
            return;
        }

    }
}
