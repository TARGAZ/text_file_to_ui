using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_file_to_ui.Class
{
    public class UserFileReader
    {
        public string filePath;
        public UserFileReader() { }
        public void OpenFileExplorer(string filePath)
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
    }
}
