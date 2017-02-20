using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4.Remove
{
    public partial class RemoveTowns : Form
    {
        SqlConnection currentconnection;

        public RemoveTowns(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveTowns_Load(object sender, EventArgs e)
        {
            string command = $"Select Name from Towns";
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

        }

        private void GetTownId(out int tonwId)
        {
            tonwId = 0;

            string command = $"Select TownId from Towns where Name = '{comboBox1.SelectedItem.ToString()}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    tonwId = (int)reader[0];
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int tId = 0;
            GetTownId(out tId);

            RemoveTonwfromAddresses(tId);

            string command = $"Delete from Towns where  TownId = {tId}";
            SqlCommand com = new SqlCommand(command, currentconnection);
            com.ExecuteNonQuery();

            MessageBox.Show($"Town {comboBox1.SelectedItem.ToString()} has been removed from towns");

        }

        private void RemoveTonwfromAddresses(int tId)
        {
            string command = $"Delete from Addresses where  TownId = {tId}";
            SqlCommand com = new SqlCommand(command, currentconnection);
            com.ExecuteNonQuery();
        }
    }
}
