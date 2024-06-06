namespace PSI_DA_PL_B.views.Clients.Students.Create
{
    partial class CreateStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameInput = new System.Windows.Forms.TextBox();
            this.studentCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.studentNIFinput = new System.Windows.Forms.TextBox();
            this.employeeUsername = new System.Windows.Forms.Label();
            this.studentNumberInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(455, 117);
            this.header1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(14, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome do estudante";
            // 
            // studentNameInput
            // 
            this.studentNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentNameInput.Location = new System.Drawing.Point(14, 216);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(430, 32);
            this.studentNameInput.TabIndex = 1;
            // 
            // studentCreate
            // 
            this.studentCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.studentCreate.Location = new System.Drawing.Point(141, 463);
            this.studentCreate.Name = "studentCreate";
            this.studentCreate.Size = new System.Drawing.Size(188, 38);
            this.studentCreate.TabIndex = 4;
            this.studentCreate.Text = "Criar";
            this.studentCreate.UseVisualStyleBackColor = true;
            this.studentCreate.Click += new System.EventHandler(this.studentCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(14, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "NIF do estudante";
            // 
            // studentNIFinput
            // 
            this.studentNIFinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNIFinput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentNIFinput.Location = new System.Drawing.Point(14, 369);
            this.studentNIFinput.Name = "studentNIFinput";
            this.studentNIFinput.Size = new System.Drawing.Size(430, 32);
            this.studentNIFinput.TabIndex = 3;
            // 
            // employeeUsername
            // 
            this.employeeUsername.AutoSize = true;
            this.employeeUsername.BackColor = System.Drawing.Color.White;
            this.employeeUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.employeeUsername.ForeColor = System.Drawing.Color.Peru;
            this.employeeUsername.Location = new System.Drawing.Point(14, 271);
            this.employeeUsername.Name = "employeeUsername";
            this.employeeUsername.Size = new System.Drawing.Size(152, 16);
            this.employeeUsername.TabIndex = 18;
            this.employeeUsername.Text = "Numero de estudante";
            // 
            // studentNumberInput
            // 
            this.studentNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.studentNumberInput.Location = new System.Drawing.Point(14, 290);
            this.studentNumberInput.Name = "studentNumberInput";
            this.studentNumberInput.Size = new System.Drawing.Size(430, 32);
            this.studentNumberInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Criar Estudante";
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
            this.textBox1.TabIndex = 16;
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameInput);
            this.Controls.Add(this.studentCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentNIFinput);
            this.Controls.Add(this.employeeUsername);
            this.Controls.Add(this.studentNumberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Name = "CreateStudent";
            this.Text = "Registar Estudante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNameInput;
        private System.Windows.Forms.Button studentCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentNIFinput;
        private System.Windows.Forms.Label employeeUsername;
        private System.Windows.Forms.TextBox studentNumberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}