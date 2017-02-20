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
    public partial class Addresses : Form
    {
        SqlConnection currentconnection;

        public Addresses(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addressescs_Load(object sender, EventArgs e)
        {
            GetTowNames();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string addedAddres = textBox1.Text;

            if (!IsAddresExistMethod(addedAddres))
            {
                int tId = 0;
                GetTownId(out tId);

                string command = $"Insert into Addresses values ('{textBox1.Text}', {tId})";
                SqlCommand com = new SqlCommand(command, currentconnection);

                com.ExecuteNonQuery();    
                MessageBox.Show($"Address {textBox1.Text} is added to town {comboBox1.SelectedItem.ToString()}");
            }
            else
            {
                MessageBox.Show
                    ($"Address {textBox1.Text} already exist in town {comboBox1.Text.ToString()}",
                    "error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private bool IsAddresExistMethod(string IsAddressExist)
        {
            string command1 = $"select addressText from addresses";
            SqlCommand com1 = new SqlCommand(command1, currentconnection);
            SqlDataReader reader1 = com1.ExecuteReader();

            using (reader1)
            {
                while (reader1.Read())
                {
                   if (IsAddressExist == (string)reader1[0])
                    {
                        return true;
                    }    
                } 
            }

            return false;
        }

        private void GetTownId(out int townId)
        {
            townId = 0;

            string command = $"select townId from Towns where name = '{comboBox1.SelectedItem.ToString()}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    townId = (int)reader[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
