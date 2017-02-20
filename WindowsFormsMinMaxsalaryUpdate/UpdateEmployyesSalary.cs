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
    public partial class UpdateEmployyesSalary : Form
    {
        SqlConnection currentConnection;

        public UpdateEmployyesSalary(SqlConnection currentConnection)
        {
            InitializeComponent();
            this.currentConnection = currentConnection;
        }

        private void UpdateEmployyesSalary_Load(object sender, EventArgs e)
        {
            
        }
    }
}
