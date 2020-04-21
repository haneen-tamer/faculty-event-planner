using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyEventPlanner
{
    public partial class EventsByDepForm : Form
    {
        EventsByDepartment rep;
        public EventsByDepForm()
        {
            InitializeComponent();
        }

        private void EventsByDepForm_Load(object sender, EventArgs e)
        {
            rep = new EventsByDepartment();
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
            rep.SetParameterValue(0, stTxt.Text);
            rep.SetParameterValue(1, etTxt.Text);
            crv.ReportSource = rep;
        }
    }
}
