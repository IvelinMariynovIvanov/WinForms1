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
    public partial class Employees : Form
    {
        SqlConnection currentconnection;

        public Employees(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = $"select e.FirstName,LastName from Employees as e inner join Departments as d on e.EmployeeID = d.ManagerID where d.name = '{comboBox1.SelectedItem}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    textBox5.Text =reader[0] + " "+ reader[1];
                }
            }
          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetDepartmentsNames();

        }



        private void GetDepartmentsNames()
        {
            string command = "Select name from departments";
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
            int dId = 0;
            int mId = 0;
            GetDepartmentAndManagerIds(out dId, out mId);

            string command = string.Format($"Insert into employees values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}',{dId},{mId},'{textBox6.Text}',{textBox7.Text},166)");
            SqlCommand com = new SqlCommand(command, currentconnection);

            com.ExecuteNonQuery();


        }

        private void GetDepartmentAndManagerIds(out int departmentId, out int managerID)
        {
             departmentId = 0;
             managerID = 0;

            string command =
                $"Select departmentId,managerId from departments where name = '{comboBox1.SelectedItem.ToString()}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    departmentId = (int)reader[0];
                    managerID = (int)reader[1];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
