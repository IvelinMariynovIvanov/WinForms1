using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var result1 = MessageBox.Show("Ivo shte mi pomognesh li da prostra charshafite?", "pls", MessageBoxButtons.YesNo);
            //if (result1== DialogResult.Yes)
            //{
            //    MessageBox.Show("Bravo");
            //}else
            //{
            //    MessageBox.Show("Ne ochakvam nishto i pak sym razhocharovan");
            //}
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();
            if (result== DialogResult.OK)
            {
                var streamReader = new StreamReader(openFileDialog.FileName);
                using (streamReader)
                {
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        textBox1.Text = textBox1.Text+
                            line + Environment.NewLine;

                        line = streamReader.ReadLine();
                    }
                }

                using(var streamWriter = new StreamWriter(openFileDialog.FileName, true))
                {
                    streamWriter.WriteLine("Nov red 1");
                    streamWriter.WriteLine("Nov red 2");
                }
            }
        }
    }
}
