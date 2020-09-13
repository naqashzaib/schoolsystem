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
using System.Threading;
namespace studentmanagementsystem
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string user, pass;

        private string c = "Data Source=.; Initial Catalog=school_system; Integrated Security = SSPI; ";
        SqlConnection objcon;
        SqlCommand objcomm;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();             
            txtpassword.UseSystemPasswordChar = true;
            txtusername.Focus();
        }       
        public void metroButton1_Click(object sender, EventArgs e)
        { 
                try
                {
                    objcon = new SqlConnection(c);                 
                    if (txtusername.Text.Trim() == string.Empty || txtpassword.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Uername And password is Requried..!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtusername.Focus();                     
                    }
                    else
                    {
                        objcon.Open();
                        objcomm = new SqlCommand("select * from Login_apna where UserName='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'", objcon);
// ReSharper disable SuggestUseVarKeywordEverywhere
                        SqlDataReader sdr = objcomm.ExecuteReader();
// ReSharper restore SuggestUseVarKeywordEverywhere
                        if (sdr.Read())
                        {                            
                            user = sdr["UserName"].ToString();
                            pass = sdr["password"].ToString();                       
                            if (txtusername.Text == user && txtpassword.Text == pass)
                            {
                                MessageBox.Show("You have A Successful Login..!");
                                dashborad d = new dashborad();
                                //d.getuser = user;                                    
                                d.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("invalid User Or Password..!", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("invalid user...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        objcon.Close();
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }               
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {                     
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                forget_form fg = new forget_form();
                fg.Show();
                this.Hide();   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }
        private void txtusername_Click(object sender, EventArgs e)
        {
        }
        private void txtpassword_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "User Name")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.White;
            }
        }
        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "User Name";
                txtusername.ForeColor = Color.White;
            }
        }
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.White;
            }
        }
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.White;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                objcon = new SqlConnection(c);
                if (txtusername.Text.Trim() == string.Empty || txtpassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Uername And password is Requried..!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }
                else
                {
                    objcon.Open();
                    objcomm = new SqlCommand("select * from Login_apna where UserName='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'", objcon);
                    // ReSharper disable SuggestUseVarKeywordEverywhere
                    SqlDataReader sdr = objcomm.ExecuteReader();
                    // ReSharper restore SuggestUseVarKeywordEverywhere
                    if (sdr.Read())
                    {
                        user = sdr["UserName"].ToString();
                        pass = sdr["password"].ToString();
                        if (txtusername.Text == user && txtpassword.Text == pass)
                        {
                            MessageBox.Show("You have A Successful Login..!");
                            dashborad d = new dashborad();
                            //d.getuser = user;                                    
                            d.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("invalid User Or Password..!", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid user...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    objcon.Close();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtusername.Focus();
        }
    }
}
