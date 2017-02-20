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
    public partial class Towns : Form
    {
        SqlConnection currentconnection;

        public Towns(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void GetTowNames()
        {
            string command = "Select name from towns";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        comboBox1.Items.Add(reader[i]);
                    }
                }
            }

            comboBox1.SelectedIndex = 0;
        }

        private void Towns_Load(object sender, EventArgs e)
        {
            GetTowNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = $"Insert into Towns values ('{textBox1.Text}')";
            SqlCommand com = new SqlCommand(command, currentconnection);
            com.ExecuteNonQuery();

            MessageBox.Show($"Town {textBox1.Text} added to towns");

        }
    }
}
