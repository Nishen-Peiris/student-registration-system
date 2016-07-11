using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Electro
{
    public partial class SignedIn : Form
    {
        public SignedIn()
        {
            InitializeComponent();
        }

        //Close button...

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Register button...

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            Register nextform = new Register();
            nextform.Show();
        }

        //Fee Received button...

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            FeeReceived nextform = new FeeReceived();
            nextform.Show();
        }

        //Exam Results button...

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            ExamResults nextform = new ExamResults();
            nextform.Show();
        }

        //Search button...

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
            Search nextform = new Search();
            nextform.Show();
        }
    }
}
