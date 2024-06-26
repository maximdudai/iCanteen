﻿namespace PSI_DA_PL_B.views.Auth.Employees
{
    partial class EmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filterEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeCreate = new System.Windows.Forms.Button();
            this.editEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.employeesList = new System.Windows.Forms.ListBox();
            this.searchEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 161);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(569, 51);
            this.textBox1.TabIndex = 1;
            // 
            // filterEmployee
            // 
            this.filterEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.filterEmployee.Location = new System.Drawing.Point(12, 276);
            this.filterEmployee.Name = "filterEmployee";
            this.filterEmployee.Size = new System.Drawing.Size(393, 32);
            this.filterEmployee.TabIndex = 1;
            this.filterEmployee.TextChanged += new System.EventHandler(this.filterEmployee_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username do funcionario";
            // 
            // employeeCreate
            // 
            this.employeeCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.employeeCreate.Location = new System.Drawing.Point(12, 314);
            this.employeeCreate.Name = "employeeCreate";
            this.employeeCreate.Size = new System.Drawing.Size(127, 32);
            this.employeeCreate.TabIndex = 3;
            this.employeeCreate.Text = "Criar";
            this.employeeCreate.UseVisualStyleBackColor = true;
            this.employeeCreate.Click += new System.EventHandler(this.employeeCreate_Click);
            // 
            // editEmployee
            // 
            this.editEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.editEmployee.Location = new System.Drawing.Point(145, 314);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(127, 32);
            this.editEmployee.TabIndex = 4;
            this.editEmployee.Text = "Editar";
            this.editEmployee.UseVisualStyleBackColor = true;
            this.editEmployee.Click += new System.EventHandler(this.editEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.deleteEmployee.Location = new System.Drawing.Point(278, 314);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(127, 32);
            this.deleteEmployee.TabIndex = 5;
            this.deleteEmployee.Text = "Apagar";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.Location = new System.Drawing.Point(12, 362);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(539, 212);
            this.employeesList.TabIndex = 6;
            this.employeesList.DoubleClick += new System.EventHandler(this.HandleSelectEmployee);
            // 
            // searchEmployee
            // 
            this.searchEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.searchEmployee.Location = new System.Drawing.Point(424, 276);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(127, 32);
            this.searchEmployee.TabIndex = 2;
            this.searchEmployee.Text = "Pesquisar";
            this.searchEmployee.UseVisualStyleBackColor = true;
            this.searchEmployee.Click += new System.EventHandler(this.searchEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Funcionarios";
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(569, 117);
            this.header1.TabIndex = 0;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 581);
            this.Controls.Add(this.employeesList);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.employeeCreate);
            this.Controls.Add(this.searchEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Funcionarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox filterEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button employeeCreate;
        private System.Windows.Forms.Button editEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.ListBox employeesList;
        private System.Windows.Forms.Button searchEmployee;
        private System.Windows.Forms.Label label1;
    }
}