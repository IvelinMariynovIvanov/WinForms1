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

namespace WindowsFormsMinMaxsalaryUpdate
{
    public partial class UpdateSalary : Form
    {
        SqlConnection currentConnection;

        public UpdateSalary()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UpdateEmployyesSalary fm1 = new UpdateEmployyesSalary(currentConnection);
            //fm1.ShowDialog();

            decimal minSalary;
            if(!decimal.TryParse(this.minSalary.Text, out minSalary))
            {
                MessageBox.Show($"Min salary {this.minSalary.Text} must be a valid decimal number");
            }
            

            decimal maxSalary;
            if(!decimal.TryParse(this.maxSalary.Text, out maxSalary))
            {
                MessageBox.Show($"Max salary {this.maxSalary.Text} must be a valid decimal number");
            }

            if(minSalary < maxSalary)
            {

                string command =
                    $"Select firstName,lastName from Employees where Salary between '{this.minSalary.Text}' and '{this.maxSalary.Text}'";
                SqlCommand com = new SqlCommand(command, currentConnection);
                SqlDataReader reader = com.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        // comboBox1.Items.Add(reader[i]);
                        comboBox1.Items.Add(reader[0] + " " + reader[1]);
                    }
                }

                if (comboBox1.Items.Count != 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show($"There are no  employees with salary between {this.minSalary.Text} and {this.maxSalary.Text}",
                        "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show($"Min salary {this.minSalary.Text} must be smaller than max salary {this.maxSalary.Text}",
                        "Error", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionstring = 
                "Server = ivelin-pc; Database = SoftUni; Trusted_Connection = True";
             currentConnection = new SqlConnection (connectionstring);

            currentConnection.Open();
            button1.Enabled = false;
        }

        private bool UnclockButton()
        {
            bool result = minSalary.Text.Trim().Length > 0 &&
                          maxSalary.Text.Trim().Length > 0;

            return result;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = UnclockButton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = UnclockButton();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] currentEmployeeName = comboBox1.SelectedItem.ToString().Split(' ');
            string firstEmName = currentEmployeeName[0];
            string lastEmName = currentEmployeeName[1];

            string command = $"Select Salary from Employees where firstName = '{firstEmName}' and lastName = '{lastEmName}'";
            SqlCommand com = new SqlCommand(command, currentConnection);

            //com.ExecuteScalar();

            currentEmployeeSalary.Text = com.ExecuteScalar().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal newSalary;

            if( decimal.TryParse(newEmployeeSalary.Text, out newSalary) == true)
            {
                string[] currentEmployeeName = comboBox1.SelectedItem.ToString().Split(' ');
                string firstEmName = currentEmployeeName[0];
                string lastEmName = currentEmployeeName[1];

                string command = $"Update Employees set salary = {newSalary} where firstName = '{firstEmName}' and lastName = '{lastEmName}'";
                SqlCommand com = new SqlCommand(command, currentConnection);

                com.ExecuteScalar();

                MessageBox.Show($"{firstEmName} {lastEmName}'s salary has been changed to {newEmployeeSalary.Text}");
            }
            else
            {
                MessageBox.Show("Enter a valid decimal numer");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
