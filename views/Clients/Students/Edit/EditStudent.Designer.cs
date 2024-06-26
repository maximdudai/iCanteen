﻿namespace PSI_DA_PL_B.views.Clients.Students.Edit
{
    partial class EditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameInput = new System.Windows.Forms.TextBox();
            this.studentEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.studentNIFinput = new System.Windows.Forms.TextBox();
            this.employeeUsername = new System.Windows.Forms.Label();
            this.studentNumberInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentBalanceInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(612, 144);
            this.header1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(19, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome do estudante";
            // 
            // studentNameInput
            // 
            this.studentNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentNameInput.Location = new System.Drawing.Point(19, 266);
            this.studentNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(573, 37);
            this.studentNameInput.TabIndex = 1;
            // 
            // studentEdit
            // 
            this.studentEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.studentEdit.Location = new System.Drawing.Point(185, 626);
            this.studentEdit.Margin = new System.Windows.Forms.Padding(4);
            this.studentEdit.Name = "studentEdit";
            this.studentEdit.Size = new System.Drawing.Size(251, 46);
            this.studentEdit.TabIndex = 5;
            this.studentEdit.Text = "Editar";
            this.studentEdit.UseVisualStyleBackColor = true;
            this.studentEdit.Click += new System.EventHandler(this.StudentEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(19, 430);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "NIF do estudante";
            // 
            // studentNIFinput
            // 
            this.studentNIFinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNIFinput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentNIFinput.Location = new System.Drawing.Point(19, 454);
            this.studentNIFinput.Margin = new System.Windows.Forms.Padding(4);
            this.studentNIFinput.Name = "studentNIFinput";
            this.studentNIFinput.Size = new System.Drawing.Size(573, 37);
            this.studentNIFinput.TabIndex = 3;
            // 
            // employeeUsername
            // 
            this.employeeUsername.AutoSize = true;
            this.employeeUsername.BackColor = System.Drawing.Color.White;
            this.employeeUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.employeeUsername.ForeColor = System.Drawing.Color.Peru;
            this.employeeUsername.Location = new System.Drawing.Point(19, 334);
            this.employeeUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeUsername.Name = "employeeUsername";
            this.employeeUsername.Size = new System.Drawing.Size(180, 18);
            this.employeeUsername.TabIndex = 27;
            this.employeeUsername.Text = "Numero de estudante";
            // 
            // studentNumberInput
            // 
            this.studentNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentNumberInput.Location = new System.Drawing.Point(19, 357);
            this.studentNumberInput.Margin = new System.Windows.Forms.Padding(4);
            this.studentNumberInput.Name = "studentNumberInput";
            this.studentNumberInput.Size = new System.Drawing.Size(573, 37);
            this.studentNumberInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 30;
            this.label1.Text = "Editar Estudante";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 167);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(606, 62);
            this.textBox1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(19, 526);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Saldo do estudante";
            // 
            // studentBalanceInput
            // 
            this.studentBalanceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentBalanceInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentBalanceInput.Location = new System.Drawing.Point(19, 549);
            this.studentBalanceInput.Margin = new System.Windows.Forms.Padding(4);
            this.studentBalanceInput.Name = "studentBalanceInput";
            this.studentBalanceInput.Size = new System.Drawing.Size(573, 37);
            this.studentBalanceInput.TabIndex = 4;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 686);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentBalanceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameInput);
            this.Controls.Add(this.studentEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentNIFinput);
            this.Controls.Add(this.employeeUsername);
            this.Controls.Add(this.studentNumberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Estudante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStudent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNameInput;
        private System.Windows.Forms.Button studentEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentNIFinput;
        private System.Windows.Forms.Label employeeUsername;
        private System.Windows.Forms.TextBox studentNumberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentBalanceInput;
    }
}