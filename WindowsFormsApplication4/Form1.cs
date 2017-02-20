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
using WindowsFormsApplication4.Remove;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        SqlConnection currentconnection;
        int result;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            this.currentconnection = currentconnection;

        }

        private bool UnlockButton1()
        {
            bool result = textBox1.Text.Trim().Length > 0 &&
                          textBox2.Text.Trim().Length > 0;

            return result;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString =
                $"Server = IVELIN-PC; Database = SoftUni; Trusted_Connection = True";
              //  $"server ={textBox1.Text};database = {textBox2.Text};trusted_connection = true";

            currentconnection = new SqlConnection(connectionString);

            try
            {
                currentconnection.Open();
                MessageBox.Show($"connected to {textBox2.Text}");
                GeneraTableNames(currentconnection);

                button2.Enabled = true;
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong database or server name");
            }
        }

        private void GeneraTableNames(SqlConnection connection)
        {
            
            string command = "select name from sys.tables";
            SqlCommand com = new SqlCommand(command, connection);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = UnlockButton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = UnlockButton1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = $"Select count(*) from {comboBox1.Text}";
            SqlCommand com = new SqlCommand(command, currentconnection);

            var result= com.ExecuteScalar();

            label3.Text = "Number of records: " + result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentconnection.Close();
            MessageBox.Show($" Disconnected from {textBox2.Text}");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            label3.Text = "Number of records ";
           

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Enter(object sender, EventArgs e)
        {
          //  button2.Enabled = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button2.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string whichTableToSelect = comboBox1.SelectedItem.ToString();
            if(whichTableToSelect == "Employees")
            {
                Employees fm2Employees = new Employees(currentconnection);
                fm2Employees.ShowDialog();
            }
            else if(whichTableToSelect == "Addresses")
            {
                Addresses fm3Addresses = new Addresses(currentconnection);
                fm3Addresses.ShowDialog();
            }
            else if(whichTableToSelect == "Towns")
            {
                Towns fm4Towns = new Towns(currentconnection);
                fm4Towns.ShowDialog();
            }
            else if (whichTableToSelect == "Projects")
            {
                Projects fm5Projects = new Projects(currentconnection);
                fm5Projects.ShowDialog();
            }
            else if(whichTableToSelect == "Departments")
            {
                Departments fm6Departments = new Departments(currentconnection);
                fm6Departments.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //removeProjects fm1removeProjects = new removeProjects(currentconnection);
            //fm1removeProjects.ShowDialog();

            RemoveTowns fm2RemoveTowns = new RemoveTowns(currentconnection);
            fm2RemoveTowns.ShowDialog();
        }
    }
}
