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

namespace StreamsWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                button2.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            StreamWriter sw = new StreamWriter(ofd.FileName,true);

            using (sw)
            {
                sw.WriteLine($"{textBox1.Text}");
                MessageBox.Show($"Text has been written to file {ofd.FileName}");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            textBox1.Clear();
        }
    }
}
