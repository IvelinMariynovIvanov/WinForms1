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

namespace WindowsFormsApplication1
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
            button2.Enabled = false;
 
        }

        private bool UnlockButton()
        {
            bool result = Write_DataBase_Name.Text.Trim().Length > 0 &&
                          write_server_name.Text.Trim().Length > 0;
            return result;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // button2.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string connetionString = null;
            SqlConnection cnn;
            connetionString = $"Server = {write_server_name.Text}; Database = {Write_DataBase_Name.Text}; Trusted_Connection = True";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                GenerateTableNames(cnn);
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

       private  void GenerateTableNames(SqlConnection cnn)
        {
            string command = "Select name from sys.tables";
            SqlCommand comand = new SqlCommand(command, cnn);
            SqlDataReader reader= comand.ExecuteReader();

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

        private void textServer_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = UnlockButton();
        }

      

        private void Write_DataBase_Name_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = UnlockButton();
        }
    }
}

       
     

