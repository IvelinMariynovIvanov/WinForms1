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

namespace WindowsFormsApplication4
{
    public partial class Departments : Form
    {
        SqlConnection currentconnection;

        public Departments(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            GetDepartmentNames();

            GetManagersNames();
        }

        private void GetDepartmentNames()
        {
            string command = $"Select Name from Departments";
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

        private void GetDepartmentId(out int departmentId)
        {
            departmentId = 0;

            string command = $"Select e.EmployeeId from Employees as e where e.FirstName = '{comboBox2.Text}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    departmentId = (int)reader[0];
                }
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = $"select e.FirstName,e.LastName from Employees as e inner join Departments as d on e.EmployeeID = d.ManagerID where d.name = '{comboBox1.SelectedItem}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    textBox2.Text = reader[0] + " " + reader[1];
                }
            }
        }

        private void GetManagersNames()
        {
            string command = $"Select e.firstName, e.lastName from Employees as e";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        comboBox2.Items.Add(reader[i]);
                    }
                }

                comboBox2.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dId = 0;
            GetDepartmentId(out dId);

            string command = $"Insert into Departments values('{textBox1.Text}',{dId})";
            SqlCommand com = new SqlCommand(command, currentconnection);

            com.ExecuteNonQuery();

            MessageBox.Show($"Department {textBox1.Text} has been added to Departments");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int dId = 0;
            string addedDeparment = textBox1.Text;

            if(!IsDepartmentsExist(addedDeparment))
            {
                GetDepartmentId(out dId);

                string command = $"Insert into Departments values('{textBox1.Text}',{dId})";
                SqlCommand com = new SqlCommand(command, currentconnection);

                com.ExecuteNonQuery();
                MessageBox.Show($"Department {textBox1.Text} has been added to Departments");
            }
            else
            {
               MessageBox.Show($"Department {textBox1.Text} already exists in Departments {comboBox2.Text.ToString()}",
                    "error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool IsDepartmentsExist(string department)
        {
            string command1 = $"Select Name from Departments";
            SqlCommand com1 = new SqlCommand(command1, currentconnection);
            SqlDataReader reader1 = com1.ExecuteReader();

            using (reader1)
            {
                while (reader1.Read())
                {
                    if (department == (string)reader1[0])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
