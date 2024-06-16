namespace PSI_DA_PL_B.views.Clients.Teachers.Create
{
    partial class CreateTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeacher));
            this.label2 = new System.Windows.Forms.Label();
            this.teacherNameInput = new System.Windows.Forms.TextBox();
            this.teacherCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherNIFinput = new System.Windows.Forms.TextBox();
            this.employeeUsername = new System.Windows.Forms.Label();
            this.teacherEmailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Name = "label2";
            // 
            // teacherNameInput
            // 
            this.teacherNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.teacherNameInput, "teacherNameInput");
            this.teacherNameInput.Name = "teacherNameInput";
            // 
            // teacherCreate
            // 
            resources.ApplyResources(this.teacherCreate, "teacherCreate");
            this.teacherCreate.Name = "teacherCreate";
            this.teacherCreate.UseVisualStyleBackColor = true;
            this.teacherCreate.Click += new System.EventHandler(this.TeacherCreate_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Name = "label3";
            // 
            // teacherNIFinput
            // 
            this.teacherNIFinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.teacherNIFinput, "teacherNIFinput");
            this.teacherNIFinput.Name = "teacherNIFinput";
            // 
            // employeeUsername
            // 
            resources.ApplyResources(this.employeeUsername, "employeeUsername");
            this.employeeUsername.BackColor = System.Drawing.Color.White;
            this.employeeUsername.ForeColor = System.Drawing.Color.Peru;
            this.employeeUsername.Name = "employeeUsername";
            // 
            // teacherEmailInput
            // 
            this.teacherEmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.teacherEmailInput, "teacherEmailInput");
            this.teacherEmailInput.Name = "teacherEmailInput";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            resources.ApplyResources(this.header1, "header1");
            this.header1.Name = "header1";
            // 
            // CreateTeacher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherNameInput);
            this.Controls.Add(this.teacherCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherNIFinput);
            this.Controls.Add(this.employeeUsername);
            this.Controls.Add(this.teacherEmailInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Name = "CreateTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateTeacher_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacherNameInput;
        private System.Windows.Forms.Button teacherCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherNIFinput;
        private System.Windows.Forms.Label employeeUsername;
        private System.Windows.Forms.TextBox teacherEmailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
    }
}