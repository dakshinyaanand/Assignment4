namespace StudentsProfile
{
    partial class Form1
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
            this.lbstudentsprof = new System.Windows.Forms.Label();
            this.lbrollno = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbdateof = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbdepartment = new System.Windows.Forms.Label();
            this.lbcourse = new System.Windows.Forms.Label();
            this.lbsemester = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.cbdepartment = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.dtpdateof = new System.Windows.Forms.DateTimePicker();
            this.btnnew = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbstudentsprof
            // 
            this.lbstudentsprof.AutoSize = true;
            this.lbstudentsprof.Location = new System.Drawing.Point(651, 53);
            this.lbstudentsprof.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbstudentsprof.Name = "lbstudentsprof";
            this.lbstudentsprof.Size = new System.Drawing.Size(104, 18);
            this.lbstudentsprof.TabIndex = 0;
            this.lbstudentsprof.Text = "Student Profile";
            // 
            // lbrollno
            // 
            this.lbrollno.AutoSize = true;
            this.lbrollno.Location = new System.Drawing.Point(344, 100);
            this.lbrollno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbrollno.Name = "lbrollno";
            this.lbrollno.Size = new System.Drawing.Size(55, 18);
            this.lbrollno.TabIndex = 1;
            this.lbrollno.Text = "Roll no";
            this.lbrollno.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(344, 148);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(48, 18);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "Name";
            // 
            // lbdateof
            // 
            this.lbdateof.AutoSize = true;
            this.lbdateof.Location = new System.Drawing.Point(344, 190);
            this.lbdateof.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdateof.Name = "lbdateof";
            this.lbdateof.Size = new System.Drawing.Size(56, 18);
            this.lbdateof.TabIndex = 3;
            this.lbdateof.Text = "Date of";
            this.lbdateof.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Location = new System.Drawing.Point(344, 230);
            this.lbgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(57, 18);
            this.lbgender.TabIndex = 4;
            this.lbgender.Text = "Gender";
            this.lbgender.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbdepartment
            // 
            this.lbdepartment.AutoSize = true;
            this.lbdepartment.Location = new System.Drawing.Point(344, 271);
            this.lbdepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdepartment.Name = "lbdepartment";
            this.lbdepartment.Size = new System.Drawing.Size(85, 18);
            this.lbdepartment.TabIndex = 5;
            this.lbdepartment.Text = "Department";
            this.lbdepartment.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbcourse
            // 
            this.lbcourse.AutoSize = true;
            this.lbcourse.Location = new System.Drawing.Point(344, 312);
            this.lbcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcourse.Name = "lbcourse";
            this.lbcourse.Size = new System.Drawing.Size(57, 18);
            this.lbcourse.TabIndex = 6;
            this.lbcourse.Text = "Course";
            // 
            // lbsemester
            // 
            this.lbsemester.AutoSize = true;
            this.lbsemester.Location = new System.Drawing.Point(344, 356);
            this.lbsemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsemester.Name = "lbsemester";
            this.lbsemester.Size = new System.Drawing.Size(72, 18);
            this.lbsemester.TabIndex = 7;
            this.lbsemester.Text = "Semester";
            this.lbsemester.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(344, 393);
            this.lbaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(62, 18);
            this.lbaddress.TabIndex = 8;
            this.lbaddress.Text = "Address";
            this.lbaddress.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(344, 439);
            this.lbphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(51, 18);
            this.lbphone.TabIndex = 9;
            this.lbphone.Text = "Phone";
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(534, 89);
            this.txtrollno.Margin = new System.Windows.Forms.Padding(4);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(283, 24);
            this.txtrollno.TabIndex = 11;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(534, 138);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(283, 24);
            this.txtname.TabIndex = 12;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(534, 223);
            this.rbmale.Margin = new System.Windows.Forms.Padding(4);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(58, 22);
            this.rbmale.TabIndex = 14;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(714, 223);
            this.rbfemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(75, 22);
            this.rbfemale.TabIndex = 15;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // cbdepartment
            // 
            this.cbdepartment.FormattingEnabled = true;
            this.cbdepartment.Items.AddRange(new object[] {
            "Computer Science",
            "Electronics",
            "instrumenstatin and communication",
            "mathemathics",
            "Applied Science"});
            this.cbdepartment.Location = new System.Drawing.Point(531, 255);
            this.cbdepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(286, 26);
            this.cbdepartment.TabIndex = 16;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "M.TECH(EE)",
            "B.TECH(IT)",
            "BE(IT)",
            "BSC(CS)",
            "B.TECH(CS)",
            "ME(INC)",
            "BE(INC)"});
            this.cbcourse.Location = new System.Drawing.Point(534, 299);
            this.cbcourse.Margin = new System.Windows.Forms.Padding(4);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(283, 26);
            this.cbcourse.TabIndex = 17;
            // 
            // cbsemester
            // 
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Items.AddRange(new object[] {
            "SEMESTER- 1",
            "SEMESTER- 2",
            "SEMESTER- 3",
            "SEMESTER- 4",
            "SEMESTER- 5",
            "SEMESTER- 6",
            "SEMESTER- 7",
            "SEMESTER- 8"});
            this.cbsemester.Location = new System.Drawing.Point(534, 343);
            this.cbsemester.Margin = new System.Windows.Forms.Padding(4);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(283, 26);
            this.cbsemester.TabIndex = 18;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(534, 382);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(283, 24);
            this.txtaddress.TabIndex = 19;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(534, 429);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(283, 24);
            this.txtphone.TabIndex = 20;
            this.txtphone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(534, 534);
            this.btnselect.Margin = new System.Windows.Forms.Padding(4);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(112, 32);
            this.btnselect.TabIndex = 21;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(714, 533);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 32);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(894, 534);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 32);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(860, 83);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(112, 32);
            this.btnfind.TabIndex = 24;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // dtpdateof
            // 
            this.dtpdateof.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateof.Location = new System.Drawing.Point(534, 181);
            this.dtpdateof.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdateof.Name = "dtpdateof";
            this.dtpdateof.Size = new System.Drawing.Size(298, 24);
            this.dtpdateof.TabIndex = 26;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(347, 534);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(99, 32);
            this.btnnew.TabIndex = 27;
            this.btnnew.Text = "Add New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 18;
            this.lbselect.Location = new System.Drawing.Point(907, 148);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(212, 292);
            this.lbselect.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 613);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.dtpdateof);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.cbdepartment);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbsemester);
            this.Controls.Add(this.lbcourse);
            this.Controls.Add(this.lbdepartment);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbdateof);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbrollno);
            this.Controls.Add(this.lbstudentsprof);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Students Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbstudentsprof;
        private System.Windows.Forms.Label lbrollno;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbdateof;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbdepartment;
        private System.Windows.Forms.Label lbcourse;
        private System.Windows.Forms.Label lbsemester;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.ComboBox cbdepartment;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DateTimePicker dtpdateof;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ListBox lbselect;
    }
}

