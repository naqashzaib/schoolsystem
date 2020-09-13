using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using studentmanagementsystem.Reports;


namespace studentmanagementsystem
{
    public partial class exportteacherfineabsentview : Form
    {
        public exportteacherfineabsentview()
        {
            InitializeComponent();
        }
        public string teacherperabsent, formdate, todate;
        private void exportteacherfineabsentview_Load(object sender, EventArgs e)
        {

        }
    }
}
