using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace text_file_to_ui.Class
{
    public class UserFileReader
    {
        public string filePath;
        public UserFileReader() { }
        public void OpenFileExplorer()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.filePath = openFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("WrongFile");
                }
            }
        }

        public string[] ReadFile()
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                string filecontent = file.ReadToEnd();
                return filecontent.Split(new char[] { '\n' });
            }
        }
    }
}
