namespace Electro
{
    partial class FeeReceived
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeReceived));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Electro.Database1DataSet();
            this.table1TableAdapter = new Electro.Database1DataSetTableAdapters.Table1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbClo = new System.Windows.Forms.PictureBox();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pbReceived = new System.Windows.Forms.PictureBox();
            this.pbFormReg = new System.Windows.Forms.PictureBox();
            this.pbFormfee = new System.Windows.Forms.PictureBox();
            this.pbFormexa = new System.Windows.Forms.PictureBox();
            this.pbFormsea = new System.Windows.Forms.PictureBox();
            this.txtAmo = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOKp1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOKp2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOKp3 = new System.Windows.Forms.Button();
            this.txtFul = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CourseSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormfee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormexa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormsea)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.table1BindingSource;
            this.comboBox1.DisplayMember = "Fullname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(515, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Fullname";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseSummary,
            this.paymentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(145, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 55);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(86, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbClo
            // 
            this.pbClo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClo.Image = ((System.Drawing.Image)(resources.GetObject("pbClo.Image")));
            this.pbClo.Location = new System.Drawing.Point(932, 0);
            this.pbClo.Name = "pbClo";
            this.pbClo.Size = new System.Drawing.Size(48, 48);
            this.pbClo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClo.TabIndex = 3;
            this.pbClo.TabStop = false;
            this.pbClo.Click += new System.EventHandler(this.pbClo_Click);
            // 
            // pbMin
            // 
            this.pbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMin.Image = ((System.Drawing.Image)(resources.GetObject("pbMin.Image")));
            this.pbMin.Location = new System.Drawing.Point(899, 0);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(34, 26);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMin.TabIndex = 4;
            this.pbMin.TabStop = false;
            this.pbMin.Click += new System.EventHandler(this.pbMin_Click);
            // 
            // pbReceived
            // 
            this.pbReceived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReceived.Image = ((System.Drawing.Image)(resources.GetObject("pbReceived.Image")));
            this.pbReceived.Location = new System.Drawing.Point(701, 515);
            this.pbReceived.Name = "pbReceived";
            this.pbReceived.Size = new System.Drawing.Size(220, 60);
            this.pbReceived.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbReceived.TabIndex = 5;
            this.pbReceived.TabStop = false;
            this.pbReceived.Click += new System.EventHandler(this.pbReceived_Click);
            // 
            // pbFormReg
            // 
            this.pbFormReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFormReg.Image = ((System.Drawing.Image)(resources.GetObject("pbFormReg.Image")));
            this.pbFormReg.Location = new System.Drawing.Point(593, 592);
            this.pbFormReg.Name = "pbFormReg";
            this.pbFormReg.Size = new System.Drawing.Size(81, 59);
            this.pbFormReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFormReg.TabIndex = 6;
            this.pbFormReg.TabStop = false;
            this.pbFormReg.Click += new System.EventHandler(this.pbFormReg_Click);
            // 
            // pbFormfee
            // 
            this.pbFormfee.Cursor = System.Windows.Forms.Cursors.No;
            this.pbFormfee.Image = ((System.Drawing.Image)(resources.GetObject("pbFormfee.Image")));
            this.pbFormfee.Location = new System.Drawing.Point(680, 592);
            this.pbFormfee.Name = "pbFormfee";
            this.pbFormfee.Size = new System.Drawing.Size(81, 59);
            this.pbFormfee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFormfee.TabIndex = 7;
            this.pbFormfee.TabStop = false;
            // 
            // pbFormexa
            // 
            this.pbFormexa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFormexa.Image = ((System.Drawing.Image)(resources.GetObject("pbFormexa.Image")));
            this.pbFormexa.Location = new System.Drawing.Point(767, 592);
            this.pbFormexa.Name = "pbFormexa";
            this.pbFormexa.Size = new System.Drawing.Size(81, 59);
            this.pbFormexa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFormexa.TabIndex = 8;
            this.pbFormexa.TabStop = false;
            this.pbFormexa.Click += new System.EventHandler(this.pbFormexa_Click);
            // 
            // pbFormsea
            // 
            this.pbFormsea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFormsea.Image = ((System.Drawing.Image)(resources.GetObject("pbFormsea.Image")));
            this.pbFormsea.Location = new System.Drawing.Point(854, 592);
            this.pbFormsea.Name = "pbFormsea";
            this.pbFormsea.Size = new System.Drawing.Size(81, 59);
            this.pbFormsea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFormsea.TabIndex = 9;
            this.pbFormsea.TabStop = false;
            this.pbFormsea.Click += new System.EventHandler(this.pbFormsea_Click);
            // 
            // txtAmo
            // 
            this.txtAmo.Location = new System.Drawing.Point(179, 429);
            this.txtAmo.Name = "txtAmo";
            this.txtAmo.Size = new System.Drawing.Size(100, 20);
            this.txtAmo.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Diploma",
            "Application Assistant",
            "Students (Year 6 - 8)",
            "Kids From Basic (Year 1 - 5)",
            "Photoshop Media and Web Designing (HTML)",
            "O/L ICT",
            "A/L GIT",
            "ASP.Net with C# and Database",
            "Basic Computer Hardware"});
            this.comboBox2.Location = new System.Drawing.Point(227, 467);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select the course :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnOKp1);
            this.panel1.Location = new System.Drawing.Point(145, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 200);
            this.panel1.TabIndex = 15;
            // 
            // btnOKp1
            // 
            this.btnOKp1.Location = new System.Drawing.Point(600, 160);
            this.btnOKp1.Name = "btnOKp1";
            this.btnOKp1.Size = new System.Drawing.Size(75, 23);
            this.btnOKp1.TabIndex = 0;
            this.btnOKp1.Text = "OK";
            this.btnOKp1.UseVisualStyleBackColor = true;
            this.btnOKp1.Click += new System.EventHandler(this.btnOKp1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnOKp2);
            this.panel2.Location = new System.Drawing.Point(145, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 200);
            this.panel2.TabIndex = 1;
            // 
            // btnOKp2
            // 
            this.btnOKp2.Location = new System.Drawing.Point(600, 160);
            this.btnOKp2.Name = "btnOKp2";
            this.btnOKp2.Size = new System.Drawing.Size(75, 23);
            this.btnOKp2.TabIndex = 0;
            this.btnOKp2.Text = "OK";
            this.btnOKp2.UseVisualStyleBackColor = true;
            this.btnOKp2.Click += new System.EventHandler(this.btnOKp2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.btnOKp3);
            this.panel3.Location = new System.Drawing.Point(145, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 200);
            this.panel3.TabIndex = 1;
            // 
            // btnOKp3
            // 
            this.btnOKp3.Location = new System.Drawing.Point(600, 160);
            this.btnOKp3.Name = "btnOKp3";
            this.btnOKp3.Size = new System.Drawing.Size(75, 23);
            this.btnOKp3.TabIndex = 0;
            this.btnOKp3.Text = "OK";
            this.btnOKp3.UseVisualStyleBackColor = true;
            this.btnOKp3.Click += new System.EventHandler(this.btnOKp3_Click);
            // 
            // txtFul
            // 
            this.txtFul.Location = new System.Drawing.Point(12, 38);
            this.txtFul.Name = "txtFul";
            this.txtFul.Size = new System.Drawing.Size(100, 20);
            this.txtFul.TabIndex = 16;
            this.txtFul.Visible = false;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(12, 64);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 17;
            this.txtPay.Visible = false;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(12, 90);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 18;
            this.txtCom.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.table1BindingSource;
            this.listBox1.DisplayMember = "Payments";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 19;
            this.listBox1.ValueMember = "Payments";
            this.listBox1.Visible = false;
            // 
            // CourseSummary
            // 
            this.CourseSummary.DataPropertyName = "CourseSummary";
            this.CourseSummary.HeaderText = "Courses";
            this.CourseSummary.Name = "CourseSummary";
            this.CourseSummary.Width = 68;
            // 
            // paymentsDataGridViewTextBoxColumn
            // 
            this.paymentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.paymentsDataGridViewTextBoxColumn.DataPropertyName = "Payments";
            this.paymentsDataGridViewTextBoxColumn.HeaderText = "Payments";
            this.paymentsDataGridViewTextBoxColumn.Name = "paymentsDataGridViewTextBoxColumn";
            this.paymentsDataGridViewTextBoxColumn.Width = 76;
            // 
            // FeeReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtFul);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtAmo);
            this.Controls.Add(this.pbFormsea);
            this.Controls.Add(this.pbFormexa);
            this.Controls.Add(this.pbFormfee);
            this.Controls.Add(this.pbFormReg);
            this.Controls.Add(this.pbReceived);
            this.Controls.Add(this.pbMin);
            this.Controls.Add(this.pbClo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeeReceived";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeReceived";
            this.Load += new System.EventHandler(this.FeeReceived_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormfee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormexa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormsea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Electro.Database1DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbClo;
        private System.Windows.Forms.PictureBox pbMin;
        private System.Windows.Forms.PictureBox pbReceived;
        private System.Windows.Forms.PictureBox pbFormReg;
        private System.Windows.Forms.PictureBox pbFormfee;
        private System.Windows.Forms.PictureBox pbFormexa;
        private System.Windows.Forms.PictureBox pbFormsea;
        private System.Windows.Forms.TextBox txtAmo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOKp1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOKp2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOKp3;
        private System.Windows.Forms.TextBox txtFul;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentsDataGridViewTextBoxColumn;
    }
}