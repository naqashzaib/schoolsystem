using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

namespace studentmanagementsystem
{
    public partial class Datarecover : MetroFramework.Forms.MetroForm
    {
        public Datarecover()
        {
            InitializeComponent();
        }
        string c = "Data Source=.; Initial Catalog=apnastore; Integrated Security = SSPI; ";
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadp;
        DataSet dset;
        private void Datarecover_Load(object sender, EventArgs e)
        {
            cmdatabase.Enabled = false;
            btnbackup.Enabled = false;
            //btnrestore.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                objcon = new SqlConnection(c);
                objcon.Open();
                objcomm =new SqlCommand("Select * from sys.databases d where d.database_id>4",objcon);
                SqlDataReader dtr;
                dtr = objcomm.ExecuteReader();
                cmdatabase.Items.Clear();
                while (dtr.Read())
                {
                    cmdatabase.Items.Add(dtr[0].ToString());
                }
                objcon.Close();
                cmdatabase.Enabled = true;
                btnbackup.Enabled = true;
                btnrestore.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btndis.Enabled = true;
            cmdatabase.Enabled = false;
            btnbackup.Enabled = false;
            btnrestore.Enabled = false;
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmdatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please Select a Daatabase");
                    return;
                }
                objcon = new SqlConnection(c);
                objcon.Open();
                objcomm =
                    new SqlCommand(
                        "BACKUP DATABASE " + cmdatabase.Text +" TO DISK ='" + txtlocation.Text + "\\" + cmdatabase.Text +
                        "-" + DateTime.Now.Ticks.ToString() + ".bak'", objcon);
                objcomm.ExecuteNonQuery();
                MessageBox.Show("Successfully Database Backup Completed..!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                txtlocation.Text = fbd.SelectedPath;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtres.Text = ofd.FileName;
            }
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmdatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please Select a Database..!");
                    return;
                    
                }

                SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=master;Integrated Security=True");
                con.Close();
                con.Open();
                string sql = "";
                sql = "ALTER Database " + cmdatabase.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database " + cmdatabase.Text + " FROM Disk ='" + txtres.Text + "'WITH REPLACE;";     
                SqlCommand command = new SqlCommand(sql, con);                //objcomm = new SqlCommand("RESTORE database'++'", objcon);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Restore Database");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
