using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5Radiobutton
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

       

        public string FirstName
        {
            get;

            set;
        }

        public string MidleName
        {
            get;

            set; 
        }

        public string LasttName
        {
            get;

            set;
           
        }

        public string Genderr
        {
            get;

            set;
           
        }

        public string WorkingDayy
        {
            get;

            set;
         
        }

        public string Contractt
        {
            get;


            set;
           
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void WorkingDay_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            FirstName = textBox1.Text;
            MidleName = textBox2.Text;
            LasttName = textBox3.Text;

            ShowEmployeeInformation fm2 = new ShowEmployeeInformation(this);
            fm2.ShowDialog();

        }

        private void Male_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            if(Female.Checked ==true)
            {
                Genderr = Female.Text;
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Male.Checked == true)
            {
                Genderr = Male.Text;
            }
        }

        private void FullDay_CheckedChanged(object sender, EventArgs e)
        {
            if(FullDay.Checked == true)
            {
                WorkingDayy = FullDay.Text;
            }
        }

        private void PartDay_CheckedChanged(object sender, EventArgs e)
        {
            if(PartDay.Checked == true)
            {
                WorkingDayy = PartDay.Text;
            }
        }

        private void Civil_CheckedChanged(object sender, EventArgs e)
        {
            if(Civil.Checked == true)
            {
                Contractt = Civil.Text;
            }
        }

        private void FullTime_CheckedChanged(object sender, EventArgs e)
        {
            if(FullTime.Checked == true)
            {
                Contractt = FullTime.Text;
            }
        }
    }
}
