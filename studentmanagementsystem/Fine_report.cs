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
namespace studentmanagementsystem
{
    public partial class Fine_report : MetroFramework.Forms.MetroForm
    {
        public Fine_report()
        {
            InitializeComponent();
        }
     
 public string c = "Data Source=.; Initial Catalog=school_system; Integrated Security = SSPI; ";
        public SqlConnection objcon;
        public SqlCommand objcomm;
        public SqlDataAdapter objadp;
        public DataSet dset;
        private void unpaid_fee_report_Load(object sender, EventArgs e)
        {

        }
    }
}
