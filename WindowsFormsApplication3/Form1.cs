using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingList<string> listCollection = new BindingList<string>();

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //  BindingSource bs = new BindingSource();
            //   bs.DataSource = listCollection;
            //   comboBox1.DataSource = bs;

            bn1Add.Enabled = false;

            listCollection.Add("ivo");
            listCollection.Add("rali");

            comboBox1.DataSource = listCollection;
            comboBox1.SelectedIndex = 0; 
        }

        private bool UnlockButton()
        {
            bool result = textBox1.Text.Trim().Length > 0;
            return result;
        }

        private void bn1Add_Click(object sender, EventArgs e)
        {

            string addText = textBox1.Text;
            if (!listCollection.Contains(addText))
            {
                listCollection.Add(addText);
            }
            else
            //MessageBox.Show($"{addText}  already exist");
            {
                MessageBox.Show($"{addText} already exist",
                "error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            textBox1.Clear();

            button1.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bn1Add.Enabled = UnlockButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string removeText = textBox1.Text;
            if (listCollection.Contains(removeText))
            {
                listCollection.Remove(removeText);
            }
            else
            //MessageBox.Show($"{addText}  already exist");
            {
                MessageBox.Show($"{removeText} does no exist",
                "error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCollection.Remove(comboBox1.SelectedItem.ToString());
            button1.Enabled = UnlockButton1();
        }

        private bool UnlockButton1()
        {
            bool result = comboBox1.Text.Trim().Length > 0;
            return result;
        }
    }
}
