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

namespace WindowsFormsApplication4.Remove
{
    public partial class removeProjects : Form
    {
        SqlConnection currentconnection;

        public removeProjects(SqlConnection currentconnection)
        {
            InitializeComponent();
            this.currentconnection = currentconnection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pId = 0;
            string removeProject = comboBox1.SelectedItem.ToString();
     
                GetProjectId(out pId);

                string command = $"Delete from EmployeesProjects where ProjectID = {pId}";
                SqlCommand com = new SqlCommand(command, currentconnection);

                com.ExecuteNonQuery();
                MessageBox.Show($"Project {comboBox1.SelectedItem.ToString()} has been removed from to Projects");
  
        }

        private void GetProjectId(out int projectId)
        {
            projectId = 0;

            string command = $"Select p.ProjectId from Projects as p where p.Name = '{comboBox1.SelectedItem.ToString()}'";
            SqlCommand com = new SqlCommand(command, currentconnection);
            SqlDataReader reader = com.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    projectId = (int)reader[0];
                }
            }

        }


        private void Projects_Load(object sender, EventArgs e)
        {
            string command = $"Select Name from Projects";
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
    }
}
