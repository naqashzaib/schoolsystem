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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace studentmanagementsystem
{
    public partial class Add_Student : MetroFramework.Forms.MetroForm
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        public string c = "data source = .; Initial Catalog = school_system ; Integrated Security = SSPI ;";
        public SqlConnection objcon;
        public SqlCommand objcomm;
        public SqlDataAdapter objad;
        public DataSet dset;
        public string CorrectFileName,supdatepic,stuid;
        public string  mergroll;
        student_reoprt objStudentReoprt = new student_reoprt();
        public void funedit()
        {

            stueditrollnumber.Show();
            edit1.Show();
            metroTile9.Show();
            edit2.Show();
            edit3.Show();
            metroTile2.Show();
            metroTile11.Show();
            metroTile3.Show();
            edit8.Show();
            metroTile4.Show();
            metroTile5.Show();
            metroTile10.Show();
            metroTile6.Show();
            metroTile7.Show();
            metroTile8.Show();
            edit10.Show();
            edit11.Show();
            metroTile1.Show();
            label16.Hide();
            txts_id.Hide();


            txts_id.Enabled = false;
            txtsname.Enabled = false;
            txtlastname.Enabled = false;
            txtsfnam.Enabled = false;
            txtsgender.Enabled = false;
            txts_email.Enabled = false;
            txts_mobile_phone.Enabled = false;
            txts_home_phone.Enabled = false;
            txtsdob.Enabled = false;
            txts_street.Enabled = false;
            txts_city.Enabled = false;
            txts_state.Enabled = false;
            txts_zip_code.Enabled = false;
            txts_country.Enabled = false;
            txts_start_date.Enabled = false;
            team_id.Enabled = false;
            txts_ready_password.Enabled = false;
            txts_note.Enabled = false;


            txtsinsert.Hide();
            btnupdateteac.Show();
            btndeleteteac.Show();
            editstatusstudent.Show();
        }

        public void funsimple()
        {
            stueditrollnumber.Hide();
            edit1.Hide();
            metroTile9.Hide();
            edit2.Hide();
            edit3.Hide();
            metroTile2.Hide();
            metroTile11.Hide();
            metroTile3.Hide();
            edit8.Hide();
            metroTile4.Hide();
            metroTile5.Hide();
            metroTile10.Hide();
            metroTile6.Hide();
            metroTile7.Hide();
            metroTile8.Hide();
            edit10.Hide();
            edit11.Hide();
            metroTile1.Hide();
            label16.Hide();
            txts_id.Hide();


            txtsname.Enabled = true;
            txtlastname.Enabled = true;
            txtsfnam.Enabled = true;
            txtsgender.Enabled = true;
            txts_email.Enabled = true;
            txts_mobile_phone.Enabled = true;
            txts_home_phone.Enabled = true;
            txtsdob.Enabled = true;
            txts_street.Enabled = true;
            txts_city.Enabled = true;
            txts_state.Enabled = true;
            txts_zip_code.Enabled = true;
            txts_country.Enabled = true;
            txts_start_date.Enabled = true;
            team_id.Enabled = true;
            txts_ready_password.Enabled = true;
            txts_note.Enabled = true;
            txtsinsert.Show();

            btnupdateteac.Hide();
            btndeleteteac.Hide();
            editstatusstudent.Hide();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            label16.Hide();
            txts_id.Hide();

            timer2.Start();
            funsimple();
            getrollno();
            getteamname();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void getrollno()
        {
            using (SqlConnection connection = new SqlConnection(c))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "SELECT TOP 1 COALESCE( cast(s_rollno as float),0)+1 AS 'invoice_id' FROM addstudent ORDER BY s_id DESC";
                SqlDataAdapter objadp = new SqlDataAdapter(command.CommandText, connection);
                objadp.SelectCommand.Transaction = transaction;
                DataTable dta = new DataTable();
                objadp.Fill(dta);
                foreach (DataRow dtrow in dta.Rows)
                {
                    rollnos.Text = dtrow["invoice_id"].ToString();

                }


                transaction.Commit();
            }
        }
        public void getteamname()
        {
            using (SqlConnection connection = new SqlConnection(c))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "select * from team";
                SqlDataAdapter objadp3 = new SqlDataAdapter(command.CommandText, connection);
                objadp3.SelectCommand.Transaction = transaction;
                DataTable dta3 = new DataTable();
                objadp3.Fill(dta3);
                team_id.DisplayMember = "team_name";
                team_id.ValueMember = "team_id";
                team_id.DataSource = dta3;
                transaction.Commit();
            }
        }
     
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpeps| *.jpg|Bitmaps | *.bmp| png| *.png ";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        try
                        {
                            string date = DateTime.Now.ToString().Replace("/", "-").Replace(":", "").Replace(" ", "");      
                            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                            CorrectFileName = Path.GetFileName(openFileDialog.FileName);
                            CorrectFileName = rollnos.Text + date + pictureBox3.Text + CorrectFileName;
                            File.Copy(openFileDialog.FileName, paths + @"\pics\" + CorrectFileName);
                            pictureBox3.ImageLocation = openFileDialog.FileName;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("This File name is already Exists, Please Upload another pic by diffferent name");
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void srollcode_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtsroll_Leave(object sender, EventArgs e)
        {
            //if (txtsroll.Text.Trim() == "")
            //{
            //    errorProvider1.SetError(txtsroll, "Enter The Roll no.");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}

        }

        private void txtsname_Leave(object sender, EventArgs e)
        {
         

        }

        private void txtsfnam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsfnam_Leave(object sender, EventArgs e)
        {
            if (txtsfnam.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsfnam, "Enter Student's father Name.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtsgender_Leave(object sender, EventArgs e)
        {
            if (txtsgender.Text.Trim() == "")
            {
                txtsgender.Focus();
                errorProvider1.SetError(txtsgender, "Enter Student's Gender.");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void txtscnic_Leave(object sender, EventArgs e)
        {
        

        }

        private void txtfcnic_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtsdob_Leave(object sender, EventArgs e)
        {
         
        }

        private void txtsclass_Leave(object sender, EventArgs e)
        {
          

        }

        private void txtssection_Leave(object sender, EventArgs e)
        {
          

        }

        private void txtscntct_Leave(object sender, EventArgs e)
        {
          

        }

        private void txtssclnam_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtsaddres_Leave(object sender, EventArgs e)
        {
           

        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == ' ' || e.KeyChar == TabIndex)
            {
                string s = txtsname.Text;
                txtsname.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                txtsname.Select(txtsname.Text.Length, 0);
            }
        }

        private void txtsearchstudent_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void edit0_Click(object sender, EventArgs e)
        {

            rollnos.Enabled = true;
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            txtsname.Enabled = true;
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            txtsfnam.Enabled = true;
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            txtsgender.Enabled = true;
        }

        private void edit4_Click(object sender, EventArgs e)
        {
        }

        private void edit5_Click(object sender, EventArgs e)
        {
        }

        private void edit8_Click(object sender, EventArgs e)
        {
            txtsdob.Enabled = true;
        }

        private void edit9_Click(object sender, EventArgs e)
        {
        }

        private void edit10_Click(object sender, EventArgs e)
        {
            team_id.Enabled = true;
        }

        private void edit11_Click(object sender, EventArgs e)
        {
            txts_mobile_phone.Enabled = true;
        }

        private void edit6_Click(object sender, EventArgs e)
        {

        }

        private void edit7_Click(object sender, EventArgs e)
        {
            txts_note.Enabled = true;
        }

        private void edit12_Click(object sender, EventArgs e)
        {
            //change_spic.Show();
            //pictureBox3.Enabled = true;
        }

        private void btnupdateteac_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtsname.Text.Trim() == "")
                {
                    txtsname.Focus();
                    MessageBox.Show("Please Enter The Student Name ..!");
                    return;
                }
                if (txtsfnam.Text.Trim() == "")
                {
                    txtsfnam.Focus();
                    MessageBox.Show("Please Enter The Student Father Name ..!");
                    return;
                }
                if (txtsgender.Text.Trim() == "")
                {
                    txtsgender.Focus();
                    MessageBox.Show("Please Select The Student Gender ..!");
                    return;
                }
                if (txtsdob.Text.Trim() == "")
                {
                    txtsdob.Focus();
                    MessageBox.Show("Please enter The Student DOB ..!");
                    return;
                }
                if (txts_email.Text.Trim() == "")
                {
                    txts_email.Focus();
                    MessageBox.Show("Please enter The E-mail Id ..!");
                    return;
                }
                if (txts_home_phone.Text.Trim() == "")
                {
                    txts_home_phone.Focus();
                    MessageBox.Show("Please enter Home # ..!");
                    return;
                }
                if (txts_street.Text.Trim() == "")
                {
                    txts_street.Focus();
                    MessageBox.Show("Please enter Street # ..!");
                    return;
                }
                if (txts_city.Text.Trim() == "")
                {
                    txts_city.Focus();
                    MessageBox.Show("Please enter City Name # ..!");
                    return;
                }

                if (txts_zip_code.Text.Trim() == "")
                {
                    txts_zip_code.Focus();
                    MessageBox.Show("Please enter Zip Code ..!");
                    return;
                }
                if (txts_country.Text.Trim() == "")
                {
                    txts_country.Focus();
                    MessageBox.Show("Please enter Country ..!");
                    return;
                }
                string status;
                using (SqlConnection connection = new SqlConnection(c))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "update addstudent set s_rollno='" + rollnos.Text + "', s_name='" + txtsname.Text + "', s_fname='" + txtsfnam.Text + "', s_gender='" + txtsgender.Text + "', s_dob='" + txtsdob.Text + "', s_email='" + txts_email.Text + "', s_home_phone='" + txts_home_phone.Text + "', s_mobile_phone='" + txts_mobile_phone.Text + "', s_start_date='" + txts_start_date.Text + "', s_street='" + txts_street.Text + "', s_city='" + txts_city.Text + "', s_zip_code='" + txts_zip_code.Text + "', s_country='" + txts_country.Text + "', s_ready_password='" + txts_ready_password.Text + "', s_note='" + txts_note.Text + "', team_id='" + team_id.SelectedValue.ToString() + "' where s_id='" + Convert.ToInt32(txts_id.Text) + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Student Record Have Been Successfully Updated");
                    Add_Student objads = new Add_Student();
                    objads.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void schange_spic_Click(object sender, EventArgs e)
        {
            try
            {
                objcon = new SqlConnection(c);
                objcon.Open();
                SqlTransaction supic;
                supic = objcon.BeginTransaction();
                objcomm = new SqlCommand("update addstudent set s_pic = '" + CorrectFileName + "' where s_id =  '" + txts_id.Text + "'", objcon);
                objcomm.Transaction = supic;
                objcomm.ExecuteNonQuery();
                supic.Commit();
                objcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           

        }

        private void txtssclnam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtssclnam_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtsaddres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == TabIndex)
            {
                string s = txts_note.Text;
                txts_note.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                txts_note.Select(txts_note.Text.Length, 0);
            }
        }

        private void btndeleteteac_Click(object sender, EventArgs e)
        {
            try
            {
                objcon = new SqlConnection(c);
                objcon.Open();
                SqlTransaction objsdel;
                objsdel = objcon.BeginTransaction();
                objcomm = new SqlCommand("delete from addstudent where s_id =  '" + txts_id.Text + "'", objcon);
                objcomm.Transaction = objsdel;
                objcomm.ExecuteNonQuery();
                objsdel.Commit();
                MessageBox.Show("Your Student Record Have been Successfully Delete");
                objcon.Close();
                Add_Student adds = new Add_Student();
                adds.Show();
                this.Hide();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("T");
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Add_Student adst = new Add_Student();
            adst.Show();
            this.Hide();
        }

        private void sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsfnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == ' ' || e.KeyChar == TabIndex)
            {
                string s = txtsfnam.Text;
                txtsfnam.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                txtsfnam.Select(txtsfnam.Text.Length, 0);
            }
        }

        private void txtsgender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtscnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsroll_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtfcnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsdob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtscntct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtstudentfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtstudentfee_Leave(object sender, EventArgs e)
        {
          
        }

        private void editpee15_Click(object sender, EventArgs e)
        {
        }

        private void editstatusstudent_Click(object sender, EventArgs e)
        {
        }

        private void txtstatus_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtstatus_KeyPress_1(object sender, KeyPressEventArgs e)
        {
          
        }

        private void edittxtstudentdiscount_Click(object sender, EventArgs e)
        {
        }

        private void txtstudentdiscount_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtstudentdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtstudentdiscount_Leave(object sender, EventArgs e)
        {
          
        }

        private void txts_home_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            txts_email.Enabled = true;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            txts_home_phone.Enabled = true;

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            txts_street.Enabled = true;

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            txts_city.Enabled = true;

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            txts_zip_code.Enabled = true;

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            txts_country.Enabled = true;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            txts_ready_password.Enabled = true;

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            txts_start_date.Enabled = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
txts_email.Enabled = true;

            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void stueditrollnumber_Click(object sender, EventArgs e)
        {
            rollnos.Enabled = true;

        }

        private void edit1_Click_1(object sender, EventArgs e)
        {
            txtsname.Enabled = true;

        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            txtlastname.Enabled = true;

        }

        private void edit2_Click_1(object sender, EventArgs e)
        {
            txtsfnam.Enabled = true;

        }

        private void edit3_Click_1(object sender, EventArgs e)
        {
            txtsgender.Enabled = true;

        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            txts_mobile_phone.Enabled = true;
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            txts_home_phone.Enabled = true;
        }

        private void edit8_Click_1(object sender, EventArgs e)
        {
            txtsdob.Enabled = true;
        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {

            txts_street.Enabled = true;
        }

        private void metroTile5_Click_1(object sender, EventArgs e)
        {
            txts_city.Enabled = true;

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            txts_state.Enabled = true;

        }

        private void metroTile6_Click_1(object sender, EventArgs e)
        {
            txts_zip_code.Enabled = true;

        }

        private void metroTile7_Click_1(object sender, EventArgs e)
        {
            txts_country.Enabled = true;

        }

        private void metroTile8_Click_1(object sender, EventArgs e)
        {
            txts_start_date.Enabled = true;
        }

        private void edit10_Click_1(object sender, EventArgs e)
        {
            team_id.Enabled = true;

        }

        private void edit11_Click_1(object sender, EventArgs e)
        {
            txts_ready_password.Enabled = true;
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            txts_note.Enabled = true;
            
        }

        public void clearinputs()
        {
            txts_id.Text = "";
            rollnos.Text = "";
            txtsdob.Text = "";
            txtsname.Text = "";
            txtlastname.Text = "";
            txtsfnam.Text = "";
            txtsgender.Text = "";
            txts_email.Text = "";
            txts_home_phone.Text = "";
            txts_mobile_phone.Text = "";
            txts_street.Text = "";
            txts_city.Text = "";
            txts_state.Text = "";
            txts_zip_code.Text = "";
            txts_country.Text = "";
            txts_note.Text = "";
            txts_ready_password.Text = "";
            team_id.Text = "";
            txts_start_date.Text = "";
        }
        string vargetvalue = "";

        private void rollnos_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnupdateteac_Click_1(object sender, EventArgs e)
        {
               try
            {
                using (SqlConnection connection = new SqlConnection(c))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "update addstudent set s_rollno='" + rollnos.Text + "', s_name='" + txtsname.Text + "',s_last_name='" + txtlastname.Text + "', s_fname='" + txtsfnam.Text + "', s_gender='" + txtsgender.Text + "', s_dob='" + txtsdob.Text + "', s_email='" + txts_email.Text + "', s_home_phone='" + txts_home_phone.Text + "', s_mobile_phone='" + txts_mobile_phone.Text + "', s_start_date='" + txts_start_date.Text + "', s_state='" + txts_state.Text + "', s_street='" + txts_street.Text + "', s_city='" + txts_city.Text + "', s_zip_code='" + txts_zip_code.Text + "', s_country='" + txts_country.Text + "', s_ready_password='" + txts_ready_password.Text + "', s_note='" + txts_note.Text + "', team_id='" + team_id.SelectedValue.ToString() + "' where s_id='" + Convert.ToInt32(txts_id.Text) + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Student Record Have Been Successfully Updated");

                    Add_Student objads = new Add_Student();
                    objads.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void rollnos_Leave(object sender, EventArgs e)
        {
            if (txtsfnam.Text.Trim() == "")
            {
                errorProvider1.SetError(rollnos, "Enter Student Roll #.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtsname_Leave_1(object sender, EventArgs e)
        {
            if (txtsname.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsname, "Enter Student Name.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtsfnam_Leave_1(object sender, EventArgs e)
        {
            if (txtsfnam.Text.Trim() == "")
            {
                errorProvider1.SetError(txtsfnam, "Enter Father Name.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txts_email_Leave(object sender, EventArgs e)
        {

            if (txts_email.Text == null || txts_email.Text == "")
            {
                errorProvider1.SetError(txts_email, "Enter Email.");
                txts_email.Focus();
                return;
            }
            else if (!Regex.IsMatch(txts_email.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
            {
                errorProvider1.SetError(txts_email, "Plz Enter Email in  Correct Format");
                txts_email.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txts_mobile_phone_Leave(object sender, EventArgs e)
        {
            if (txtsfnam.Text.Trim() == "")
            {
                errorProvider1.SetError(txts_mobile_phone, "Enter Enter Mobile #.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rollnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                try
                {
                    vargetvalue = "";
                    using (SqlConnection connection = new SqlConnection(c))
                    {
                        connection.Open();
                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;
                        transaction = connection.BeginTransaction("SampleTransaction");
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandText = "select * from addstudent left join team on team.team_id=addstudent.team_id where s_rollno ='" + rollnos.Text + "'";
                        SqlDataAdapter objadp = new SqlDataAdapter(command.CommandText, connection);
                        objadp.SelectCommand.Transaction = transaction;
                        DataTable dta = new DataTable();
                        objadp.Fill(dta);
                        foreach (DataRow dtrow in dta.Rows)
                        {
                            txts_id.Text = dtrow["s_id"].ToString();
                            rollnos.Text = dtrow["s_rollno"].ToString();
                            txtsdob.Text = dtrow["s_dob"].ToString();
                            txtsname.Text = dtrow["s_name"].ToString();
                            txtlastname.Text = dtrow["s_last_name"].ToString();
                            txtsfnam.Text = dtrow["s_fname"].ToString();
                            txtsgender.Text = dtrow["s_gender"].ToString();
                            txts_email.Text = dtrow["s_email"].ToString();
                            txts_home_phone.Text = dtrow["s_home_phone"].ToString();
                            txts_mobile_phone.Text = dtrow["s_mobile_phone"].ToString();
                            txts_street.Text = dtrow["s_street"].ToString();
                            txts_city.Text = dtrow["s_city"].ToString();
                            txts_state.Text = dtrow["s_state"].ToString();
                            txts_zip_code.Text = dtrow["s_zip_code"].ToString();
                            txts_country.Text = dtrow["s_country"].ToString();
                            txts_note.Text = dtrow["s_note"].ToString();
                            txts_ready_password.Text = dtrow["s_ready_password"].ToString();
                            team_id.Text = dtrow["team_name"].ToString();
                            vargetvalue = dtrow["team_name"].ToString();
                            txts_start_date.Text = dtrow["s_start_date"].ToString();
                            supdatepic = (string)dtrow["s_pic"].ToString();
                            if (supdatepic != null && supdatepic != "")
                                pictureBox3.Load(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) +
                                                 @"\pics\" + supdatepic);

                        }
                        transaction.Commit();
                    }


                    if (vargetvalue == "")
                    {
                        funsimple();
                        clearinputs();
                        getrollno();

                    }
                    else
                    {
                        funedit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


      
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            txts_email.Enabled = true;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                vargetvalue = "";
                using (SqlConnection connection = new SqlConnection(c))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "select * from addstudent left join team on team.team_id=addstudent.team_id where s_rollno ='" + rollnos.Text + "'";
                    SqlDataAdapter objadp = new SqlDataAdapter(command.CommandText, connection);
                    objadp.SelectCommand.Transaction = transaction;
                    DataTable dta = new DataTable();
                    objadp.Fill(dta);
                    foreach (DataRow dtrow in dta.Rows)
                    {
                        txts_id.Text = dtrow["s_id"].ToString();
                        rollnos.Text = dtrow["s_rollno"].ToString();
                        txtsdob.Text = dtrow["s_dob"].ToString();
                        txtsname.Text = dtrow["s_name"].ToString();
                        txtlastname.Text = dtrow["s_last_name"].ToString();
                        txtsfnam.Text = dtrow["s_fname"].ToString();
                        txtsgender.Text = dtrow["s_gender"].ToString();
                        txts_email.Text = dtrow["s_email"].ToString();
                        txts_home_phone.Text = dtrow["s_home_phone"].ToString();
                        txts_mobile_phone.Text = dtrow["s_mobile_phone"].ToString();
                        txts_street.Text = dtrow["s_street"].ToString();
                        txts_city.Text = dtrow["s_city"].ToString();
                        txts_state.Text = dtrow["s_state"].ToString();
                        txts_zip_code.Text = dtrow["s_zip_code"].ToString();
                        txts_country.Text = dtrow["s_country"].ToString();
                        txts_note.Text = dtrow["s_note"].ToString();
                        txts_ready_password.Text = dtrow["s_ready_password"].ToString();
                        team_id.Text = dtrow["team_name"].ToString();
                        vargetvalue = dtrow["team_name"].ToString();
                        txts_start_date.Text = dtrow["s_start_date"].ToString();
                        supdatepic = (string)dtrow["s_pic"].ToString();
                        if (supdatepic != null && supdatepic != "")
                            pictureBox3.Load(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) +
                                             @"\pics\" + supdatepic);

                    }
                    transaction.Commit();
                }


                if (vargetvalue == "")
                {
                    funsimple();
                    clearinputs();
                    getrollno();

                }
                else
                {
                    funedit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndeleteteac_Click_1(object sender, EventArgs e)
        {
            try
            {
                objcon = new SqlConnection(c);
                objcon.Open();
                SqlTransaction objsdel;
                objsdel = objcon.BeginTransaction();
                objcomm = new SqlCommand("delete from addstudent where s_id =  '" + txts_id.Text + "'", objcon);
                objcomm.Transaction = objsdel;
                objcomm.ExecuteNonQuery();
                objsdel.Commit();
                MessageBox.Show("Your Student Record Have been Successfully Delete");
                objcon.Close();
                Add_Student adds = new Add_Student();
                adds.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txts_mobile_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txts_home_phone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txts_zip_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
       
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtsfnam_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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
                        CorrectFileName = name[0] + card.ToString()+"." + name[1];
                        File.Copy(openFileDialog.FileName, paths + @"\pics\" + CorrectFileName);
                        pictureBox3.ImageLocation = openFileDialog.FileName;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This File name is already Exists, Please Upload another pic by diffferent name");
                    }

                }


            }
        }

        private void txtsinsert_Click(object sender, EventArgs e)
        {

         try
            {
                if (rollnos.Text.Trim() == "")
                {
                    rollnos.Focus();
                    MessageBox.Show("Please Enter Roll #..!");
                    return;
                }

                if (txtsname.Text.Trim() == "")
                {
                    txtsname.Focus();
                    MessageBox.Show("Please Enter The Student Name ..!");
                    return;
                }
                if (txtsfnam.Text.Trim() == "")
                {
                    txtsfnam.Focus();
                    MessageBox.Show("Please Enter The Student Father Name ..!");
                    return;
                }
                if (txtsgender.Text.Trim() == "")
                {
                    txtsgender.Focus();
                    MessageBox.Show("Please Select The Student Gender ..!");
                    return;
                }
                if (!Regex.IsMatch(txts_email.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
                {
                    MessageBox.Show("Plz Enter Email in  Correct Format");
                    txts_email.Focus();
                    return;
                }

                if (txts_email.Text.Trim() == "")
                {
                    txts_email.Focus();
                    MessageBox.Show("Please enter The E-mail Id ..!");
                    return;
                }
                if (txts_mobile_phone.Text.Trim() == "")
                {
                    txts_home_phone.Focus();
                    MessageBox.Show("Please enter Mobile # ..!");
                    return;
                }

                if (txtsdob.Text.Trim() == "")
                {
                    txtsdob.Focus();
                    MessageBox.Show("Please enter The Student DOB ..!");
                    return;
                }

             
               



                Random rmd = new Random();
                int ramnumber = rmd.Next(0, 10000000);
                string ran = ramnumber.ToString();
                string exsitrecord="";
                using (SqlConnection connection = new SqlConnection(c))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;
                   
                    command.CommandText = "select s_rollno from addstudent where s_rollno='" + rollnos.Text + "' OR s_barecode='" + ran + "'";
                    SqlDataAdapter objadp3 = new SqlDataAdapter(command.CommandText, connection);
                    objadp3.SelectCommand.Transaction = transaction;
                    DataTable dta3 = new DataTable();
                    objadp3.Fill(dta3);
                    foreach (DataRow dtrow3 in dta3.Rows)
                    {
                        dtrow3["s_rollno"].ToString();
                    }

                    if (exsitrecord=="")
                    {
                        command.CommandText = "insert into addstudent (s_barecode,s_rollno,s_name,s_fname,s_gender,s_dob,s_pic,s_state,s_email,s_home_phone,s_mobile_phone,s_start_date,s_street,s_city,s_zip_code,s_country,s_ready_password,s_note,team_id,s_last_name) values('" + ran + "','" + rollnos.Text + "','" + txtsname.Text + "','" + txtsfnam.Text + "','" + txtsgender.Text + "','" + txtsdob.Text + "','" + CorrectFileName + "','" + txts_state.Text + "','" + txts_email.Text + "','" + txts_home_phone.Text + "','" + txts_mobile_phone.Text + "','" + txts_start_date.Text + "','" + txts_street.Text + "','" + txts_city.Text + "','" + txts_zip_code.Text + "','" + txts_country.Text + "','" + txts_ready_password.Text + "','" + txts_note.Text + "','" + team_id.SelectedValue.ToString() + "','" + txtlastname.Text + "')";
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Your Student Have Been Successfully Saved In Your Record");
                        Add_Student objads = new Add_Student();
                        objads.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("This Student Is Already Saved Yours In Record..!");
                        rollnos.Focus();
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
