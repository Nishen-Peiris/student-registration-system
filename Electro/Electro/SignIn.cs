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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        //Initialize variables...

        int a;

        //Close button...

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Username changed...

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (textBox1.Text == "ni")
                {
                    SignedIn nextform = new SignedIn();
                    nextform.Show();
                    Close();
                }
                else
                {

                }
            }
            else
            {
                if (textBox1.Text == "ni")
                {
                    a = 1;
                }
                else
                {

                }
            }
        }

        //Password changed...

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (textBox2.Text == "12")
                {
                    SignedIn nextform = new SignedIn();
                    nextform.Show();
                    Close();
                }
                else
                {

                }
            }
            else
            {
                if (textBox2.Text == "12")
                {
                    a = 1;
                }
                else
                {

                }
            }
        }
    }
}
