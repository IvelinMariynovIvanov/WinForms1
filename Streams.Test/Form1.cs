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

namespace Streams.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if(result == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName);
                using (reader)
                {
                    string currentLine = reader.ReadLine();
                    textBox1.Text =
                        textBox1.Text +
                        currentLine +
                        Environment.NewLine;

                    currentLine = reader.ReadLine();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
