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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminHome AH = new AdminHome();
            AH.Closed += (s, args) => this.Close();
            AH.Show();


            //// aya////

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome uh = new UserHome();
            uh.Closed += (s, args) => this.Close();
            uh.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            OracleHelper.closeConnection();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    }
}
