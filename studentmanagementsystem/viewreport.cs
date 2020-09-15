using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    public partial class viewreport : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["student"].ConnectionString;

        public viewreport()
        {
            InitializeComponent();
        }
        public SqlConnection objcon;
        public SqlCommand objcomm;
        public SqlDataAdapter objad;
        public DataTable dset;

        public string Loadreport { get; set; }


        private void viewreport_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            feevochar showstu = new feevochar();
            crystalReportViewer1.RefreshReport();
            showstu.Refresh();
            showstu.SetParameterValue("getquyerstring", Convert.ToString(Loadreport));
            crystalReportViewer1.ReportSource = showstu;    
        }
        private void showreport(string report)
        {
            try
            {
                crystalReportViewer1.RefreshReport();
                ReportDocument rtc = new ReportDocument();
                string apppath, reportpath, fullpath;
                apppath = Application.StartupPath;
                reportpath = report;
                fullpath = Path.Combine(apppath, reportpath);
                rtc.Load(fullpath);
                crystalReportViewer1.ReportSource = rtc;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //private void showreport(string getquery)
        //{
        //    try
        //    {
        //        ReportDocument rtc = new ReportDocument();
        //        string apppath, reportpath, fullpath;
        //        apppath = Application.StartupPath;
        //        reportpath = report;
        //        fullpath = Path.Combine(apppath, reportpath);
        //        rtc.Load(fullpath);
        //        crystalReportViewer1.RefreshReport();
        //        crystalReportViewer1.ReportSource = rtc;
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }




        //    try
        //    {
        //        feevochar showtec = new feevochar();
        //        showtec.SetParameterValue("getquerystring", Convert.ToString(getquery));
        //        crystalReportViewer1.ReportSource = showtec; 
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
