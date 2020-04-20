using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class addMember : Form
    {
        ArrayList dids, jids;
        public addMember()
        {
            InitializeComponent();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            dids = new ArrayList();
            jids = new ArrayList();
            #region Job comboBox

            OracleCommand Job = new OracleCommand();
            Job.Connection = OracleHelper.getConnection();
            Job.CommandText = "select * from JOB";
            Job.CommandType = CommandType.Text;
            OracleDataReader Job_reader = Job.ExecuteReader();
            while (Job_reader.Read())
            {
                comboBox1.Items.Add(Job_reader[1].ToString());
                jids.Add(Job_reader[0]);
            }
            Job_reader.Close();

            #endregion


            #region Department Combobox
            OracleCommand Dept = new OracleCommand();
            Dept.Connection = OracleHelper.getConnection();

            Dept.CommandText = "select * from department";

            Dept.CommandType = CommandType.Text;
            OracleDataReader dep_reader = Dept.ExecuteReader();
            while (dep_reader.Read())
            {
                comboBox2.Items.Add(dep_reader[1].ToString());
                dids.Add(dep_reader[0]);
            }
            dep_reader.Close();

            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand insert_values = new OracleCommand();
            insert_values.Connection = OracleHelper.getConnection();
            insert_values.CommandType = CommandType.Text;
            insert_values.CommandText = "insert into users values(: FName, :LName, :Username , :TemporaryPassword, :Department,:Job, :Email) ";
            insert_values.Parameters.Add("FName", textBox1.Text);
            insert_values.Parameters.Add("LName", textBox2.Text);
            insert_values.Parameters.Add("Username", textBox3.Text);
            insert_values.Parameters.Add("TemporaryPassword", textBox4.Text);
            insert_values.Parameters.Add("Department", dids[comboBox2.SelectedIndex]);
            insert_values.Parameters.Add("Job", jids[comboBox1.SelectedIndex]);
            insert_values.Parameters.Add("Email", textBox5.Text);
            int x;
            x = insert_values.ExecuteNonQuery();
            if (x != -1)
            {
                MessageBox.Show("Member is Added Successfully");
            }
        }
    }
}
