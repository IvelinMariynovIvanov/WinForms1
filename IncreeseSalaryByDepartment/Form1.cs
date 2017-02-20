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

namespace IncreeseSalaryByDepartment
{
    public partial class Form1 : Form
    {
        SqlConnection currentconnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = 
                "server = ivelin-pc; database =softuni; trusted_connection=true";
            currentconnection = new SqlConnection(connectionString);

            currentconnection.Open();

            string command = "Select Name from Departments";
            SqlCommand com = new SqlCommand(command,currentconnection);
            SqlDataReader read = com.ExecuteReader();

            using (read)
            {
                while (read.Read())
                {
                    cmDepartment.Items.Add(read[0]);
                }
            }
            cmDepartment.SelectedIndex = 0;
        }

        private void bnUpdate_Click(object sender, EventArgs e)
        {
           decimal number = 0;
           if( decimal.TryParse(txtNumber.Text, out number))
            {
                string increaseOrDecrease = null;
                if (rbIncrease.Checked == true)
                {
                    increaseOrDecrease = "+";
                }
                else
                    increaseOrDecrease = "-";

                string howToUpdate = null;
                decimal percentage = 0;

                if (RbValue.Checked == true)
                {
                    howToUpdate = txtNumber.Text;
                }
                else
                {
                    percentage = decimal.Parse(txtNumber.Text) / 100;
                    howToUpdate = $" Salary * {percentage}"; /////////
                }

                string command = $"Update Employees set salary = Salary{increaseOrDecrease}{howToUpdate} from Employees inner join Departments on Employees.DepartmentId =Departments.DepartmentId where Departments.Name = '{cmDepartment.SelectedItem.ToString()}'";
                SqlCommand com = new SqlCommand(command, currentconnection);
                com.ExecuteNonQuery();

                MessageBox.Show($"The salary of department {cmDepartment.Text} has been upadated");
            }
           else
            {
                MessageBox.Show("Enter a valid decimal number");
            }

                    
        }
    }
}
