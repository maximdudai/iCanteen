﻿namespace PSI_DA_PL_B.views.Clients.Both
{
    partial class ChooseClientCreate
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
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.TeacherCreate = new System.Windows.Forms.Button();
            this.StudentCreate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(455, 117);
            this.header1.TabIndex = 17;
            // 
            // TeacherCreate
            // 
            this.TeacherCreate.BackColor = System.Drawing.Color.White;
            this.TeacherCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TeacherCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherCreate.ForeColor = System.Drawing.Color.Peru;
            this.TeacherCreate.Location = new System.Drawing.Point(237, 227);
            this.TeacherCreate.Margin = new System.Windows.Forms.Padding(0);
            this.TeacherCreate.Name = "TeacherCreate";
            this.TeacherCreate.Size = new System.Drawing.Size(134, 45);
            this.TeacherCreate.TabIndex = 2;
            this.TeacherCreate.Text = "Professor";
            this.TeacherCreate.UseVisualStyleBackColor = false;
            this.TeacherCreate.Click += new System.EventHandler(this.TeacherCreate_Click);
            // 
            // StudentCreate
            // 
            this.StudentCreate.BackColor = System.Drawing.Color.White;
            this.StudentCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StudentCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCreate.ForeColor = System.Drawing.Color.Peru;
            this.StudentCreate.Location = new System.Drawing.Point(90, 227);
            this.StudentCreate.Name = "StudentCreate";
            this.StudentCreate.Size = new System.Drawing.Size(134, 45);
            this.StudentCreate.TabIndex = 1;
            this.StudentCreate.Text = "Estudante";
            this.StudentCreate.UseVisualStyleBackColor = false;
            this.StudentCreate.Click += new System.EventHandler(this.StudentCreate_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Peru;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(-1, 227);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(456, 45);
            this.textBox4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(113, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Perfil pretendido";
            // 
            // ChooseClientCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 344);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.TeacherCreate);
            this.Controls.Add(this.StudentCreate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Name = "ChooseClientCreate";
            this.Text = "Perfil Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.Button TeacherCreate;
        private System.Windows.Forms.Button StudentCreate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}