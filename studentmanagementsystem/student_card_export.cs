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
    public partial class student_card_export : MetroFramework.Forms.MetroForm
    {
        public student_card_export()
        {
            InitializeComponent();
        }

        private void student_card_export_Load(object sender, EventArgs e)
        {
            AllStudent();
        }

        string cs = ConfigurationManager.ConnectionStrings["student"].ConnectionString;
        public SqlConnection objcon;
        public SqlCommand objcomm;
        public SqlDataAdapter objad;
        public DataTable dset;
        public void AllStudent()
        {

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "select * from addstudent";
                objad = new SqlDataAdapter(command.CommandText, connection);
                objad.SelectCommand.Transaction = transaction;
                dset = new DataTable();
                objad.Fill(dset);
                txtstudentname.DisplayMember = "s_name";
                txtstudentname.ValueMember = "s_id";


                txtstudentname.DataSource = dset;


                DataTable dset2= new DataTable();
                objad.Fill(dset2);
            

                txtfrom.DisplayMember = "s_rollno";
                txtfrom.ValueMember = "s_id";
                txtfrom.DataSource = dset2;

                DataTable dset3 = new DataTable();
                objad.Fill(dset3);

                txtto.DisplayMember = "s_rollno";
                txtto.ValueMember = "s_id";

                txtto.DataSource = dset3;



                transaction.Commit();
            }
        }

        private void btnexportall_Click(object sender, EventArgs e)
        {
            EportCard("All");
        }
        viewreport objcrtysleview = new viewreport();
       public void EportCard(string requesttype)
       {

           try
           {
               string getquyer = "";
               if (requesttype == "FormTo")
               {
                   getquyer = "where s_rollno between '" + txtfrom.Text + "' and '" + txtto.Text + "'  ";
               }
               else if (requesttype == "Single")
               {
                   //getquyer = "where s_id='" + txtstudentname.SelectedValue.ToString() + "'  ";
                   getquyer = "where s_id='" + txtstudentname.SelectedValue.ToString() + "' ";

               }
               else
               {
                   getquyer = " ";
               }

               viewreport veallrep = new viewreport();
               veallrep.Loadreport = getquyer;
               veallrep.ShowDialog();


           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }
       }
       private void btnfromtowise_Click(object sender, EventArgs e)
       {

           if (Convert.ToInt32(txtto.Text) < Convert.ToInt32(txtfrom.Text))
           {
               MessageBox.Show("Please Enter Search To Roll # Select Greater Than Foam Roll #!");
               return;
           }

           EportCard("FormTo");

       }

       private void btnsingalwise_Click(object sender, EventArgs e)
       {
           EportCard("Single");

       }

       private void txtstudentname_TextChanged(object sender, EventArgs e)
       {
           foreach (DataRow rdr in dset.Rows)
           {
               if (Convert.ToInt32(rdr["s_id"].ToString()) == Convert.ToInt32(txtstudentname.SelectedValue.ToString()))
             {
                 txtrollno.Text = rdr["s_rollno"].ToString();
             }
              
           }

       }
    }
}
