using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Projects : Form
    {
        SqlConnection currentconnection;

        public Projects(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = $"Insert into Projects values('{textBox1.Text}', '{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')";
            SqlCommand com = new SqlCommand(command, currentconnection);
            com.ExecuteNonQuery();

            MessageBox.Show($"Project {textBox1.Text} has been added to Projects");
        }
    }
}
