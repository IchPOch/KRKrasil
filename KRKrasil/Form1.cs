using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
namespace KRKrasil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            string path = @"USR.txt";
            using (StreamWriter file1 = new StreamWriter(path))
            {
                
                RegistryKey rk = Registry.Users;

                string[] names = rk.GetSubKeyNames();


                textBox1.Text += rk.Name;
                textBox1.Text += Environment.NewLine;

                foreach (string s in names)
                {
                    file1.WriteLine(s);
                    textBox2.Text += s;
                    textBox2.Text += Environment.NewLine;
                }
            }

        }
    }
}
