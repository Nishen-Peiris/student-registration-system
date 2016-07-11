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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }

        int a;

        private void pbFormreg_Click(object sender, EventArgs e)
        {
            Close();
            Register nextform = new Register();
            nextform.Show();
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            pbFulSe.Visible = false;
            pbDOBSe.Visible = false;
            pbDORSe.Visible = false;
            pbemaSe.Visible = false;
            pbCouSe.Visible = false;

            fillByFullnameToolStrip.Visible = false;
            fillByDOBToolStrip.Visible = false;
            fillByDOR3ToolStrip.Visible = false;
            fillByemailToolStrip.Visible = false;
            fillByCoursesToolStrip.Visible = false;

            numerDate.Visible = false;
            numerMonth.Visible = false;
            numerYear.Visible = false;

            label1.Visible = false;

            dataGridView1.Visible = false;

            panel1.Visible = false;

            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
        }

        private void pbFulSea_Click(object sender, EventArgs e)
        {
        }

        private void pbDOBSea_Click(object sender, EventArgs e)
        {

        }

        private void pbDORSea_Click(object sender, EventArgs e)
        {

        }

        private void pbemaSea_Click(object sender, EventArgs e)
        {

        }

        private void pbCouSea_Click(object sender, EventArgs e)
        {

        }

        private void pbFul_Click(object sender, EventArgs e)
        {
            pbFulSe.Visible = true;
            pbDOBSe.Visible = false;
            pbDORSe.Visible = false;
            pbemaSe.Visible = false;
            pbCouSe.Visible = false;

            fillByFullnameToolStrip.Visible = true;
            fillByDOBToolStrip.Visible = false;
            fillByDOR3ToolStrip.Visible = false;
            fillByemailToolStrip.Visible = false;
            fillByCoursesToolStrip.Visible = false;

            numerDate.Visible = false;
            numerMonth.Visible = false;
            numerYear.Visible = false;

            label1.Visible = false;

            dataGridView1.Visible = false;

            panel1.Visible = false;
        }

        private void pbDOB_Click(object sender, EventArgs e)
        {
            pbDOBSe.Visible = true;
            pbFulSe.Visible = false;
            pbDORSe.Visible = false;
            pbemaSe.Visible = false;
            pbCouSe.Visible = false;

            fillByDOBToolStrip.Visible = true;
            fillByFullnameToolStrip.Visible = false;
            fillByDOR3ToolStrip.Visible = false;
            fillByemailToolStrip.Visible = false;
            fillByCoursesToolStrip.Visible = false;

            numerDate.Visible = true;
            numerMonth.Visible = true;
            numerYear.Visible = true;

            label1.Visible = true;

            dataGridView1.Visible = false;

            panel1.Visible = false;
        }

        private void pbDOR_Click(object sender, EventArgs e)
        {
            pbDORSe.Visible = true;
            pbFulSe.Visible = false;
            pbDOBSe.Visible = false;
            pbemaSe.Visible = false;
            pbCouSe.Visible = false;

            fillByDOR3ToolStrip.Visible = true;
            fillByFullnameToolStrip.Visible = false;
            fillByDOBToolStrip.Visible = false;
            fillByemailToolStrip.Visible = false;
            fillByCoursesToolStrip.Visible = false;

            numerDate.Visible = true;
            numerMonth.Visible = true;
            numerYear.Visible = true;

            label1.Visible = true;

            dataGridView1.Visible = false;

            panel1.Visible = false;
        }

        private void pbema_Click(object sender, EventArgs e)
        {
            pbemaSe.Visible = true;
            pbFulSe.Visible = false;
            pbDOBSe.Visible = false;
            pbDORSe.Visible = false;
            pbCouSe.Visible = false;

            fillByemailToolStrip.Visible = true;
            fillByFullnameToolStrip.Visible = false;
            fillByDOBToolStrip.Visible = false;
            fillByDOR3ToolStrip.Visible = false;
            fillByCoursesToolStrip.Visible = false;

            numerDate.Visible = false;
            numerMonth.Visible = false;
            numerYear.Visible = false;

            label1.Visible = false;

            dataGridView1.Visible = false;

            panel1.Visible = false;
        }

        private void pbCou_Click(object sender, EventArgs e)
        {
            pbCouSe.Visible = true;
            pbemaSe.Visible = false;
            pbFulSe.Visible = false;
            pbDOBSe.Visible = false;
            pbDORSe.Visible = false;
            pbemaSe.Visible = false;

            fillByCoursesToolStrip.Visible = true;
            fillByFullnameToolStrip.Visible = false;
            fillByDOBToolStrip.Visible = false;
            fillByDOR3ToolStrip.Visible = false;
            fillByemailToolStrip.Visible = false;

            numerDate.Visible = false;
            numerMonth.Visible = false;
            numerYear.Visible = false;

            label1.Visible = false;

            dataGridView1.Visible = true;

            panel1.Visible = true;
        }

        private void fillByFullnameToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                this.table1TableAdapter.FillByFullname(this.database1DataSet.Table1, fullnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDOBToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dOBToolStripTextBox.Text = Convert.ToString(numerYear.Value) + "." + Convert.ToString(numerMonth.Value) + "." + Convert.ToString(numerDate.Value);
            try
            {
                this.table1TableAdapter.FillByDOB(this.database1DataSet.Table1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dOBToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void fillByDORToolStripButton_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Visible = true;
        //    ////dORToolStripTextBox.Text = Convert.ToString(numerYear.Value) + "." + Convert.ToString(numerMonth.Value) + "." + Convert.ToString(numerDate.Value);
        //    try
        //    {
        //        this.table1TableAdapter.FillByDOR(this.database1DataSet.Table1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dORToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void fillByemailToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                this.table1TableAdapter.FillByemail(this.database1DataSet.Table1, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByCoursesToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cb9_CheckedChanged(object sender, EventArgs e)
        {
            courseSummaryToolStripTextBox.Text = "";

            if (cb1.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = "Diploma,     ";
            }
            if (cb2.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Application Assistant,     ";
            }
            if (cb3.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Students (Year 6 - 8),     ";
            }
            if (cb4.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Kids From Basic (Year 1 - 5),     ";
            }
            if (cb5.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Photoshop Media and Web Designing (HTML),     ";
            }
            if (cb6.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "O/L ICT,     ";
            }
            if (cb7.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "A/L GIT,     ";
            }
            if (cb8.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "ASP.Net with C# and Database,     ";
            }
            if (cb9.Checked == true)
            {
                courseSummaryToolStripTextBox.Text = courseSummaryToolStripTextBox.Text + "Basic Computer Hardware";
            }

            try
            {
                this.table1TableAdapter.FillByCourses(this.database1DataSet.Table1, courseSummaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            Search nextform = new Search();
            nextform.Show();
        }

        private void pbFormsea_Click(object sender, EventArgs e)
        {
            Close();
            Search nextform = new Search();
            nextform.Show();
        }

        private void pbClo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbFormexa_Click(object sender, EventArgs e)
        {
            Close();
            ExamResults nextform = new ExamResults();
            nextform.Show();
        }

        private void pbFormfee_Click(object sender, EventArgs e)
        {
            Close();
            FeeReceived nextform = new FeeReceived();
            nextform.Show();
        }

        private void fillByDOR1ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.table1TableAdapter.FillByDOR1(this.database1DataSet.Table1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dORToolStripTextBox1.Text, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillByDOR2ToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByDOR3ToolStripButton_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(numerDate.Value);
            a = a + 1;

            dataGridView1.Visible = true;
            dOR1ToolStripTextBox.Text = Convert.ToString(numerYear.Value) + "." + Convert.ToString(numerMonth.Value) + "." + Convert.ToString(numerDate.Value);
            dORToolStripTextBox.Text = Convert.ToString(numerYear.Value) + "." + Convert.ToString(numerMonth.Value) + "." + Convert.ToString(a);
            try
            {
                this.table1TableAdapter.FillByDOR3(this.database1DataSet.Table1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dOR1ToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dORToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void fillByDOR21ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.table1TableAdapter.FillByDOR21(this.database1DataSet.Table1, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dORToolStripTextBox2.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
