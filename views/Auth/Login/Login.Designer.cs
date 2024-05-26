namespace PSI_DA_PL_B.views.Auth.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.employeesButton = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(-1, 187);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(449, 45);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(9, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // loginUsername
            // 
            this.loginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.loginUsername.Location = new System.Drawing.Point(12, 196);
            this.loginUsername.MaxLength = 64;
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(424, 26);
            this.loginUsername.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Peru;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(-1, 258);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(449, 45);
            this.textBox4.TabIndex = 6;
            // 
            // employeesButton
            // 
            this.employeesButton.AutoSize = true;
            this.employeesButton.BackColor = System.Drawing.Color.White;
            this.employeesButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesButton.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.employeesButton.ForeColor = System.Drawing.Color.Black;
            this.employeesButton.Location = new System.Drawing.Point(157, 340);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.employeesButton.Size = new System.Drawing.Size(167, 29);
            this.employeesButton.TabIndex = 7;
            this.employeesButton.Text = "Listagem de Funcionarios";
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.Peru;
            this.loginButton.Location = new System.Drawing.Point(90, 258);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(134, 45);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registerButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.registerButton.ForeColor = System.Drawing.Color.Peru;
            this.registerButton.Location = new System.Drawing.Point(237, 258);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(134, 45);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Registar";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(-1, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(449, 108);
            this.header1.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 392);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label employeesButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private components.Header header1;
    }
}