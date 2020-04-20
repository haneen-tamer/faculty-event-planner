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
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            #region Job comboBox

            OracleCommand Job = new OracleCommand();
            Job.Connection = OracleHelper.getConnection();
            Job.CommandText = "select JOB_TITLE from JOB";
            Job.CommandType = CommandType.Text;
            OracleDataReader Job_reader = Job.ExecuteReader();
            while (Job_reader.Read())
            {
                comboBox1.Items.Add(Job_reader[0].ToString());
            }
            Job_reader.Close();

            #endregion


            #region Department Combobox
            OracleCommand Dept = new OracleCommand();
            Job.Connection = OracleHelper.getConnection();
            Job.CommandText = "select D_TITLE from Department";
            Job.CommandType = CommandType.Text;
            OracleDataReader dep_reader = Dept.ExecuteReader();
            while (dep_reader.Read())
            {
                comboBox2.Items.Add(dep_reader[0].ToString());
            }
            dep_reader.Close();

            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand insert_values = new OracleCommand();
            insert_values.Connection = OracleHelper.getConnection();
            insert_values.CommandType = CommandType.Text;
            insert_values.CommandText = "insert into user values(:Username ,: FName, :LName, :TemporaryPassword, :Department,:Job, :Email) ";
            insert_values.Parameters.Add("Username", textBox3.Text);
            insert_values.Parameters.Add("FName", textBox1.Text);
            insert_values.Parameters.Add("LName", textBox2.Text);
            insert_values.Parameters.Add("TemporaryPassword", textBox4.Text);
            insert_values.Parameters.Add("Department", comboBox2.SelectedItem.ToString());
            insert_values.Parameters.Add("Job", comboBox1.SelectedItem.ToString());
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
