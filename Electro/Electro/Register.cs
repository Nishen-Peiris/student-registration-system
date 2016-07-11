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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public string GetConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["Electro.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void ExecuteInsert(string Fullname, string DOB, string Address, string Homephone, string Mobilephone, string email, string Coursesummary, string C1, string C2, string C3, string C4, string C5, string C6, string C7, string C8, string C9, string DOR)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO Table1 (Fullname, DOB, Address, Homephone, Mobilephone, email, Coursesummary, C1, C2, C3, C4, C5, C6, C7, C8, C9, DOR) VALUES "
                        + " (@Fullname, @DOB, @Address, @Homephone, @Mobilephone, @email, @Coursesummary, @C1, @C2, @C3, @C4, @C5, @C6, @C7, @C8, @C9, @DOR)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[17];
                //param[0] = new SqlParameter("@id", SqlDbType.Int, 20);
                param[0] = new SqlParameter("@Fullname", SqlDbType.VarChar);
                param[1] = new SqlParameter("@DOB", SqlDbType.DateTime);
                param[2] = new SqlParameter("@Address", SqlDbType.VarChar);
                param[3] = new SqlParameter("@Homephone", SqlDbType.VarChar, 50);
                param[4] = new SqlParameter("@Mobilephone", SqlDbType.VarChar, 50);
                param[5] = new SqlParameter("@email", SqlDbType.VarChar);
                param[6] = new SqlParameter("@Coursesummary", SqlDbType.VarChar);
                param[7] = new SqlParameter("@C1", SqlDbType.VarChar, 50);
                param[8] = new SqlParameter("@C2", SqlDbType.VarChar, 50);
                param[9] = new SqlParameter("@C3", SqlDbType.VarChar, 50);
                param[10] = new SqlParameter("@C4", SqlDbType.VarChar, 50);
                param[11] = new SqlParameter("@C5", SqlDbType.VarChar, 50);
                param[12] = new SqlParameter("@C6", SqlDbType.VarChar, 50);
                param[13] = new SqlParameter("@C7", SqlDbType.VarChar, 50);
                param[14] = new SqlParameter("@C8", SqlDbType.VarChar, 50);
                param[15] = new SqlParameter("@C9", SqlDbType.VarChar, 50);
                param[16] = new SqlParameter("@DOR", SqlDbType.DateTime);

                param[0].Value = Fullname;
                param[1].Value = DOB;
                param[2].Value = Address;
                param[3].Value = Homephone;
                param[4].Value = Mobilephone;
                param[5].Value = email;
                param[6].Value = Coursesummary;
                param[7].Value = C1;
                param[8].Value = C2;
                param[9].Value = C3;
                param[10].Value = C4;
                param[11].Value = C5;
                param[12].Value = C6;
                param[13].Value = C7;
                param[14].Value = C8;
                param[15].Value = C9;
                param[16].Value = DOR;

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

        private void Register_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        //Close button...

        private void pbClo_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Minimize button...

        private void pbMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Fee Received button...

        private void pbFormfee_Click(object sender, EventArgs e)
        {
            Close();
            FeeReceived nextform = new FeeReceived();
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

        //Register button...

        private void pbReg_Click(object sender, EventArgs e)
        {
            txtDOB.Text = numerYea.Value + "." + numerMon.Value + "." + numerDat.Value;
            textBox1.Text = Convert.ToString(dateTimePicker1.Value);

            if (chDip.Checked == true)
            {
                txtCourseSummary.Text = "Diploma,     ";
                txtDip.Text = "Diploma";
            }
            if (chApp.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "Application Assistant,     ";
                txtApp.Text = "Application Assistant";
            }
            if (chStu.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "Students (Year 6 - 8),     ";
                txtStu.Text = "Students (Year 6 - 8)";
            }
            if (chKid.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "Kids From Basic (Year 1 - 5),     ";
                txtKid.Text = "Kids From Basic (Year 1 - 5)";
            }
            if (chPho.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "Photoshop Media and Web Designing (HTML),     ";
                txtPho.Text = "Photoshop Media and Web Designing (HTML)";
            }
            if (chOLI.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "O/L ICT,     ";
                txtOLI.Text = "O/L ICT";
            }
            if (chALG.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "A/L GIT,     ";
                txtALG.Text = "A/L GIT";
            }
            if (chASP.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "ASP.Net with C# and Database,     ";
                txtASP.Text = "ASP.Net with C# and Database";
            }
            if (chBas.Checked == true)
            {
                txtCourseSummary.Text = txtCourseSummary.Text + "Basic Computer Hardware";
                txtBas.Text = "Basic Computer Hardware";
            }


            if (txtFul.Text == "")
            {
                panel1.Visible = true;
                txtFul.Enabled = false;
                txtAdd.Enabled = false;
                txtHom.Enabled = false;
                txtMob.Enabled = false;
                txtema.Enabled = false;
                numerDat.Enabled = false;
                numerMon.Enabled = false;
                numerYea.Enabled = false;
                chDip.Enabled = false;
                chApp.Enabled = false;
                chStu.Enabled = false;
                chKid.Enabled = false;
                chPho.Enabled = false;
                chOLI.Enabled = false;
                chALG.Enabled = false;
                chASP.Enabled = false;
                chBas.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbReg.Enabled = false;
                pbFormfee.Enabled = false;
                pbFormexa.Enabled = false;
                pbFormsea.Enabled = false;
            }
            else
            {
                ExecuteInsert(txtFul.Text, txtDOB.Text, txtAdd.Text, txtHom.Text, txtMob.Text, txtema.Text, txtCourseSummary.Text, txtDip.Text, txtApp.Text, txtStu.Text, txtKid.Text, txtPho.Text, txtOLI.Text, txtALG.Text, txtASP.Text, txtBas.Text, textBox1.Text);
                panel2.Visible = true;
                txtFul.Enabled = false;
                txtAdd.Enabled = false;
                txtHom.Enabled = false;
                txtMob.Enabled = false;
                txtema.Enabled = false;
                numerDat.Enabled = false;
                numerMon.Enabled = false;
                numerYea.Enabled = false;
                chDip.Enabled = false;
                chApp.Enabled = false;
                chStu.Enabled = false;
                chKid.Enabled = false;
                chPho.Enabled = false;
                chOLI.Enabled = false;
                chALG.Enabled = false;
                chASP.Enabled = false;
                chBas.Enabled = false;
                pbClo.Enabled = false;
                pbMin.Enabled = false;
                pbReg.Enabled = false;
                pbFormfee.Enabled = false;
                pbFormexa.Enabled = false;
                pbFormsea.Enabled = false;
            }
        }

        //No Name Messagebox button...

        private void btnOKp1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtFul.Enabled = true;
            txtAdd.Enabled = true;
            txtHom.Enabled = true;
            txtMob.Enabled = true;
            txtema.Enabled = true;
            numerDat.Enabled = true;
            numerMon.Enabled = true;
            numerYea.Enabled = true;
            chDip.Enabled = true;
            chApp.Enabled = true;
            chStu.Enabled = true;
            chKid.Enabled = true;
            chPho.Enabled = true;
            chOLI.Enabled = true;
            chALG.Enabled = true;
            chASP.Enabled = true;
            chBas.Enabled = true;
            pbClo.Enabled = true;
            pbMin.Enabled = true;
            pbReg.Enabled = true;
            pbFormfee.Enabled = true;
            pbFormexa.Enabled = true;
            pbFormsea.Enabled = true;
        }

        //Inserted Messagebox button...

        private void btnOKp2_Click(object sender, EventArgs e)
        {
            Close();
            SignedIn nextform = new SignedIn();
            nextform.Show();
        }
    }
}
