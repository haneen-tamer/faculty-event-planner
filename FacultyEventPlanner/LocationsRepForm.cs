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
    public partial class LocationsRepForm : Form
    {
        LocationRep rep;
        public LocationsRepForm()
        {
            InitializeComponent();
        }

        private void LocationsRepForm_Load(object sender, EventArgs e)
        {
            rep = new LocationRep();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome v = new AdminHome();
            v.FormClosed += (s, args) => this.Close();
            v.Show();
        }

        private void generateRepBtn_Click(object sender, EventArgs e)
        {
            rep.SetParameterValue(0, CapTxt.Text);
            crv.ReportSource = rep;
        }
    }
}
