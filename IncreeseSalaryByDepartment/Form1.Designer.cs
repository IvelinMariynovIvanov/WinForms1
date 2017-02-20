namespace IncreeseSalaryByDepartment
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
            this.cmDepartment = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.ChooseHowToUpdate = new System.Windows.Forms.GroupBox();
            this.rbPercente = new System.Windows.Forms.RadioButton();
            this.RbValue = new System.Windows.Forms.RadioButton();
            this.IncreaseOrDecrease = new System.Windows.Forms.GroupBox();
            this.rbDecrease = new System.Windows.Forms.RadioButton();
            this.rbIncrease = new System.Windows.Forms.RadioButton();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.bnUpdate = new System.Windows.Forms.Button();
            this.ChooseHowToUpdate.SuspendLayout();
            this.IncreaseOrDecrease.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmDepartment
            // 
            this.cmDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDepartment.FormattingEnabled = true;
            this.cmDepartment.Location = new System.Drawing.Point(134, 12);
            this.cmDepartment.Name = "cmDepartment";
            this.cmDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmDepartment.TabIndex = 0;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(134, 49);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(121, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // ChooseHowToUpdate
            // 
            this.ChooseHowToUpdate.Controls.Add(this.rbPercente);
            this.ChooseHowToUpdate.Controls.Add(this.RbValue);
            this.ChooseHowToUpdate.Location = new System.Drawing.Point(58, 87);
            this.ChooseHowToUpdate.Name = "ChooseHowToUpdate";
            this.ChooseHowToUpdate.Size = new System.Drawing.Size(197, 79);
            this.ChooseHowToUpdate.TabIndex = 2;
            this.ChooseHowToUpdate.TabStop = false;
            this.ChooseHowToUpdate.Text = "How to update";
            // 
            // rbPercente
            // 
            this.rbPercente.AutoSize = true;
            this.rbPercente.Location = new System.Drawing.Point(76, 42);
            this.rbPercente.Name = "rbPercente";
            this.rbPercente.Size = new System.Drawing.Size(62, 17);
            this.rbPercente.TabIndex = 1;
            this.rbPercente.TabStop = true;
            this.rbPercente.Text = "Percent";
            this.rbPercente.UseVisualStyleBackColor = true;
            // 
            // RbValue
            // 
            this.RbValue.AutoSize = true;
            this.RbValue.Location = new System.Drawing.Point(76, 19);
            this.RbValue.Name = "RbValue";
            this.RbValue.Size = new System.Drawing.Size(52, 17);
            this.RbValue.TabIndex = 0;
            this.RbValue.TabStop = true;
            this.RbValue.Text = "Value";
            this.RbValue.UseVisualStyleBackColor = true;
            // 
            // IncreaseOrDecrease
            // 
            this.IncreaseOrDecrease.Controls.Add(this.rbDecrease);
            this.IncreaseOrDecrease.Controls.Add(this.rbIncrease);
            this.IncreaseOrDecrease.Location = new System.Drawing.Point(58, 173);
            this.IncreaseOrDecrease.Name = "IncreaseOrDecrease";
            this.IncreaseOrDecrease.Size = new System.Drawing.Size(197, 81);
            this.IncreaseOrDecrease.TabIndex = 3;
            this.IncreaseOrDecrease.TabStop = false;
            this.IncreaseOrDecrease.Text = "Increase or decrease";
            // 
            // rbDecrease
            // 
            this.rbDecrease.AutoSize = true;
            this.rbDecrease.Location = new System.Drawing.Point(76, 42);
            this.rbDecrease.Name = "rbDecrease";
            this.rbDecrease.Size = new System.Drawing.Size(71, 17);
            this.rbDecrease.TabIndex = 1;
            this.rbDecrease.TabStop = true;
            this.rbDecrease.Text = "Decrease";
            this.rbDecrease.UseVisualStyleBackColor = true;
            // 
            // rbIncrease
            // 
            this.rbIncrease.AutoSize = true;
            this.rbIncrease.Location = new System.Drawing.Point(76, 19);
            this.rbIncrease.Name = "rbIncrease";
            this.rbIncrease.Size = new System.Drawing.Size(66, 17);
            this.rbIncrease.TabIndex = 0;
            this.rbIncrease.TabStop = true;
            this.rbIncrease.Text = "Increase";
            this.rbIncrease.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(55, 19);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(73, 56);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number";
            // 
            // bnUpdate
            // 
            this.bnUpdate.Location = new System.Drawing.Point(134, 260);
            this.bnUpdate.Name = "bnUpdate";
            this.bnUpdate.Size = new System.Drawing.Size(121, 23);
            this.bnUpdate.TabIndex = 6;
            this.bnUpdate.Text = "Update";
            this.bnUpdate.UseVisualStyleBackColor = true;
            this.bnUpdate.Click += new System.EventHandler(this.bnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 329);
            this.Controls.Add(this.bnUpdate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.IncreaseOrDecrease);
            this.Controls.Add(this.ChooseHowToUpdate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.cmDepartment);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChooseHowToUpdate.ResumeLayout(false);
            this.ChooseHowToUpdate.PerformLayout();
            this.IncreaseOrDecrease.ResumeLayout(false);
            this.IncreaseOrDecrease.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmDepartment;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox ChooseHowToUpdate;
        private System.Windows.Forms.RadioButton rbPercente;
        private System.Windows.Forms.RadioButton RbValue;
        private System.Windows.Forms.GroupBox IncreaseOrDecrease;
        private System.Windows.Forms.RadioButton rbDecrease;
        private System.Windows.Forms.RadioButton rbIncrease;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button bnUpdate;
    }
}

