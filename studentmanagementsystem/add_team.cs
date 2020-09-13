using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class add_team : MetroFramework.Forms.MetroForm
    {
        public add_team()
        {
            InitializeComponent();
        }



        private void add_team_Load(object sender, EventArgs e)
        {
            load_values();
            btnDelete.Hide();
            btnUpdate.Hide();

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


        static string con = "Data Source=.; Initial Catalog=school_system; Integrated Security = SSPI; ";

        SqlConnection objcon = new SqlConnection(con);

        SqlCommand objcom;
        SqlCommandBuilder objscb;
        SqlDataAdapter objadpt;
        DataSet dset;
        public void load_values()
        {
            objcon.Close();
            objcon.Open();
            objcom = new SqlCommand("select team_id as 'Team Id', team_name  as 'Team Name' , team_desc as 'Description'  from team", objcon);
            DataSet dt1 = new DataSet();
            objadpt = new SqlDataAdapter(objcom.CommandText, objcon);

            dt1 = new DataSet();

            dt1.Clear();
            objadpt.Fill(dt1, "tabledata");
            dataGridView1.DataSource = dt1.Tables["tabledata"].DefaultView;
            objcon.Close();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text != "" && txtDesc.Text != "")
            {
                objcon.Close();
                objcon.Open();
                objcom = new SqlCommand("select * from team where team_name=  '" + txtTeamName.Text + "'", objcon);
                SqlDataReader re = null;
                re = objcom.ExecuteReader();

                if (re.HasRows)
                {
                    MessageBox.Show("Team Name Already Exists");
                    txtTeamName.Clear();
                    txtTeamName.Focus();
                    return;
                }


                objcon.Close();

                objcon.Open();
                objcom = new SqlCommand("insert into team (team_name,team_desc) values('" + txtTeamName.Text + "','" + txtDesc.Text + "')", objcon);
                objcom.ExecuteNonQuery();
                objcon.Close();
                clear();
                load_values();
                MessageBox.Show("New team Added");

            }
            else
            {
                MessageBox.Show("Please Fill All Text  Boxes");
            }
        }
        public void clear()
        {
            txtTeamName.Clear();
            txtDesc.Clear();
            //dataGridView1.DataSource = null;
        }

        private string id = "";
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            txtTeamName.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            txtDesc.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();

            btnDelete.Show();
            btnUpdate.Show();
            btnAdd.Hide();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you Want To Update Team...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                if (txtTeamName.Text != "" && txtDesc.Text != "")
                {
                    objcon.Close();
                    objcon.Open();
                    objcom = new SqlCommand("select * from team where team_name=  '" + txtTeamName.Text + "' and team_desc='" + txtDesc.Text + "'", objcon);
                    SqlDataReader re = null;
                    re = objcom.ExecuteReader();

                    if (re.HasRows)
                    {
                        MessageBox.Show("Team Name Already Exists");
                        txtTeamName.Clear();
                        txtTeamName.Focus();
                        return;
                    }

                    id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();



                    objcon.Close();
                    objcon.Open();
                    objcom =

                        new SqlCommand(
                            "update  team set team_name='" + txtTeamName.Text + "',team_desc='" + txtDesc.Text + "' where team_id='" + id + "'", objcon);
                    objcom.ExecuteNonQuery();
                    btnDelete.Hide();
                    btnUpdate.Hide();
                    btnAdd.Show();
                    clear();
                    load_values(); MessageBox.Show("Team Name Updated Successfully...!!");
                 
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you Want To Delete Team...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {

                id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();



                objcon.Close();
                objcon.Open();
                objcom =

                    new SqlCommand(
                        "delete from team where team_id='" + id + "'", objcon);
                objcom.ExecuteNonQuery();
                btnDelete.Hide();
                btnUpdate.Hide();
                btnAdd.Show();
                clear();
                load_values(); MessageBox.Show("Team Name Deleted Successfully...!!");
            }
        }

    }
}
