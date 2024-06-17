namespace PSI_DA_PL_B.views.Clients.Teachers.Edit
{
    partial class EditTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeacher));
            this.label4 = new System.Windows.Forms.Label();
            this.teacherBalanceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherNameInput = new System.Windows.Forms.TextBox();
            this.teacherEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherNIFinput = new System.Windows.Forms.TextBox();
            this.employeeUsername = new System.Windows.Forms.Label();
            this.teacherEmailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Saldo do professor";
            // 
            // teacherBalanceInput
            // 
            this.teacherBalanceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherBalanceInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.teacherBalanceInput.Location = new System.Drawing.Point(19, 549);
            this.teacherBalanceInput.Margin = new System.Windows.Forms.Padding(4);
            this.teacherBalanceInput.Name = "teacherBalanceInput";
            this.teacherBalanceInput.Size = new System.Drawing.Size(573, 37);
            this.teacherBalanceInput.TabIndex = 4;
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
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nome do professor";
            // 
            // teacherNameInput
            // 
            this.teacherNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherNameInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.teacherNameInput.Location = new System.Drawing.Point(19, 266);
            this.teacherNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.teacherNameInput.Name = "teacherNameInput";
            this.teacherNameInput.Size = new System.Drawing.Size(573, 37);
            this.teacherNameInput.TabIndex = 1;
            // 
            // teacherEdit
            // 
            this.teacherEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.teacherEdit.Location = new System.Drawing.Point(185, 626);
            this.teacherEdit.Margin = new System.Windows.Forms.Padding(4);
            this.teacherEdit.Name = "teacherEdit";
            this.teacherEdit.Size = new System.Drawing.Size(251, 46);
            this.teacherEdit.TabIndex = 5;
            this.teacherEdit.Text = "Editar";
            this.teacherEdit.UseVisualStyleBackColor = true;
            this.teacherEdit.Click += new System.EventHandler(this.TeacherEdit_Click);
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
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "NIF do professor";
            // 
            // teacherNIFinput
            // 
            this.teacherNIFinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherNIFinput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.teacherNIFinput.Location = new System.Drawing.Point(19, 454);
            this.teacherNIFinput.Margin = new System.Windows.Forms.Padding(4);
            this.teacherNIFinput.Name = "teacherNIFinput";
            this.teacherNIFinput.Size = new System.Drawing.Size(573, 37);
            this.teacherNIFinput.TabIndex = 3;
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
            this.employeeUsername.Size = new System.Drawing.Size(156, 18);
            this.employeeUsername.TabIndex = 40;
            this.employeeUsername.Text = "Email do professor";
            // 
            // teacherEmailInput
            // 
            this.teacherEmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherEmailInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.teacherEmailInput.Location = new System.Drawing.Point(19, 357);
            this.teacherEmailInput.Margin = new System.Windows.Forms.Padding(4);
            this.teacherEmailInput.Name = "teacherEmailInput";
            this.teacherEmailInput.Size = new System.Drawing.Size(573, 37);
            this.teacherEmailInput.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 43;
            this.label1.Text = "Editar Professor";
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
            this.textBox1.TabIndex = 39;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(612, 144);
            this.header1.TabIndex = 33;
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 686);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherBalanceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherNameInput);
            this.Controls.Add(this.teacherEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherNIFinput);
            this.Controls.Add(this.employeeUsername);
            this.Controls.Add(this.teacherEmailInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Professor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTeacher_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherBalanceInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacherNameInput;
        private System.Windows.Forms.Button teacherEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherNIFinput;
        private System.Windows.Forms.Label employeeUsername;
        private System.Windows.Forms.TextBox teacherEmailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
    }
}