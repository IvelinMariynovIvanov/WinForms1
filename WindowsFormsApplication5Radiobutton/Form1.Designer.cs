namespace WindowsFormsApplication5Radiobutton
{
    partial class AddEmployee
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.WorkingDay = new System.Windows.Forms.GroupBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.Contract = new System.Windows.Forms.GroupBox();
            this.FirtstName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.FullDay = new System.Windows.Forms.RadioButton();
            this.PartDay = new System.Windows.Forms.RadioButton();
            this.Civil = new System.Windows.Forms.RadioButton();
            this.FullTime = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.Button();
            this.WorkingDay.SuspendLayout();
            this.Gender.SuspendLayout();
            this.Contract.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // WorkingDay
            // 
            this.WorkingDay.AutoSize = true;
            this.WorkingDay.Controls.Add(this.PartDay);
            this.WorkingDay.Controls.Add(this.FullDay);
            this.WorkingDay.Location = new System.Drawing.Point(112, 176);
            this.WorkingDay.Name = "WorkingDay";
            this.WorkingDay.Size = new System.Drawing.Size(166, 85);
            this.WorkingDay.TabIndex = 3;
            this.WorkingDay.TabStop = false;
            this.WorkingDay.Text = "Working Day";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Controls.Add(this.Female);
            this.Gender.Controls.Add(this.Male);
            this.Gender.Location = new System.Drawing.Point(111, 92);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(161, 78);
            this.Gender.TabIndex = 4;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            this.Gender.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Contract
            // 
            this.Contract.Controls.Add(this.FullTime);
            this.Contract.Controls.Add(this.Civil);
            this.Contract.Location = new System.Drawing.Point(112, 267);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(160, 76);
            this.Contract.TabIndex = 5;
            this.Contract.TabStop = false;
            this.Contract.Text = "Contract";
            this.Contract.Enter += new System.EventHandler(this.WorkingDay_Enter);
            // 
            // FirtstName
            // 
            this.FirtstName.AutoSize = true;
            this.FirtstName.Location = new System.Drawing.Point(109, 19);
            this.FirtstName.Name = "FirtstName";
            this.FirtstName.Size = new System.Drawing.Size(57, 13);
            this.FirtstName.TabIndex = 6;
            this.FirtstName.Text = "First Name";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(97, 46);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(69, 13);
            this.MiddleName.TabIndex = 7;
            this.MiddleName.Text = "Middle Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(108, 73);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 8;
            this.LastName.Text = "Last Name";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(57, 19);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            this.Male.EnabledChanged += new System.EventHandler(this.Male_EnabledChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(57, 42);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 1;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // FullDay
            // 
            this.FullDay.Location = new System.Drawing.Point(56, 19);
            this.FullDay.Name = "FullDay";
            this.FullDay.Size = new System.Drawing.Size(104, 24);
            this.FullDay.TabIndex = 0;
            this.FullDay.Text = "Full Day";
            this.FullDay.UseVisualStyleBackColor = true;
            this.FullDay.CheckedChanged += new System.EventHandler(this.FullDay_CheckedChanged);
            // 
            // PartDay
            // 
            this.PartDay.AutoSize = true;
            this.PartDay.Location = new System.Drawing.Point(56, 49);
            this.PartDay.Name = "PartDay";
            this.PartDay.Size = new System.Drawing.Size(64, 17);
            this.PartDay.TabIndex = 1;
            this.PartDay.TabStop = true;
            this.PartDay.Text = "Part day";
            this.PartDay.UseVisualStyleBackColor = true;
            this.PartDay.CheckedChanged += new System.EventHandler(this.PartDay_CheckedChanged);
            // 
            // Civil
            // 
            this.Civil.AutoSize = true;
            this.Civil.Location = new System.Drawing.Point(56, 19);
            this.Civil.Name = "Civil";
            this.Civil.Size = new System.Drawing.Size(44, 17);
            this.Civil.TabIndex = 0;
            this.Civil.TabStop = true;
            this.Civil.Text = "Civil";
            this.Civil.UseVisualStyleBackColor = true;
            this.Civil.CheckedChanged += new System.EventHandler(this.Civil_CheckedChanged);
            // 
            // FullTime
            // 
            this.FullTime.AutoSize = true;
            this.FullTime.Location = new System.Drawing.Point(56, 42);
            this.FullTime.Name = "FullTime";
            this.FullTime.Size = new System.Drawing.Size(67, 17);
            this.FullTime.TabIndex = 1;
            this.FullTime.TabStop = true;
            this.FullTime.Text = "Full Time";
            this.FullTime.UseVisualStyleBackColor = true;
            this.FullTime.CheckedChanged += new System.EventHandler(this.FullTime_CheckedChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(112, 371);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(160, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 413);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirtstName);
            this.Controls.Add(this.Contract);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.WorkingDay);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.WorkingDay.ResumeLayout(false);
            this.WorkingDay.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.Contract.ResumeLayout(false);
            this.Contract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox WorkingDay;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.GroupBox Contract;
        private System.Windows.Forms.Label FirtstName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.RadioButton PartDay;
        private System.Windows.Forms.RadioButton FullDay;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton FullTime;
        private System.Windows.Forms.RadioButton Civil;
        private System.Windows.Forms.Button Add;
    }
}

