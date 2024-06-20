namespace PSI_DA_PL_B.views
{
    partial class AtribuirEscritorio
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
            this.totalEscritorios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalUsers = new System.Windows.Forms.ListBox();
            this.addEscritorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalEscritorios
            // 
            this.totalEscritorios.FormattingEnabled = true;
            this.totalEscritorios.Location = new System.Drawing.Point(65, 126);
            this.totalEscritorios.Name = "totalEscritorios";
            this.totalEscritorios.Size = new System.Drawing.Size(170, 199);
            this.totalEscritorios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista escritorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista Users";
            // 
            // totalUsers
            // 
            this.totalUsers.FormattingEnabled = true;
            this.totalUsers.Location = new System.Drawing.Point(529, 126);
            this.totalUsers.Name = "totalUsers";
            this.totalUsers.Size = new System.Drawing.Size(170, 199);
            this.totalUsers.TabIndex = 2;
            // 
            // addEscritorio
            // 
            this.addEscritorio.Location = new System.Drawing.Point(303, 347);
            this.addEscritorio.Name = "addEscritorio";
            this.addEscritorio.Size = new System.Drawing.Size(154, 55);
            this.addEscritorio.TabIndex = 4;
            this.addEscritorio.Text = "Atribuir Escritorio";
            this.addEscritorio.UseVisualStyleBackColor = true;
            this.addEscritorio.Click += new System.EventHandler(this.addEscritorio_Click);
            // 
            // AtribuirEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addEscritorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalEscritorios);
            this.Name = "AtribuirEscritorio";
            this.Text = "AtribuirEscritorio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtribuirEscritorio_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox totalEscritorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox totalUsers;
        private System.Windows.Forms.Button addEscritorio;
    }
}