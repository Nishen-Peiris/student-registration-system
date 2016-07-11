using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Electro
{
    public partial class FeeReceived : Form
    {
        public FeeReceived()
        {
            InitializeComponent();
        }

        public string GetConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["Electro.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void ExecuteUpdate(string Fullname, string Payments)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "update Table1 set Payments = @Payments where (Fullname = @Fullname)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[2];
                //param[0] = new SqlParameter("@id", SqlDbType.Int, 20);
                param[0] = new SqlParameter("@Fullname", SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@Payments", SqlDbType.VarChar);

                param[0].Value = Fullname;
                param[1].Value = Payments;

                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
        }

        //Form Load...

        private void FeeReceived_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        //Minimize button...

        private void pbMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Close button...

        private void pbClo_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Register buton...

        private void pbFormReg_Click(object sender, EventArgs e)
        {
            Close();
            Register nextform = new Register();
            nextform.Show();
        }

        //Exam Results button...

        private void pbFormexa_Click(object sender, EventArgs e)
        {
            Close();
            ExamResults nextform = new ExamResults();
            nextform.Show();
        }

        //Search button...

        private void pbFormsea_Click(object sender, EventArgs e)
        {
            Close();
            Search nextform = new Search();
            nextform.Show();
        }

        //Received button...

        private void pbReceived_Click(object sender, EventArgs e)
        {
            if (txtAmo.Text == "")
            {
                panel1.Visible = true;
                comboBox1.Enabled = false;
                dataGridView1.Enabled = false;
                txtAmo.Enabled = false;
                comboBox2.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbReceived.Enabled = false;
                pbFormReg.Enabled = false;
                pbFormexa.Enabled = false;
                pbFormsea.Enabled = false;
            }
            else if (txtCom.Text == "")
            {
                panel2.Visible = true;
                comboBox1.Enabled = false;
                dataGridView1.Enabled = false;
                txtAmo.Enabled = false;
                comboBox2.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbReceived.Enabled = false;
                pbFormReg.Enabled = false;
                pbFormexa.Enabled = false;
                pbFormsea.Enabled = false;
            }
            else
            {
                txtPay.Text = Convert.ToString(listBox1.SelectedValue) + "Rs : " + txtAmo.Text + " - " + txtCom.Text + " - " + Convert.ToString(dateTimePicker1.Value) + ",     ";
                ExecuteUpdate(txtFul.Text, txtPay.Text);
                panel3.Visible = true;
                comboBox1.Enabled = false;
                dataGridView1.Enabled = false;
                txtAmo.Enabled = false;
                comboBox2.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbReceived.Enabled = false;
                pbFormReg.Enabled = false;
                pbFormexa.Enabled = false;
                pbFormsea.Enabled = false;
            }
        }

        //Messagebox button...

        private void btnOKp1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            comboBox1.Enabled = true;
            dataGridView1.Enabled = true;
            txtAmo.Enabled = true;
            comboBox2.Enabled = true;
            pbClo.Enabled = true;
            pbMin.Enabled = true;
            pbReceived.Enabled = true;
            pbFormReg.Enabled = true;
            pbFormexa.Enabled = true;
            pbFormsea.Enabled = true;
        }

        //Messagebox button...

        private void btnOKp2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            comboBox1.Enabled = true;
            dataGridView1.Enabled = true;
            txtAmo.Enabled = true;
            comboBox2.Enabled = true;
            pbClo.Enabled = true;
            pbMin.Enabled = true;
            pbReceived.Enabled = true;
            pbFormReg.Enabled = true;
            pbFormexa.Enabled = true;
            pbFormsea.Enabled = true;
        }

        //Messagebox button...

        private void btnOKp3_Click(object sender, EventArgs e)
        {
            Close();
            SignedIn nextform = new SignedIn();
            nextform.Show();
        }

        //Combobox1...

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFul.Text = Convert.ToString(comboBox1.SelectedValue);
        }

        //Combobox2...

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCom.Text = Convert.ToString(comboBox2.SelectedItem);
        }
    }
}
