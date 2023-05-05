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
    public partial class UserInfoFrom : Form
    {
        public UserInfoFrom()
        {
            InitializeComponent();
        }

        //Presse the button to chose the file
        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            //Create object
            UserFileReader userFileReader = new UserFileReader();
            UserParser userParser = new UserParser();
            User user = new User();
            
            //Open the file and read data
            userFileReader.OpenFileExplorer();
            userParser.UserStringData = userFileReader.ReadFile();
            userParser.PaserData(user);

            //Display the data
            UserDisplayer userDisplayer = new UserDisplayer(user, this);

            userDisplayer.DisplayUser();
        }
    }
}
