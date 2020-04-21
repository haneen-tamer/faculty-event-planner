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
using System.Collections;

namespace FacultyEventPlanner
{
    public partial class Form2 : Form
    {
        ArrayList arr;
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleCommand Event = new OracleCommand();
            Event.Connection = OracleHelper.getConnection();
            Event.CommandType = CommandType.Text;
            Event.CommandText = @"select event.title,event.capacity,event.description,event.l_name,event.ls_start_time,event.ls_date, department.d_title, locations_schedule.end_time
            from event , department, locations_schedule
            where event.d_id = department.d_id
            and event.ls_start_time= locations_schedule.start_time
            and event.ls_date = locations_schedule.date_
            and event.l_name = locations_schedule.l_name
            and title=:combobox";
            Event.Parameters.Add("combobox",comboBox1.SelectedItem.ToString());
            OracleDataReader or = Event.ExecuteReader();
            while (or.Read())
            {
                textBox2.Text=or[1].ToString();
                textBox3.Text = or[2].ToString();
                textBox4.Text = or[3].ToString();
                textBox5.Text = or[4].ToString();
                textBox6.Text = or[5].ToString();
            }
            or.Close();







        }

        private void Form2_Load(object sender, EventArgs e)
        {
            violation.Visible = false;
            arr = new ArrayList();
            OracleCommand Eventreq = new OracleCommand();
            Eventreq.Connection = OracleHelper.getConnection();
            Eventreq.CommandType = CommandType.Text;
            Eventreq.CommandText = "select TITLE from EVENT where REQUEST_STATUS='pending'";
            OracleDataReader or = Eventreq.ExecuteReader();
            while (or.Read())
            {
                comboBox1.Items.Add(or[0].ToString());
                arr.Add(or[0]);

            }
            or.Close();

            







        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand reqaccept = new OracleCommand();
            reqaccept.Connection = OracleHelper.getConnection();
            reqaccept.CommandType = CommandType.Text;
            reqaccept.CommandText = @"update EVENT set REQUEST_STATUS ='accepted'
            where title=:event_title";
            reqaccept.Parameters.Add("event_title",comboBox1.SelectedItem.ToString());
            reqaccept.ExecuteNonQuery();
            reqaccept = new OracleCommand();
            reqaccept.Connection = OracleHelper.getConnection();
            reqaccept.CommandType = CommandType.Text;
            reqaccept.CommandText = "update Locations_schedule set STATUS ='Busy' where l_name=(select l_name from event where title=:event_title)";
            reqaccept.Parameters.Add("event_title", comboBox1.SelectedItem.ToString());
            int k;
            k = reqaccept.ExecuteNonQuery();
            if (k != -1)
            {
                MessageBox.Show("Event is accepted successfully");
                  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            violation.Visible = true;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand reqreject = new OracleCommand();
            reqreject.Connection = OracleHelper.getConnection();
            reqreject.CommandType = CommandType.Text;
            reqreject.CommandText = "update EVENT set REQUEST_STATUS ='rejected' where title=:e_title";
            reqreject.Parameters.Add("e_title", comboBox1.SelectedItem.ToString());
            reqreject.ExecuteNonQuery();

            reqreject = new OracleCommand();
            reqreject.Connection = OracleHelper.getConnection();
            reqreject.CommandType = CommandType.Text;
            reqreject.CommandText = "update Locations_schedule set STATUS ='Available' where l_name=(select l_name from event where title=:event_title)";
            reqreject.Parameters.Add("event_title", comboBox1.SelectedItem.ToString());
            int k;
            k = reqreject.ExecuteNonQuery();
            if (k != -1)
            {
                MessageBox.Show("Event is rejected");

            }










        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void violation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand reqviolation = new OracleCommand();
            reqviolation.Connection = OracleHelper.getConnection();
            reqviolation.CommandType = CommandType.Text;
            reqviolation.CommandText = "update EVENT set REQUEST_STATUS ='rejected' where title=:e_title";
            reqviolation.Parameters.Add("e_title", comboBox1.SelectedItem.ToString());
            reqviolation.ExecuteNonQuery();

            reqviolation = new OracleCommand();
            reqviolation.Connection = OracleHelper.getConnection();
            reqviolation.CommandType = CommandType.Text;
            reqviolation.CommandText = "update Locations_schedule set STATUS ='Available' where l_name=(select l_name from event where title=:event_title)";
            reqviolation.Parameters.Add("event_title", comboBox1.SelectedItem.ToString());
            reqviolation.ExecuteNonQuery();

            reqviolation = new OracleCommand();
            reqviolation.Connection = OracleHelper.getConnection();
            reqviolation.CommandType = CommandType.Text;
            reqviolation.CommandText = "insert into violations values(:r,:e)";
            reqviolation.Parameters.Add("r", textBox1.Text);
            reqviolation.Parameters.Add("e", comboBox1.SelectedItem.ToString());
            int k = reqviolation.ExecuteNonQuery();
            if (k != -1)
            {
                MessageBox.Show("Violation is recorded");

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
