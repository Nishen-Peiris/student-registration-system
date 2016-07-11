using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Electro
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void populategridview1_1()
        {
            string sql = "Select * from Table1 order by Fullname";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "Table1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table1";
            }
        }

        private void populategridview1_2()
        {
            string sql = "Select * from Table1 order by Fullname desc";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "Table1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table1";
            }
        }

        private void populategridview2_1()
        {
            string sql = "Select * from Table1 order by DOB";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "Table1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table1";
            }
        }

        private void populategridview2_2()
        {
            string sql = "Select * from Table1 order by DOB desc";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "Table1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table1";
            }
        }

        private void populategridview3_1()
        {
            string sql = "Select * from Table1 order by DOR";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "Table1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table1";
            }
        }

        private void populategridview3_2()
        {
            string sql = "Select * from Table1 order by DOR desc";
            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.Getconnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();
                da.Fill(ds, "Table1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table1";
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            populategridview1_1();
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
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

        private void pbFormreg_Click(object sender, EventArgs e)
        {
            Close();
            Register nextform = new Register();
            nextform.Show();
        }

        private void pbExi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (Convert.ToString(comboBox1.SelectedItem) == "Ascending")
                {
                    populategridview1_1();
                }
                else
                {
                    populategridview1_2();
                }
            }
            else
            {

            }
        }

        private void Search_Load_1(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            populategridview1_1();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (Convert.ToString(comboBox1.SelectedItem) == "Ascending")
                {
                    populategridview2_1();
                }
                else
                {
                    populategridview2_2();
                }
            }
            else
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                if (Convert.ToString(comboBox1.SelectedItem) == "Ascending")
                {
                    populategridview3_1();
                }
                else
                {
                    populategridview3_2();
                }
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (radioButton1.Checked == true)
                {
                    populategridview1_1();
                }
                else if (radioButton2.Checked == true)
                {
                    populategridview2_1();
                }
                else
                {
                    populategridview3_1();
                }
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    populategridview1_2();
                }
                else if (radioButton2.Checked == true)
                {
                    populategridview2_2();
                }
                else
                {
                    populategridview3_2();
                }
            }
        }

        private void pbMor_Click(object sender, EventArgs e)
        {
            Close();
            AdvancedSearch nextform = new AdvancedSearch();
            nextform.Show();
        }

        private void pbClo_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbFormreg_Click_1(object sender, EventArgs e)
        {
            Close();
            Register nextform = new Register();
            nextform.Show();
        }

        private void pbFormfee_Click_1(object sender, EventArgs e)
        {
            Close();
            FeeReceived nextform = new FeeReceived();
            nextform.Show();
        }

        private void pbFormexa_Click_1(object sender, EventArgs e)
        {
            Close();
            ExamResults nextform = new ExamResults();
            nextform.Show();
        }

        private void pbExi_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}