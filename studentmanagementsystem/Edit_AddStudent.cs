using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentmanagementsystem
{
    public partial class Edit_AddStudent : MetroFramework.Forms.MetroForm
    {
        public Edit_AddStudent()
        {
            InitializeComponent();
            
        }

        public string c = "Data Source=.; Initial Catalog=school_system; Integrated Security = SSPI; ";
        public SqlConnection objcon;
        public SqlCommand objcomm;
        public SqlDataAdapter objadp;
        public DataSet dset;
        public string editpic, spicpath;


        private void Edit_AddStudent_Load(object sender, EventArgs e)
        {
            sedittimer.Start();
            editsrolno.Enabled = false;
            editsbarcod.Enabled = false;
            if (spicpath != null && spicpath != "")
            
                editspic.Load(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\pics\" +spicpath);
            
            editsid.Hide();
            editsrolno.Enabled = true;
            editsname.Enabled = true;
            editsfname.Enabled = true;
            editsgender.Enabled = true;
            editscnic.Enabled = true;
            editsfcnic.Enabled = true;
            editsdob.Enabled = true;
            editsbarcod.Enabled = false;
            editsclass.Enabled = true;
            editsclassection.Enabled = true;
            editscontact.Enabled = true;
            editslastscl.Enabled = true;
            editsadress.Enabled = true;
            editspic.Enabled = false;
           

        }


        private void edittxtsturegno_Enter(object sender, EventArgs e)
        {
            if (editsrolno.Text == "Enter Edit Roll No")
            {
                editsrolno.Text = "";
                editsrolno.ForeColor = Color.Black;
            }
        }

        private void edittxtsturegno_Leave(object sender, EventArgs e)
        {
            if (editsrolno.Text.Trim() == "")
            {

                errorProvider1.SetError(editsrolno, "Enter Edit Roll No");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void edittxtstudentname_Leave(object sender, EventArgs e)
        {
            if (editsname.Text.Trim() == "")
            {
                errorProvider1.SetError(editsname, "Enter The Edit Student Name");
            }
            else
            {
                errorProvider1.Clear();
            }


        }

        private void edittxtstudentname_Enter(object sender, EventArgs e)
        {
            if (editsname.Text == "Enter The Edit Student Name")
            {
                editsname.Text = "";
                editsname.ForeColor = Color.Black;
            }
        }

        private void edittxtfathername_Leave(object sender, EventArgs e)
        {
            if (editsfname.Text.Trim() == "")
            {
                errorProvider1.SetError(editsfname, "Enter The Edit Father Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void edittxtfathername_Enter(object sender, EventArgs e)
        {
            if (editsfname.Text == "Enter The Edit Father Name")
            {
                editsfname.Text = "";
                editsfname.ForeColor = Color.Black;
            }
        }

        private void edittxtgender_Leave(object sender, EventArgs e)
        {
            try
            {
                if (editsgender.Text == "---Select Gender----")
                {
                    editsgender.Text = "";
                    editsgender.ForeColor = Color.Black;
                }
                if (editsgender.Text == "")
                {
                    editsgender.Text = "---Select Gender----";
                    editsgender.Focus();

                    errorProvider1.SetError(editsgender, "Please Select The comboBox Value");
                }
                else
                {
                    errorProvider1.Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void edittxtcnicno_Leave(object sender, EventArgs e)
        {

        }

        private void edittxtstudob_Leave(object sender, EventArgs e)
        {
        }

        private void edittxtstuadress_Leave(object sender, EventArgs e)
        {
            if (editsadress.Text.Trim() == "")
            {

                errorProvider1.SetError(editsadress, "Enter The Edit Address");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void edittxtstucontact_Leave(object sender, EventArgs e)
        {
        }

        private void edittxtstuclass_Enter(object sender, EventArgs e)
        {
            if (editsclass.Text == "----Select Class----")
            {
                editsclass.Text = "";
                editsclass.ForeColor = Color.Black;
            }
        }

        private void edittxtstusection_Leave(object sender, EventArgs e)
        {
            if (editsclassection.Text == "----Select Section----")
            {
                editsclassection.Text = "";
                editsclassection.ForeColor = Color.Black;
            }
            if (editsclassection.Text == "")
            {
                editsclassection.Text = "----Select Section----";
                editsclassection.Focus();

                errorProvider1.SetError(editsclassection, "Please Select The comboBox Value");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void edittxtstuclass_Leave(object sender, EventArgs e)
        {

            if (editsclass.Text == "----Select Class----")
            {
                editsclass.Text = "";
                editsclass.ForeColor = Color.Black;
            }
            if (editsclass.Text == "")
            {
                editsclass.Text = "----Select Class----";
                editsclass.Focus();

                errorProvider1.SetError(editsclass, "Please Select The comboBox Value");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void edittxtstusection_Enter(object sender, EventArgs e)
        {
            if (editsclassection.Text == "----Select Section----")
            {
                editsclassection.Text = "";
                editsclassection.ForeColor = Color.Black;
            }
        }

        private void edittxtstulaschool_Leave(object sender, EventArgs e)
        {
            if (editslastscl.Text.Trim() == "")
            {
                errorProvider1.SetError(editslastscl, "Enter The Last School Join");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void edittxtstulaschool_Enter(object sender, EventArgs e)
        {
            if (editslastscl.Text == "Enter The Edit Last School Join ")
            {
                editslastscl.Text = "";
                editslastscl.ForeColor = Color.Black;
            }
        }

        private void edittxtstubloodgroup_Leave(object sender, EventArgs e)
        {

        }

        private void edittxtstubloodgroup_Enter(object sender, EventArgs e)
        {

        }

        private void txtinsert_Click(object sender, EventArgs e)
        {
            try
            {


                if (editsrolno.Text.Trim() == "")
                {
                    editsrolno.Focus();
                    MessageBox.Show("Please Enter The Edit Roll No..!");
                    return;
                }
                if (editsname.Text.Trim() == "")
                {
                    editsname.Focus();
                    MessageBox.Show("Please Enter Edit Student Name..!");
                    return;
                }
                if (editsfname.Text.Trim() == "")
                {
                    editsfname.Focus();
                    MessageBox.Show("Please Enter Edit Father Name..!");
                    return;
                }
                if (editsgender.Text.Trim() == "")
                {
                    editsgender.Focus();
                    MessageBox.Show("Please Select Gender..!");
                    return;
                }
                if (editscnic.Text.Trim() == "")
                {
                    editscnic.Focus();
                    MessageBox.Show("Please Enter Edit CNIC No..!");
                    return;
                }
                if (editsfcnic.Text.Trim() == "")
                {
                    editsfcnic.Focus();
                    MessageBox.Show("Please Enter Father CNIC No..!");
                    return;
                }
                if (editscontact.Text.Trim() == "")
                {
                    editscontact.Focus();
                    MessageBox.Show("Please Enter Mobile No..!");
                    return;
                }
                if (editsdob.Text.Trim() == "")
                {
                    editsdob.Focus();
                    MessageBox.Show("Please Enter The Date of Birth.!");
                    return;
                }
                if (editsadress.Text.Trim() == "")
                {
                    editsadress.Focus();
                    MessageBox.Show("Please Enter The Address.!");
                    return;
                }
                if (editsclass.Text.Trim() == "")
                {
                    editsclass.Focus();
                    MessageBox.Show("Please  Select The Class..!");
                    return;
                }
                if (editsclassection.Text.Trim() == "")
                {
                    editsclassection.Focus();
                    MessageBox.Show("Please Select The Section");
                    return;
                }
                if (editslastscl.Text.Trim() == "")
                {
                    editslastscl.Focus();
                    MessageBox.Show("Please Enter The Edit Last School Join");
                    return;
                }
                if (edittxtdiscountfee.Text.Trim() == "")
                {
                    edittxtdiscountfee.Focus();
                    MessageBox.Show("Please Enter Discount Value");
                    return;
                }
                objcon = new SqlConnection(c);
                objcon.Open();
                SqlTransaction objstc;
                objstc = objcon.BeginTransaction();
                objcomm =
                    new SqlCommand(
                        "update addstudent set s_rollno = '" + editsrolno.Text + "',s_name = '" + editsname.Text +
                        "', s_fname = '" + editsfname.Text + "',s_gender = '" + editsgender.Text + "', s_cnicno = '" +
                        editscnic.Text + "', s_fcnicno = '" + editsfcnic.Text + "', s_dob = '" + editsdob.Text +
                        "', s_class = '" + editsclass.Text + "', s_section = '" + editsclassection.Text +
                        "', s_contactno = '" + editscontact.Text + "', s_lastschool = '" + editslastscl.Text +
                        "' , s_address = '" + editsadress.Text + "',s_pic = '" + editpic + "',s_monthlypee='" + editstudentfeediscount.Text + "',s_discount='" + edittxtdiscountfee.Text + "',s_status='" + edittxtstatus.Text + "' where s_id = '" +
                        editsid.Text + "'",objcon);
                objcomm.Transaction = objstc;
                objcomm.ExecuteNonQuery();
                objstc.Commit();
                MessageBox.Show("Your Student Record Have been Successfully Update");
                objcon.Close();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void edittxtsturegno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void edittxtstudentname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) ||
                (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void edittxtfathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) ||
                (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void edittxtgender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) ||
                (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void edittxtcnicno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void edittxtmaskfcnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void edittxtstudob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void edittxtstucontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void edittxtstuclass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) ||
                (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void editspic_Click(object sender, EventArgs e)
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
                            editpic = Path.GetFileName(openFileDialog.FileName);
                            editpic = editsrolno.Text + date + pictureBox1.Text + editpic;
                            File.Copy(openFileDialog.FileName, paths + @"\pics\" + editpic);
                            editspic.ImageLocation = openFileDialog.FileName;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(
                                "This File name is already Exists, Please Upload another pic by diffferent name");
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btndelet_Click(object sender, EventArgs e)
        {
            try
            {
                objcon = new SqlConnection(c);
                objcon.Open();
                SqlTransaction objsdt;
                objsdt = objcon.BeginTransaction();
                objcomm = new SqlCommand("delete from addstudent where s_id = '"+editsid.Text+"'",objcon ,objsdt);
                objcomm.Transaction = objsdt;
                objcomm.ExecuteNonQuery();
                objsdt.Commit();
                MessageBox.Show("Your Student Record Have been Successfully Delete");
                objcon.Close();
                this.Hide();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editstupic_Click(object sender, EventArgs e)
        {
            editchang_pic.Show();
            editspic.Enabled = true;
        }

        private void editchang_pic_Click(object sender, EventArgs e)
        {
            try
            {
                objcon = new SqlConnection(c);
                objcon.Open();
                SqlTransaction objesp;
                objesp = objcon.BeginTransaction();
                objcomm = new SqlCommand("update addstudent set s_pic = '" + editspic + "' where s_id = '"+editsid.Text+"'",objcon,objesp);
                objcomm.Transaction = objesp;
                objcomm.ExecuteNonQuery();
                objesp.Commit();
                objcon.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void sedittimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("T");
        }

        private void txtstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) ||
              (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
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
            if (edittxtstudentfee.Text.Trim() == "")
            {
                errorProvider1.SetError(edittxtstudentfee, "Enter The Monthly Fee");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void edittxtstatus_Leave(object sender, EventArgs e)
        {
           
            if (edittxtstatus.Text == "")
            {
                edittxtstatus.Text = "----Select Status----";
                edittxtstatus.Focus();

                errorProvider1.SetError(edittxtstatus, "Please Select The Status Value");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void editbtndiscountapply_Click(object sender, EventArgs e)
        {
          
        }

        private void edittxtdiscountfee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int fee, total, discount, sum;
                fee = Convert.ToInt32(edittxtstudentfee.Text);
                discount = Convert.ToInt32(edittxtdiscountfee.Text);
                total = discount * (fee / 100);
                editstudentfeediscount.Text = Convert.ToString(fee - total);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
        }

    }
}
    
    
