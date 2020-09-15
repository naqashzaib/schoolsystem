using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class dashborad : Form
    {
        public dashborad()
        {
            InitializeComponent();
        }

        private void teacherReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //addteacher adtecu = new addteacher();
            //adtecu.MdiParent = this;
            //adtecu.Show();
        }   

        private void techerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student adstu = new Add_Student();
            adstu.MdiParent = this;
                adstu.Show();
        }

        private void examinationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Addfee addfeefrom = new Addfee();
            //addfeefrom.MdiParent = this;
            //addfeefrom.Show();
        }

        private void reortAttendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //student_attends_report sta = new student_attends_report();
            //sta.MdiParent = this;
            //sta.Show();
        }

        private void addOpeationalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add_optional_data adopdata = new add_optional_data();
            //adopdata.MdiParent = this;
            //adopdata.Show();
        }

        private void reportStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_reoprt stureport = new student_reoprt();
            stureport.MdiParent = this;
            stureport.Show();
        }

        private void teacherReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //teacher_report teareport = new teacher_report();
            //teareport.MdiParent = this;
            //teareport.Show();

        }

        private void studentAttendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //studentattends stuadd = new studentattends();
            //stuadd.MdiParent = this;
            //stuadd.Show();
        }
        public string getdatevalue="";
        private void dashborad_Load(object sender, EventArgs e)
        {
           
        }

        private void teacherAttendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //teacherattends tecattends = new teacherattends();
            //tecattends.MdiParent = this;
            //tecattends.Show();
        }

        private void teacherAttendsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //teacher_attends_report tap = new teacher_attends_report();
            //tap.MdiParent = this;
            //tap.Show();
        }

        private void absentTeacherReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //absent_teacher_report ateacher = new absent_teacher_report();
            //ateacher.MdiParent = this;
            //ateacher.Show();
        }

        private void absentTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //absent_teacher abst = new absent_teacher();
            //abst.MdiParent = this;
            //abst.Show();

        }

        private void absentStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //student_absent studentab = new student_absent();
           // studentab.MdiParent = this;
           // studentab.Show();
        }

        private void absentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //absent_student_report abstudentrep = new absent_student_report();
            //abstudentrep.MdiParent = this;
            //abstudentrep.Show();
        }

        private void findTeacherAttendsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //findteacherattendreport ftar = new findteacherattendreport();
            //ftar.MdiParent = this;
            //ftar.Show();
        }

        private void findStudentAttendsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //findstudentattendsreport findstuatt = new findstudentattendsreport();
            //findstuatt.MdiParent = this;
            //findstuatt.Show();
        }

        private void collectAdvnceFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Collect_Advance_Fee caf = new Collect_Advance_Fee();
            //caf.MdiParent = this;
            //caf.Show();
        }

        private void unpaidFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //unpaid_fee unfeereport = new unpaid_fee();
            //unfeereport.MdiParent = this;
            //unfeereport.Show();
        }

        private void fineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //studentfinefrom stufine = new studentfinefrom();
            //stufine.MdiParent = this;
            //stufine.Show();

        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_team stufine = new add_team();
            stufine.MdiParent = this;
            stufine.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add_Student adstu = new Add_Student();
            adstu.MdiParent = this;
            adstu.Show();
        }

        private void reportStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            student_card_export adstu = new student_card_export();
            adstu.MdiParent = this;
            adstu.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            student_reoprt adstu = new student_reoprt();
            adstu.MdiParent = this;
            adstu.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void studentAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendence adstu = new attendence();
            adstu.MdiParent = this;
            adstu.Show();
        }
    }
}
