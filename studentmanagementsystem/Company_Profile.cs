using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class Company_Profile : MetroFramework.Forms.MetroForm
    {
        public Company_Profile()
        {
            InitializeComponent();
        }
        public string CorrectFileName, supdatepic;

        private void Company_Profile_Load(object sender, EventArgs e)
        {
            GetCompanyInfo();
        }

        public void GetCompanyInfo()
        {
            try
            {
                string company_name,company_logo,company_email,company_phone_no;
                string cs = "data source = .; Initial Catalog = school_system ; Integrated Security = SSPI ;";
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;

                    command.CommandText = "select * from company_info";
                    SqlDataAdapter objadp3 = new SqlDataAdapter(command.CommandText, connection);
                    objadp3.SelectCommand.Transaction = transaction;
                    DataTable dta3 = new DataTable();
                    objadp3.Fill(dta3);
                    foreach (DataRow dtrow3 in dta3.Rows)
                    {
                        company_name = dtrow3["company_name"].ToString();
                      company_logo = dtrow3["company_logo"].ToString();
                      company_email = dtrow3["company_email"].ToString();
                      company_phone_no = dtrow3["company_phone_no"].ToString();

                      supdatepic = company_logo;
                      if (supdatepic != null && supdatepic != "")
                          pictureBox3.Load(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) +
                                           @"\pics\" + supdatepic);




                        txtcompany_name.Text = company_name;
                        txtcompany_email.Text = company_email;
                        txtcompany_phone_no.Text = company_phone_no;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeps| *.jpg|Bitmaps | *.bmp| png| *.png ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.CheckFileExists)
                {
                    try
                    {
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        CorrectFileName = Path.GetFileName(openFileDialog.FileName);
                        //CorrectFileName = txtPid.Text + CorrectFileName;
                        string[] name = CorrectFileName.Split('.');
                        Random rnd = new Random();
                        // creates a number between 1 and 6
                        int card = rnd.Next(999);
                        CorrectFileName = name[0] + card.ToString() + "." + name[1];
                        File.Copy(openFileDialog.FileName, paths + @"\pics\" + CorrectFileName);
                        pictureBox3.ImageLocation = openFileDialog.FileName;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This File Name Is Already Exists, Please Upload Another Pic By Diffferent Name");
                    }

                }


            }
        }

        private void txtsinsert_Click(object sender, EventArgs e)
        {
            try
            {
                string company_name, company_logo, company_email, company_phone_no;
                string cs = "data source = .; Initial Catalog = school_system ; Integrated Security = SSPI ;";
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;
                    string getpicvlaue = "";
                    if (CorrectFileName == "" || CorrectFileName==null)
                    {
                        getpicvlaue = supdatepic;
                    }
                    else
                    {
                        getpicvlaue = CorrectFileName;

                    }
                    command.CommandText = "update company_info set  company_name='" + txtcompany_name.Text + "',company_logo='" + getpicvlaue + "',company_email='" + txtcompany_email.Text + "',company_phone_no='" + txtcompany_phone_no.Text + "' where company_id=1";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Company Profile Info Saved");
                    
                    GetCompanyInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtcompany_email_Leave(object sender, EventArgs e)
        {
             if (!Regex.IsMatch(txtcompany_email.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
            {
                errorProvider1.SetError(txtcompany_email, "Plz Enter Email in  Correct Format");
                txtcompany_email.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
