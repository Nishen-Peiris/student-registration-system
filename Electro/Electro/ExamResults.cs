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
    public partial class ExamResults : Form
    {
        public ExamResults()
        {
            InitializeComponent();
        }

        public string GetConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["Electro.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void ExecuteUpdate(string Fullname, string Examresults)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "update Table1 set Examresults = @Examresults where (Fullname = @Fullname)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[2];
                //param[0] = new SqlParameter("@id", SqlDbType.Int, 20);
                param[0] = new SqlParameter("@Fullname", SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@Examresults", SqlDbType.VarChar);

                param[0].Value = Fullname;
                param[1].Value = Examresults;

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

        //Minimize button...

        private void pbMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Register button...

        private void pbFormreg_Click(object sender, EventArgs e)
        {
            Close();
            Register nextform = new Register();
            nextform.Show();
        }

        //Fee Received button...

        private void pbFormfee_Click(object sender, EventArgs e)
        {
            Close();
            FeeReceived nextform = new FeeReceived();
            nextform.Show();
        }

        //Search button...

        private void pbFormsea_Click(object sender, EventArgs e)
        {
            Close();
            Search nextform = new Search();
            nextform.Show();
        }

        //Add button...

        private void pbAdd_Click(object sender, EventArgs e)
        {
            txtCom.Text = Convert.ToString(comboBox2.SelectedItem);
            if (txtCom.Text == "")
            {
                panel1.Visible = true;
                comboBox1.Enabled = false;
                dataGridView1.Enabled = false;
                comboBox2.Enabled = false;
                txtDes.Enabled = false;
                txtMar.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbAdd.Enabled = false;
                pbFormreg.Enabled = false;
                pbFormfee.Enabled = false;
                pbFormsea.Enabled = false;
            }
            else if (txtMar.Text == "")
            {
                panel2.Visible = true;
                comboBox1.Enabled = false;
                dataGridView1.Enabled = false;
                comboBox2.Enabled = false;
                txtDes.Enabled = false;
                txtMar.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbAdd.Enabled = false;
                pbFormreg.Enabled = false;
                pbFormfee.Enabled = false;
                pbFormsea.Enabled = false;
            }
            else
            {
                txtFul.Text = Convert.ToString(comboBox1.SelectedValue);
                txtExa.Text = Convert.ToString(listBox1.SelectedValue) + Convert.ToString(comboBox2.SelectedItem) + " - " + txtDes.Text + " - " + txtMar.Text + ",     ";
                ExecuteUpdate(txtFul.Text, txtExa.Text);
                panel3.Visible = true;
                comboBox1.Enabled = false;
                dataGridView1.Enabled = false;
                comboBox2.Enabled = false;
                txtDes.Enabled = false;
                txtMar.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbAdd.Enabled = false;
                pbFormreg.Enabled = false;
                pbFormfee.Enabled = false;
                pbFormsea.Enabled = false;
            }
        }

        //Close button...

        private void pbClo_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Load...

        private void ExamResults_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
        }

        //Messagebox button...

        private void btnOKp1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            comboBox1.Enabled = true;
            dataGridView1.Enabled = true;
            comboBox2.Enabled = true;
            txtDes.Enabled = true;
            txtMar.Enabled = true;
            pbClo.Enabled = true;
            pbMin.Enabled = true;
            pbAdd.Enabled = true;
            pbFormreg.Enabled = true;
            pbFormfee.Enabled = true;
            pbFormsea.Enabled = true;
        }

        //Messagebox button...

        private void btnOKp2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            comboBox1.Enabled = true;
            dataGridView1.Enabled = true;
            comboBox2.Enabled = true;
            txtDes.Enabled = true;
            txtMar.Enabled = true;
            pbClo.Enabled = true;
            pbMin.Enabled = true;
            pbAdd.Enabled = true;
            pbFormreg.Enabled = true;
            pbFormfee.Enabled = true;
            pbFormsea.Enabled = true;
        }

        //Messagebox button...

        private void btnOKp3_Click(object sender, EventArgs e)
        {
            Close();
            SignedIn nextform = new SignedIn();
            nextform.Show();
        }
    }
}
