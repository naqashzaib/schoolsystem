using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentmanagementsystem
{
    public partial class forget_form : MetroFramework.Forms.MetroForm
    {
        public forget_form()
        {
            InitializeComponent();
        }
        private string c = "Data Source=.; Initial Catalog=school_system; Integrated Security = SSPI; ";

        SqlConnection objcon;

        SqlCommand objcomm;
        SqlCommandBuilder objscb;
        SqlDataAdapter objadp;
        DataSet dset;
        private void forget_form_Load(object sender, EventArgs e)
        {
        }
        private void btnsend_Click_1(object sender, EventArgs e)
        {
            objcon = new SqlConnection(c);
            objcon.Open();
            objcomm = new SqlCommand("select * from Login_apna where Email='" + txtemail.Text + "'", objcon);
            SqlDataReader sdr2 = objcomm.ExecuteReader();
            if (sdr2.Read())
            {
                string ps, un;
                un = sdr2["UserName"].ToString();
                ps = sdr2["Password"].ToString();
                string emailTo = txtemail.Text;
                string subject = "Password Recovery";
                string body = "Your Username is : " + un + "\r\n" + " And Your new password is : " + ps;
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("naqashzaib5@gmail.com", "naqq11255");
                MailMessage mm = new MailMessage(emailTo, emailTo, subject, body);               
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(mm);
                MessageBox.Show("Your Password Send Your E-mail..!");

            }
            else
            {
                MessageBox.Show("Invalid Email..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Enter Email")
            {
                txtemail.Clear();
                txtemail.ForeColor = Color.Black;
            }           
        }
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                errorProvider1.SetError(txtemail, "Enter The E-mail Example@gmail.com");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm logn = new LoginForm();
            logn.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
