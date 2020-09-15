using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class attendence : MetroFramework.Forms.MetroForm
    {
        public attendence()
        {
            InitializeComponent();
        }

        static string cs = ConfigurationManager.ConnectionStrings["student"].ConnectionString;
       
        private SqlConnection objcon =  new SqlConnection(cs);
        private SqlCommand objcom = new SqlCommand();
        private SqlDataAdapter objadpt = new SqlDataAdapter();

        private void attendence_Load(object sender, EventArgs e)
        {
            getStudents();
            getStudentsAttendence();

            btnSave.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            txtDateTime.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            txtDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt ";

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

        class student
        {

            public string Studen_Name { get; set; }
            public string RollNo { get; set; }
            public string Date_Time { get; set; }
            public string Attendence_Status { get; set; }
            public bool idperiod1 { get; set; }
            public bool idperiod2 { get; set; }
            public bool idperiod3 { get; set; }
            public bool idperiod4 { get; set; }
            public bool idperiod5 { get; set; }
            public bool idperiod6 { get; set; }
            public int Attendence_ID { get; set; }
        }
        public void getStudents()
        {


            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = "select  s_id as s,CONCAT(s_name, ' ', s_fname) AS name  from addstudent order by s_name";
                SqlDataAdapter objadp3 = new SqlDataAdapter(command.CommandText, connection);
                objadp3.SelectCommand.Transaction = transaction;
                DataTable dta3 = new DataTable();
                objadp3.Fill(dta3);
                ddlStudentName.DisplayMember = "name";
                ddlStudentName.ValueMember = "s";
                ddlStudentName.DataSource = dta3;
                transaction.Commit();
            }
        }
        public void getStudentsAttendence()
        {
            List<student> eObj = new List<student>();

            using (SqlConnection objcon = new SqlConnection(cs))
            {
                objcon.Close();
                objcon.Open();
                objcom = new SqlCommand("select  student_attendence.student_attendence_id, addstudent.s_id, CONCAT(addstudent.s_name, ' ', addstudent.s_fname) AS name , addstudent.s_rollno,student_attendence.attaneden_datetime, student_attendence.attendence_status, student_attendence.period1_status as '9:00 AM - 10:30 AM',student_attendence.period2_status as '10:30 AM - 12:00 PM',student_attendence.period3_status as '12:30 PM - 2:30 PM',student_attendence.period4_status as '4:30 PM - 5:30 PM',student_attendence.period5_status  as '5:30 PM - 6:30 PM',student_attendence.period6_status as '6:30 PM - 7:30 PM' from addstudent, student_attendence  where addstudent.s_id=student_attendence.s_id", objcon);
                SqlDataAdapter objadp = new SqlDataAdapter(objcom.CommandText, objcon);
                DataSet dset = new DataSet();

                objadp.Fill(dset, "stushow");
                for (int i = 0; i < dset.Tables[0].Rows.Count; i++)
                {
                    student st = new student();
                    st.Studen_Name = (dset.Tables[0].Rows[i]["name"].ToString());
                    st.RollNo = (dset.Tables[0].Rows[i]["s_rollno"].ToString());
                    st.Date_Time = (dset.Tables[0].Rows[i]["attaneden_datetime"].ToString());
                    st.Attendence_Status = (dset.Tables[0].Rows[i]["attendence_status"].ToString());
                    st.idperiod1 = Convert.ToBoolean(dset.Tables[0].Rows[i]["9:00 AM - 10:30 AM"].ToString());
                    st.idperiod2 = Convert.ToBoolean(dset.Tables[0].Rows[i]["10:30 AM - 12:00 PM"].ToString());
                    st.idperiod3 = Convert.ToBoolean(dset.Tables[0].Rows[i]["12:30 PM - 2:30 PM"].ToString());
                    st.idperiod4 = Convert.ToBoolean(dset.Tables[0].Rows[i]["4:30 PM - 5:30 PM"].ToString());
                    st.idperiod5 = Convert.ToBoolean(dset.Tables[0].Rows[i]["5:30 PM - 6:30 PM"].ToString());
                    st.idperiod6 = Convert.ToBoolean(dset.Tables[0].Rows[i]["6:30 PM - 7:30 PM"].ToString());
                    st.Attendence_ID = Convert.ToInt16(dset.Tables[0].Rows[i]["student_attendence_id"].ToString());
                    eObj.Add(st);
                }
                //dt5.Clear();
                //dt5.Columns.Add("s_id", typeof(string));
                //dt5.Columns.Add("name", typeof(string));
                //dt5.Load(readerr);
                dataGridView1.DataSource = eObj;
            }
        }
         public void getStudentsAttendenceBySearch(string type)
        {
            List<student> eObj = new List<student>();

            using (SqlConnection objcon = new SqlConnection(cs))
            {
                objcon.Close();
                objcon.Open();
                if (type == "roll")
                {
                    objcom = new SqlCommand("select  student_attendence.student_attendence_id, addstudent.s_id, CONCAT(addstudent.s_name, ' ', addstudent.s_fname) AS name , addstudent.s_rollno,student_attendence.attaneden_datetime, student_attendence.attendence_status, student_attendence.period1_status as '9:00 AM - 10:30 AM',student_attendence.period2_status as '10:30 AM - 12:00 PM'," +
                                            "student_attendence.period3_status as '12:30 PM - 2:30 PM',student_attendence.period4_status as '4:30 PM - 5:30 PM',student_attendence.period5_status  as '5:30 PM - 6:30 PM',student_attendence.period6_status as '6:30 PM - 7:30 PM' from addstudent, student_attendence where   addstudent.s_id=student_attendence.s_id and addstudent.s_rollno='" + txtSearch.Text + "'  order by student_attendence.attaneden_datetime", objcon);

                }
                else
                {
                    objcom = new SqlCommand("select  student_attendence.student_attendence_id, addstudent.s_id, CONCAT(addstudent.s_name, ' ', addstudent.s_fname) AS name , addstudent.s_rollno,student_attendence.attaneden_datetime, student_attendence.attendence_status, student_attendence.period1_status as '9:00 AM - 10:30 AM',student_attendence.period2_status as '10:30 AM - 12:00 PM'," +
                                            "student_attendence.period3_status as '12:30 PM - 2:30 PM',student_attendence.period4_status as '4:30 PM - 5:30 PM',student_attendence.period5_status  as '5:30 PM - 6:30 PM',student_attendence.period6_status as '6:30 PM - 7:30 PM' from addstudent, student_attendence where  addstudent.s_id=student_attendence.s_id and addstudent.s_name='" + txtSearch.Text + "' or  addstudent.s_fname='" + txtSearch.Text + "' order by addstudent.s_name,  student_attendence.attaneden_datetime", objcon);


                }
               SqlDataAdapter objadp = new SqlDataAdapter(objcom.CommandText, objcon);
                DataSet dset = new DataSet();

                objadp.Fill(dset, "stushow");
                for (int i = 0; i < dset.Tables[0].Rows.Count; i++)
                {
                    student st = new student();
                    st.Studen_Name = (dset.Tables[0].Rows[i]["name"].ToString());
                    st.RollNo = (dset.Tables[0].Rows[i]["s_rollno"].ToString());
                    st.Date_Time = (dset.Tables[0].Rows[i]["attaneden_datetime"].ToString());
                    st.Attendence_Status = (dset.Tables[0].Rows[i]["attendence_status"].ToString());
                    st.idperiod1 = Convert.ToBoolean(dset.Tables[0].Rows[i]["9:00 AM - 10:30 AM"].ToString());
                    st.idperiod2 = Convert.ToBoolean(dset.Tables[0].Rows[i]["10:30 AM - 12:00 PM"].ToString());
                    st.idperiod3 = Convert.ToBoolean(dset.Tables[0].Rows[i]["12:30 PM - 2:30 PM"].ToString());
                    st.idperiod4 = Convert.ToBoolean(dset.Tables[0].Rows[i]["4:30 PM - 5:30 PM"].ToString());
                    st.idperiod5 = Convert.ToBoolean(dset.Tables[0].Rows[i]["5:30 PM - 6:30 PM"].ToString());
                    st.idperiod6 = Convert.ToBoolean(dset.Tables[0].Rows[i]["6:30 PM - 7:30 PM"].ToString());
                    st.Attendence_ID = Convert.ToInt16(dset.Tables[0].Rows[i]["student_attendence_id"].ToString());
                    eObj.Add(st);
                }
                //dt5.Clear();
                //dt5.Columns.Add("s_id", typeof(string));
                //dt5.Columns.Add("name", typeof(string));
                //dt5.Load(readerr);
                dataGridView1.DataSource = eObj;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student a = new Add_Student();
            a.Show();
        }

        public string funChangeDateForDb(string date)
        {
            string[] vardate = date.Split(' ');
            string[] newdate = vardate[0].ToString().Split('/');
            return newdate[2] + "-" + newdate[1] + "-" + newdate[0] + " " + vardate[1] + " " + vardate[2];

        }
        public string changedateForInput(string date)
        {
            string[] vardate = date.Split(' ');
            string[] newdate = vardate[0].ToString().Split('-');
            return newdate[2] + "-" + newdate[1] + "-" + newdate[0] + " " + vardate[1] + " " + vardate[2];
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ddlStudentName.Text.Trim() == "")
            {
                ddlStudentName.Focus();
                MessageBox.Show("Please Select Student Name..!");
                return;
            }
            if (ddlStatus.Text.Trim() == "Select Attendence Status")
            {
                ddlStatus.Focus();
                MessageBox.Show("Please Select Attendence status..!");
                return;
            }

            if (chkPeriod1.Checked == false && chkPeriod2.Checked == false && chkPeriod3.Checked == false && chkPeriod4.Checked == false && chkPeriod5.Checked == false && chkPeriod6.Checked == false)
            {
                chkPeriod1.Focus();
                MessageBox.Show("Please Select atleast one class timing..!");
                return;
            }
            objcon.Open();
            objcom =
                new SqlCommand(
                    "select * from student_attendence where s_id='" + ddlStudentName.SelectedValue.ToString() + "' and attendenc_date='" + funChangeDateForDb(txtDateTime.Text).Split(' ')[0] + "'", objcon);
            SqlDataReader reader = null;
            reader = objcom.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Attendence of person:" + ddlStudentName.Text.ToString() + " on date " + (txtDateTime.Text).Split(' ')[0] + " already exists...!");
                return;
            }
            objcon.Close();

            objcon.Open();
            objcom = new SqlCommand("INSERT INTO student_attendence (s_id ,attendence_status ,attaneden_datetime ,period1_status ,period2_status ,period3_status ,period4_status ,period5_status ,period6_status ,attendenc_date) VALUES('" + ddlStudentName.SelectedValue.ToString() + "','" + ddlStatus.Text + "','" + funChangeDateForDb(txtDateTime.Text) + "','" + chkPeriod1.Checked + "','" + chkPeriod2.Checked + "','" + chkPeriod3.Checked + "','" + chkPeriod4.Checked + "','" + chkPeriod5.Checked + "','" + chkPeriod6.Checked + "','" + funChangeDateForDb(txtDateTime.Text).Split(' ')[0] + "')", objcon);
            objcom.ExecuteNonQuery();
            objcon.Close();
            clearFun();
            getStudentsAttendence();
            MessageBox.Show("Attendence Added...!");

        }

        private string student_attendence_id = "";
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ddlStudentName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDateTime.Text = changedateForInput(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            ddlStatus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            chkPeriod1.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            chkPeriod2.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            chkPeriod3.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            chkPeriod4.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            chkPeriod5.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            chkPeriod6.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            student_attendence_id = (dataGridView1.CurrentRow.Cells[10].Value.ToString());
            ddlStudentName.Enabled = false;
            txtDateTime.Enabled = false;
            btnSave.Hide();
            btnDelete.Show();
            btnUpdate.Show();
        }

        public void clearFun()
        {
            ddlStudentName.Enabled = true;
            txtDateTime.Enabled = true;
            btnSave.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            chkPeriod1.Checked = false;
            chkPeriod2.Checked = false;
            chkPeriod3.Checked = false;
            chkPeriod4.Checked = false;
            chkPeriod5.Checked = false;
            chkPeriod6.Checked = false;
            getStudentsAttendence();
            txtSearch.Text = "";
            rdName.Checked = true;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ddlStudentName.Text.Trim() == "")
            {
                ddlStudentName.Focus();
                MessageBox.Show("Please Select Student Name..!");
                return;
            }
            if (ddlStatus.Text.Trim() == "Select Attendence Status")
            {
                ddlStatus.Focus();
                MessageBox.Show("Please Select Attendence status..!");
                return;
            }

            if (chkPeriod1.Checked == false && chkPeriod2.Checked == false && chkPeriod3.Checked == false && chkPeriod4.Checked == false && chkPeriod5.Checked == false && chkPeriod6.Checked == false)
            {
                chkPeriod1.Focus();
                MessageBox.Show("Please Select atleast one class timing..!");
                return;
            }
            DialogResult dialog = MessageBox.Show("Do you Want Update Attendence...??", "Info", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                objcon.Close();

                objcon.Open();
                objcom = new SqlCommand("update student_attendence set attendence_status=  '" + ddlStatus.Text + "',attaneden_datetime ='" + funChangeDateForDb(txtDateTime.Text) + "',period1_status ='" + chkPeriod1.Checked + "' ,period2_status='" + chkPeriod2.Checked + "' ,period3_status='" + chkPeriod3.Checked + "' ,period4_status= '" + chkPeriod4.Checked + "',period5_status ='" + chkPeriod5.Checked + "',period6_status= '" + chkPeriod6.Checked + "',attendenc_date ='" + funChangeDateForDb(txtDateTime.Text).Split(' ')[0] + "' where student_attendence_id ='" + student_attendence_id + "'", objcon);
                objcom.ExecuteNonQuery();
                objcon.Close();
                clearFun();
                getStudentsAttendence();
                MessageBox.Show("Attendence Updated...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFun();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you Want Delete Attendence...??", "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {

                objcon.Close();

                objcon.Open();
                objcom = new SqlCommand("delete from student_attendence  where student_attendence_id ='" + student_attendence_id + "'", objcon);
                objcom.ExecuteNonQuery();
                objcon.Close();
                //clear();
                //load_values();
                clearFun();
                getStudentsAttendence();
                MessageBox.Show("Attendence Deleted...!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdName.Checked == true)
            {
                getStudentsAttendenceBySearch("name");

            }
            else
            {
                getStudentsAttendenceBySearch("roll");

            }
        }
    }
}
