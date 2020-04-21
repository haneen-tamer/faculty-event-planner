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
    public partial class View_Violations : Form
    {
        OracleCommand cmd,cmd2,cmd3;
        OracleDataReader Dr1,Dr2;
        DataTable dt = new DataTable();
        DataRow row;
        DataGridViewButtonColumn btns_Block;

        public View_Violations()
        {
            InitializeComponent();
            dt = new DataTable();
            cmd = new OracleCommand();
            dt.Columns.Add("User");
            dt.Columns.Add("Number of Violations");
            row = dt.NewRow();
            btns_Block = new DataGridViewButtonColumn();
            btns_Block.HeaderText = "Block Button";
            btns_Block.Text = "Block";
            btns_Block.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btns_Block);
        }

        private void View_closing(object sender, FormClosedEventArgs e)
        {
            OracleHelper.closeConnection();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome v = new AdminHome();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                cmd3 = new OracleCommand();
                cmd3.Connection = OracleHelper.getConnection();
                cmd3.CommandText = "select E_title from Host where user_name=:name";
                int index = e.RowIndex;
                cmd3.Parameters.Add("name", dt.Rows[e.RowIndex]["User"].ToString());
                Dr2 = cmd3.ExecuteReader();
                while(Dr2.Read())
                {
                    cmd3 = new OracleCommand();
                    cmd3.Connection = OracleHelper.getConnection();
                    cmd3.CommandText = "Delete from Host where e_title=:name";
         
                    cmd3.Parameters.Add("name",Dr2[0].ToString());
                    cmd3.ExecuteNonQuery();

                    cmd3 = new OracleCommand();
                    cmd3.Connection = OracleHelper.getConnection();
                    cmd3.CommandText = "Delete  from violations where e_title=:name";

                    cmd3.Parameters.Add("name", Dr2[0].ToString());
                    cmd3.ExecuteNonQuery();

                    cmd3 = new OracleCommand();
                    cmd3.Connection = OracleHelper.getConnection();
                    cmd3.CommandText = "Delete from Event where title=:name";
                    cmd3.Parameters.Add("name", Dr2[0].ToString());
                    cmd3.ExecuteNonQuery();
              
                }
                Dr2.Close();
                cmd3 = new OracleCommand();
                cmd3.Connection = OracleHelper.getConnection();
                cmd3.CommandText = "Delete from users where user_name=:name";
                cmd3.Parameters.Add("name", dt.Rows[e.RowIndex]["User"].ToString());
                int r= cmd3.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("User deleted");
                    dataGridView1.Rows.RemoveAt(index);
                }
                
 
            }
        }

        private void View_Violations_Load(object sender, EventArgs e)
        {
            //data load 
            //users_load
            cmd.Connection= OracleHelper.getConnection();
            cmd.CommandText = @"Select DISTINCT  h.user_name
                  from Host h, violations v
                  where h.e_title= v.e_title";
            cmd.CommandType = CommandType.Text;
            Dr1 = cmd.ExecuteReader();
            while(Dr1.Read())
            {
                row["User"] = Dr1[0].ToString();
                dt.Rows.Add(row);
                row = dt.NewRow();
            }
            Dr1.Close();


            //number of violations 
            for (int i=0;i<dt.Rows.Count;i++)
            {
                cmd2 = new OracleCommand();
                cmd2.Connection = OracleHelper.getConnection();
                cmd2.CommandText = "get_count_of_violations";
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("name_",dt.Rows[i]["User"].ToString());
                cmd2.Parameters.Add("count_", OracleDbType.Int32, ParameterDirection.Output);
                cmd2.ExecuteNonQuery();
                dt.Rows[i]["Number Of Violations"] = cmd2.Parameters["count_"].Value.ToString();
            }
      

            //data_grid_view
            int count = 0;
            int num;
            foreach(DataRow Drow in dt.Rows)
            {
                num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[count].Value = Drow["User"].ToString();
                count++;
                dataGridView1.Rows[num].Cells[count].Value = Drow["Number Of Violations"].ToString();
                count = 0;
                num = 0;
            }
            
        }
    }
}
