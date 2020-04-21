using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace FacultyEventPlanner
{
    public partial class ViolationsRepForm : Form
    {
        ViolationsReport rep;
        public ViolationsRepForm()
        {
            InitializeComponent();
        }

        private void ViolationsRepForm_Load(object sender, EventArgs e)
        {
            rep = new ViolationsReport();
            foreach (ParameterDiscreteValue v in rep.Parameter_HostJob.DefaultValues)
                jobCB.Items.Add(v.Value);
            foreach (ParameterDiscreteValue v in rep.Parameter_HostDepartment.DefaultValues)
                depCB.Items.Add(v.Value);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome v = new AdminHome();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }

        private void generateRepBtn_Click(object sender, EventArgs e)
        {
            rep.SetParameterValue(0, jobCB.Text);
            rep.SetParameterValue(1, depCB.Text);
            crv.ReportSource = rep;
        }
    }
}
