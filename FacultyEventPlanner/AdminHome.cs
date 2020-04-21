using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FacultyEventPlanner
{
    
    public partial class AdminHome : Form
    {
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt = new DataTable();
        DataRow row;

        public AdminHome()
        {
            InitializeComponent();
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Request Stautue");
            dt.Columns.Add("Start Time");
            dt.Columns.Add("Date");
            dt.Columns.Add("Location Name");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View_V_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Violations v = new View_Violations();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = OracleHelper.getConnection();
            //Combobox
            cmd.CommandText = @"Select D_Title
            from Department";
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Combo_Box_of_DEP.Items.Add(dr[0].ToString());
            }
            dr.Close();
            //data_grid view 
            cmd.CommandText = @"select Title,Capacity,Description,
                Request_status,L_Name,Ls_Start_time,Ls_date
                from event";
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            row = dt.NewRow();
            while (dr.Read())
            {

                row["Title"] = dr[0].ToString();
                row["Description"] = dr[2].ToString();
                row["Capacity"] = dr[1].ToString();
                row["Request Stautue"] = dr[3].ToString();
                row["Start Time"] = dr[5].ToString();
                row["Date"] = dr[6].ToString();
                row["Location Name"] = dr[4].ToString();

                dt.Rows.Add(row);
                row = dt.NewRow();
            }
            dr.Close();

            int num;
            int counter = 0;
            foreach (DataRow drow in dt.Rows)
            {
                num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[counter].Value = drow["Title"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Description"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Capacity"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Request Stautue"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["start time"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Date"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Location Name"].ToString();
                counter++;
                counter = 0;


            }
        }

        private void Admin_home(object sender, FormClosingEventArgs e)
        {
            OracleHelper.closeConnection();
        }

        private void Combo_Box_of_DEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmd = new OracleCommand();
            cmd.Connection = OracleHelper.getConnection();
            cmd.CommandText = @"select Title,Capacity,Description,
            Request_status,L_Name,Ls_Start_time,Ls_date
            from event
            where D_id=
            (select D_id  from Department where D_title =:D_Name )";
            cmd.Parameters.Add("D_Name", Combo_Box_of_DEP.SelectedItem.ToString());
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            dt.Rows.Clear();
            row = dt.NewRow();
            while (dr.Read())
            {

                row["Title"] = dr[0].ToString();
                row["Description"] = dr[2].ToString();
                row["Capacity"] = dr[1].ToString();
                row["Request Stautue"] = dr[3].ToString();
                row["Start Time"] = dr[5].ToString();
                row["Date"] = dr[6].ToString();
                row["Location Name"] = dr[4].ToString();

                dt.Rows.Add(row);
                row = dt.NewRow();
            }
            dr.Close();

            int num;
            int counter = 0;
            dataGridView1.Rows.Clear();
            foreach (DataRow drow in dt.Rows)
            {
                num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[counter].Value = drow["Title"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Description"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Capacity"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Request Stautue"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Date"].ToString();
                counter++;
                dataGridView1.Rows[num].Cells[counter].Value = drow["Location Name"].ToString();
                counter++;
                counter = 0;
            }


        }

        private void Combo_Box_of_DEP_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Add_Member_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            addMember v = new addMember();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }

        private void View_Jobs_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewJobs v = new viewJobs();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }

        private void View_E_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 v = new Form2();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }
    }
}
