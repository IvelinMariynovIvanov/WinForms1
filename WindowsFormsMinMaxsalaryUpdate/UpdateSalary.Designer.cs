namespace WindowsFormsMinMaxsalaryUpdate
{
    partial class UpdateSalary
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
            this.minSalary = new System.Windows.Forms.TextBox();
            this.maxSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdateSalary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentEmployeeSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // minSalary
            // 
            this.minSalary.Location = new System.Drawing.Point(130, 32);
            this.minSalary.Name = "minSalary";
            this.minSalary.Size = new System.Drawing.Size(121, 20);
            this.minSalary.TabIndex = 0;
            this.minSalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maxSalary
            // 
            this.maxSalary.Location = new System.Drawing.Point(130, 58);
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(121, 20);
            this.maxSalary.TabIndex = 1;
            this.maxSalary.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min Salary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Employyes in that range";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdateSalary
            // 
            this.buttonUpdateSalary.Location = new System.Drawing.Point(130, 195);
            this.buttonUpdateSalary.Name = "buttonUpdateSalary";
            this.buttonUpdateSalary.Size = new System.Drawing.Size(121, 23);
            this.buttonUpdateSalary.TabIndex = 9;
            this.buttonUpdateSalary.Text = "Update Salary";
            this.buttonUpdateSalary.UseVisualStyleBackColor = true;
            this.buttonUpdateSalary.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employyes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // newEmployeeSalary
            // 
            this.newEmployeeSalary.Location = new System.Drawing.Point(140, 167);
            this.newEmployeeSalary.Name = "newEmployeeSalary";
            this.newEmployeeSalary.Size = new System.Drawing.Size(121, 20);
            this.newEmployeeSalary.TabIndex = 10;
            this.newEmployeeSalary.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Salary Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current Employee Salary";
            // 
            // currentEmployeeSalary
            // 
            this.currentEmployeeSalary.Location = new System.Drawing.Point(130, 141);
            this.currentEmployeeSalary.Name = "currentEmployeeSalary";
            this.currentEmployeeSalary.ReadOnly = true;
            this.currentEmployeeSalary.Size = new System.Drawing.Size(121, 20);
            this.currentEmployeeSalary.TabIndex = 13;
            this.currentEmployeeSalary.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // UpdateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 256);
            this.Controls.Add(this.currentEmployeeSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newEmployeeSalary);
            this.Controls.Add(this.buttonUpdateSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxSalary);
            this.Controls.Add(this.minSalary);
            this.Name = "UpdateSalary";
            this.Text = "Update Employee Salary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minSalary;
        private System.Windows.Forms.TextBox maxSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdateSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox newEmployeeSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentEmployeeSalary;
    }
}

