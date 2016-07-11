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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        int a;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 5;
            //while (a < 25000)
            //{
            //    textBox1.Text = Convert.ToString(a);
            //    a = a + 1;
            //}
            //progressBar1.Value = 20;
            //while (a < 50000)
            //{
            //    textBox1.Text = Convert.ToString(a);
            //    a = a + 1;
            //}
            //progressBar1.Value = 50;
            //while (a < 60000)
            //{
            //    textBox1.Text = Convert.ToString(a);
            //    a = a + 1;
            //}
            //progressBar1.Value = 75;
            //while (a < 70000)
            //{
            //    textBox1.Text = Convert.ToString(a);
            //    a = a + 1;
            //}
            //progressBar1.Value = 90;
            //while (a < 75000)
            //{
            //    textBox1.Text = Convert.ToString(a);
            //    a = a + 1;
            //}

            //Timer1 Start...

            timer1.Start();

            //Progressbar1 Value...

            progressBar1.Value = 10;

            //Close();
            //SignIn nextform = new SignIn();
            //nextform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Timer1 Tick...

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Show Nexxt Form...

            if (progressBar1.Value == 90)
            {
                Close();
                SignIn nf = new SignIn();
                nf.Show();
            }
            else
            {
                timer1.Start();
                progressBar1.Value = progressBar1.Value + 40;
            }
        }
    }
}
