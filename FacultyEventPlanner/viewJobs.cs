﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Collections;

namespace FacultyEventPlanner
{
    public partial class viewJobs : Form
    {
        string constractor = "Data Source = Orcl ; User Id = Scott ; Password= tiger;";
        OracleDataAdapter adapt;
        DataSet ds;
        public viewJobs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewJobs_Load(object sender, EventArgs e)
        {
            
            string striing = "Select * from JOB ";
            adapt  = new OracleDataAdapter(striing,constractor);
            ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapt);
            adapt.Update(ds.Tables[0]);
        }
    }
}
