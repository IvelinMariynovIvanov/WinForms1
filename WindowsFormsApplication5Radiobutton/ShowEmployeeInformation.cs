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
    public partial class ShowEmployeeInformation : Form
    {
        AddEmployee fm1;

        public ShowEmployeeInformation(AddEmployee fm2)
        {
            InitializeComponent();
            this.fm1 = fm2;
        }

        private void ShowEmployeeInformation_Load(object sender, EventArgs e)
        {
            textBox1.Text = fm1.FirstName;
            textBox2.Text = fm1.MidleName;
            textBox3.Text = fm1.LasttName;
            textBox4.Text = fm1.Genderr;
            textBox5.Text = fm1.WorkingDayy;
            textBox6.Text = fm1.Contractt;

        }
    }
}
