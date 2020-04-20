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
        OracleCommand cmd,cmd2;
        OracleDataReader Dr1,Dr2;
        DataTable dt = new DataTable();
        DataRow row;

        public View_Violations()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("User");
            dt.Columns.Add("Number of Violations");
            row = dt.NewRow();
        }

        private void View_closing(object sender, FormClosedEventArgs e)
        {
            OracleHelper.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Violations_Load(object sender, EventArgs e)
        {
            
            cmd = new OracleCommand();
            cmd.Connection= OracleHelper.getConnection();
            cmd.CommandText = @"Select h.user_name
                  from Host h, violations v
                  where h.e_title= v.e_title";
            cmd.CommandType = CommandType.Text;
            cmd2 = new OracleCommand();
            cmd2.Connection = OracleHelper.getConnection();
            cmd2.CommandText = @"Select count(v.e_title)
            from Host h, violations v
            where h.user_name=:Name and h.e_title= v.e_title";
            cmd2.CommandType = CommandType.Text;
            Dr1 = cmd.ExecuteReader();
            
            while(Dr1.Read())
            {
                row["User"] = Dr1[0].ToString();
                cmd2.Parameters.Add(Name,Dr1[0].ToString());
                Console.WriteLine(Dr1[0].ToString());
                Dr2 = cmd2.ExecuteReader();
                row["Number Of Violations"] = Dr2[0].ToString();
                Console.WriteLine(Dr2[0].ToString());
                dt.Rows.Add(row);
                row = dt.NewRow();
            }
            Dr1.Close();
            if(Dr2!=null)
            Dr2.Close();
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
