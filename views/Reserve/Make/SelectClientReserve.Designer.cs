namespace PSI_DA_PL_B.views.Reserve.Make
{
    partial class SelectClientReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectClientReserve));
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.StudentRadioButton = new System.Windows.Forms.RadioButton();
            this.TeacherRadioButton = new System.Windows.Forms.RadioButton();
            this.searchClientNif = new System.Windows.Forms.TextBox();
            this.searchClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.TypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.StudentRadioButton);
            this.TypeGroupBox.Controls.Add(this.TeacherRadioButton);
            this.TypeGroupBox.Location = new System.Drawing.Point(202, 151);
            this.TypeGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeGroupBox.Size = new System.Drawing.Size(198, 65);
            this.TypeGroupBox.TabIndex = 72;
            this.TypeGroupBox.TabStop = false;
            // 
            // StudentRadioButton
            // 
            this.StudentRadioButton.AutoSize = true;
            this.StudentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRadioButton.Location = new System.Drawing.Point(4, 39);
            this.StudentRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentRadioButton.Name = "StudentRadioButton";
            this.StudentRadioButton.Size = new System.Drawing.Size(101, 24);
            this.StudentRadioButton.TabIndex = 54;
            this.StudentRadioButton.TabStop = true;
            this.StudentRadioButton.Text = "Estudante";
            this.StudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // TeacherRadioButton
            // 
            this.TeacherRadioButton.AutoSize = true;
            this.TeacherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherRadioButton.Location = new System.Drawing.Point(4, 13);
            this.TeacherRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherRadioButton.Name = "TeacherRadioButton";
            this.TeacherRadioButton.Size = new System.Drawing.Size(95, 24);
            this.TeacherRadioButton.TabIndex = 55;
            this.TeacherRadioButton.TabStop = true;
            this.TeacherRadioButton.Text = "Professor";
            this.TeacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchClientNif
            // 
            this.searchClientNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientNif.Location = new System.Drawing.Point(202, 259);
            this.searchClientNif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchClientNif.Name = "searchClientNif";
            this.searchClientNif.Size = new System.Drawing.Size(198, 25);
            this.searchClientNif.TabIndex = 68;
            // 
            // searchClient
            // 
            this.searchClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.searchClient.Location = new System.Drawing.Point(95, 339);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(236, 45);
            this.searchClient.TabIndex = 67;
            this.searchClient.Text = "CONTINUAR";
            this.searchClient.UseVisualStyleBackColor = true;
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tipo:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(0, 145);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(442, 78);
            this.textBox2.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 26);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nif:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(442, 78);
            this.textBox1.TabIndex = 63;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(442, 119);
            this.header1.TabIndex = 62;
            // 
            // SelectClientReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 420);
            this.Controls.Add(this.TypeGroupBox);
            this.Controls.Add(this.searchClientNif);
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectClientReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva - Selecionar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectClientReserve_FormClosing);
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton StudentRadioButton;
        private System.Windows.Forms.RadioButton TeacherRadioButton;
        private System.Windows.Forms.TextBox searchClientNif;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
    }
}