using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class student_reoprt : MetroFramework.Forms.MetroForm
    {
        public student_reoprt()
        {
            InitializeComponent();
        }
        public string c = "Data Source=.; Initial Catalog=school_system; Integrated Security = SSPI; ";
        public SqlConnection objcon;
        public SqlCommand objcomm;
        public SqlDataAdapter objadp;
        public DataSet dset;
        public string stubarcode;
        public string getdata="";

        public void showstudent()
        {
            objcon = new SqlConnection(c);
            objcon.Open();
            objcomm = new SqlCommand("select addstudent.s_id AS 'Student Id', addstudent.s_barecode AS 'Bar Code', addstudent.s_rollno AS 'Roll No', addstudent.s_name AS 'Student Name', addstudent.s_fname AS 'Father Name', addstudent.s_gender AS 'Gender', addstudent.s_dob AS 'DOB', addstudent.s_state AS 'State', addstudent.s_email AS 'E-mail', addstudent.s_home_phone AS 'Home Phone #', addstudent.s_mobile_phone AS 'Mobile #', addstudent.s_start_date AS 'Start Date', addstudent.s_street AS 'Street #', addstudent.s_country AS 'Country', addstudent.s_city AS 'City', addstudent.s_zip_code AS 'Zip Code', addstudent.s_ready_password AS 'Ready Password', addstudent.s_note AS 'Note', team.team_name AS 'Team Name' from addstudent left join team on team.team_id=addstudent.team_id", objcon);
            objadp = new SqlDataAdapter(objcomm.CommandText, objcon);
            dset = new DataSet();
            objadp.Fill(dset, "stushow");
            dataGridView1.DataSource = dset.Tables["stushow"].DefaultView;
        }
     
        private void student_reoprt_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void time_Click(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("T");
        }

        private void student_reoprt_Activated(object sender, EventArgs e)
        {
            showstudent();
        }

        private void txtstusearch_TabIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    viewreport veallrep = new viewreport();
            //    veallrep.Loadreport = @"Reports\studenttableexport.rpt";
            //    veallrep.ShowDialog();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stubarcode = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btngsc_Click(object sender, EventArgs e)
        {
            try
            {
                //exportstudentcard stuvep = new exportstudentcard();
                //stuvep.studevalue = Convert.ToInt32(stubarcode);
                //stuvep.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("T");
        }

        string vargetvalue = "";
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Add_Student objAdd_Student = new Add_Student();
            objAdd_Student.Show();
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
                    command.CommandText = "select * from addstudent left join team on team.team_id=addstudent.team_id where s_id ='" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    SqlDataAdapter objadp = new SqlDataAdapter(command.CommandText, connection);
                    objadp.SelectCommand.Transaction = transaction;
                    DataTable dta = new DataTable();
                    objadp.Fill(dta);
                    foreach (DataRow dtrow in dta.Rows)
                    {
                        objAdd_Student.txts_id.Text = dtrow["s_id"].ToString();
                        objAdd_Student.rollnos.Text = dtrow["s_rollno"].ToString();
                        objAdd_Student.txtsdob.Text = dtrow["s_dob"].ToString();
                        objAdd_Student.txtsname.Text = dtrow["s_name"].ToString();
                        objAdd_Student.txtlastname.Text = dtrow["s_last_name"].ToString();
                        objAdd_Student.txtsfnam.Text = dtrow["s_fname"].ToString();
                        objAdd_Student.txtsgender.Text = dtrow["s_gender"].ToString();
                        objAdd_Student.txts_email.Text = dtrow["s_email"].ToString();
                        objAdd_Student.txts_home_phone.Text = dtrow["s_home_phone"].ToString();
                        objAdd_Student.txts_mobile_phone.Text = dtrow["s_mobile_phone"].ToString();
                        objAdd_Student.txts_street.Text = dtrow["s_street"].ToString();
                        objAdd_Student.txts_city.Text = dtrow["s_city"].ToString();
                        objAdd_Student.txts_state.Text = dtrow["s_state"].ToString();
                        objAdd_Student.txts_zip_code.Text = dtrow["s_zip_code"].ToString();
                        objAdd_Student.txts_country.Text = dtrow["s_country"].ToString();
                        objAdd_Student.txts_note.Text = dtrow["s_note"].ToString();
                        objAdd_Student.txts_ready_password.Text = dtrow["s_ready_password"].ToString();
                        objAdd_Student.team_id.Text = dtrow["team_name"].ToString();
                        vargetvalue = dtrow["team_name"].ToString();
                        objAdd_Student.txts_start_date.Text = dtrow["s_start_date"].ToString();
                        objAdd_Student.supdatepic = (string)dtrow["s_pic"].ToString();
                        if (objAdd_Student.supdatepic != null && objAdd_Student.supdatepic != "")
                            objAdd_Student.pictureBox3.Load(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) +
                                             @"\pics\" + objAdd_Student.supdatepic);

                    }
                    transaction.Commit();
                }
                if (vargetvalue == "")
                {
                    objAdd_Student.funsimple();
                    objAdd_Student.clearinputs();
                    objAdd_Student.getrollno();
                }
                else
                {
                    objAdd_Student.funedit();
                }

                objAdd_Student.rollnos.Enabled = false;
                objAdd_Student.stueditrollnumber.Hide();
                objAdd_Student.metroButton1.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //try
            //{
            //    Edit_AddStudent edads = new Edit_AddStudent();
            //    edads.editsid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    edads.editsbarcod.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    edads.editsrolno.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    edads.editsname.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    edads.editsfname.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    edads.editsgender.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //    edads.editscnic.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //    edads.editsfcnic.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //    edads.editsdob.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //    edads.editsclass.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //    edads.editsclassection.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //    edads.editscontact.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            //    edads.editslastscl.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            //    edads.editsadress.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            //    edads.spicpath = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            //    edads.edittxtstudentfee.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            //    edads.editstudentfeediscount.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            //    edads.edittxtdiscountfee.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            //    edads.edittxtstatus.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            //    edads.MdiParent = this.MdiParent;
            //    edads.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
        }

        private void txtstusearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(c))
                {
                    string getsearchcolumn = "";
                    if (txtstucombox.Text == "Roll #")
                    {
                        getsearchcolumn = "s_rollno";

                    }
                    else if (txtstucombox.Text == "Student Name")
                    {

                        getsearchcolumn = "s_name";

                    }

                    else if (txtstucombox.Text == "Phone #")
                    {


                        getsearchcolumn = "s_mobile_phone";


                    }
                    else
                    {
                        MessageBox.Show("Please, Select The Search Column..!");
                        txtstucombox.Focus();
                    }


                    objcon = new SqlConnection(c);
                    objcomm =
                        new SqlCommand(
                            "",
                            objcon);
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    transaction = connection.BeginTransaction("SampleTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "select * from addstudent where " + getsearchcolumn + " like '%" + txtstusearch.Text + "%'";
                    SqlDataAdapter objadp = new SqlDataAdapter(command.CommandText, connection);
                    objadp.SelectCommand.Transaction = transaction;
                    DataTable dta = new DataTable();
                    objadp.Fill(dta);
                    dataGridView1.DataSource = dta;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
