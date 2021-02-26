using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            text1.Text = "";
            text2.Text = "";
        }

        private void destination_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                string path = fbd.SelectedPath;
                MessageBox.Show("You chose the path " + path);
                text1.Text = path;

                }
            }

        private void file_Click(object sender, EventArgs e)
        {
            
  
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Choose a file";
               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    MessageBox.Show(path);
                    text2.Text = path;
                }
                string pathtext = text2.Text;
                renametext.Text = pathtext;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourceFile = text1.Text;
            string destinationFile = text2.Text;
            File.Copy(sourceFile, destinationFile, true);
            







        }

        private void text1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string file1 = text2.Text;
 

            if (file1 == "")
            {
                MessageBox.Show("You need to chose a file first :)");
            }
            else
            File.Delete(file1);


        }

        private void Rename_Click(object sender, EventArgs e)
        {
            string name = renametext.Text;
            string file1 = text2.Text;

            

            File.Move(file1, name); // Rename the oldFileName into newFileName
            File.Delete(file1);
        }

        private void renametext_TextChanged(object sender, EventArgs e)
        {
         


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Light Mode")
            {
                label1.ForeColor = Color.FromArgb(32, 32, 32);
                this.BackColor = Color.FromArgb(192, 192, 192);
            }
            else if (comboBox1.Text == "Night Mode")
            {
                label1.ForeColor = Color.FromArgb(192, 192, 192);
                this.BackColor = Color.FromArgb(32, 32, 32);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createfilebutton_Click(object sender, EventArgs e)
        {
            string path = text1.Text;
            File.Create(path);
        }
    }
}
