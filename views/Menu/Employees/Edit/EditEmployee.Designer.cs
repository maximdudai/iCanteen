namespace PSI_DA_PL_B.views.Auth.Employees.Edit
{
    partial class EditEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.employeeNameInput = new System.Windows.Forms.TextBox();
            this.employeeEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeNIFinput = new System.Windows.Forms.TextBox();
            this.employeeUsername = new System.Windows.Forms.Label();
            this.employeeUsernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name do funcionario";
            // 
            // employeeNameInput
            // 
            this.employeeNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeNameInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.employeeNameInput.Location = new System.Drawing.Point(12, 217);
            this.employeeNameInput.Name = "employeeNameInput";
            this.employeeNameInput.Size = new System.Drawing.Size(430, 32);
            this.employeeNameInput.TabIndex = 1;
            // 
            // employeeEdit
            // 
            this.employeeEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.employeeEdit.Location = new System.Drawing.Point(139, 464);
            this.employeeEdit.Name = "employeeEdit";
            this.employeeEdit.Size = new System.Drawing.Size(188, 38);
            this.employeeEdit.TabIndex = 4;
            this.employeeEdit.Text = "Editar";
            this.employeeEdit.UseVisualStyleBackColor = true;
            this.employeeEdit.Click += new System.EventHandler(this.employeeEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "NIF do funcionario";
            // 
            // employeeNIFinput
            // 
            this.employeeNIFinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeNIFinput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.employeeNIFinput.Location = new System.Drawing.Point(12, 370);
            this.employeeNIFinput.Name = "employeeNIFinput";
            this.employeeNIFinput.Size = new System.Drawing.Size(430, 32);
            this.employeeNIFinput.TabIndex = 3;
            // 
            // employeeUsername
            // 
            this.employeeUsername.AutoSize = true;
            this.employeeUsername.BackColor = System.Drawing.Color.White;
            this.employeeUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.employeeUsername.ForeColor = System.Drawing.Color.Peru;
            this.employeeUsername.Location = new System.Drawing.Point(12, 272);
            this.employeeUsername.Name = "employeeUsername";
            this.employeeUsername.Size = new System.Drawing.Size(176, 16);
            this.employeeUsername.TabIndex = 16;
            this.employeeUsername.Text = "Username do funcionario";
            // 
            // employeeUsernameInput
            // 
            this.employeeUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeUsernameInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.employeeUsernameInput.Location = new System.Drawing.Point(12, 291);
            this.employeeUsernameInput.Name = "employeeUsernameInput";
            this.employeeUsernameInput.Size = new System.Drawing.Size(430, 32);
            this.employeeUsernameInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Editar Funcionario";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(455, 51);
            this.textBox1.TabIndex = 13;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(455, 117);
            this.header1.TabIndex = 12;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeNameInput);
            this.Controls.Add(this.employeeEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeNIFinput);
            this.Controls.Add(this.employeeUsername);
            this.Controls.Add(this.employeeUsernameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Name = "EditEmployee";
            this.Text = "Editar Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeNameInput;
        private System.Windows.Forms.Button employeeEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeNIFinput;
        private System.Windows.Forms.Label employeeUsername;
        private System.Windows.Forms.TextBox employeeUsernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
    }
}