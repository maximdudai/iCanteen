namespace PSI_DA_PL_B.views
{
    partial class CriarEscritorio
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
            this.localName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cacifoName = new System.Windows.Forms.TextBox();
            this.criarNovoCacifo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localName
            // 
            this.localName.Location = new System.Drawing.Point(22, 58);
            this.localName.Name = "localName";
            this.localName.Size = new System.Drawing.Size(226, 20);
            this.localName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizacao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cacifo";
            // 
            // cacifoName
            // 
            this.cacifoName.Location = new System.Drawing.Point(25, 160);
            this.cacifoName.Name = "cacifoName";
            this.cacifoName.Size = new System.Drawing.Size(226, 20);
            this.cacifoName.TabIndex = 2;
            // 
            // criarNovoCacifo
            // 
            this.criarNovoCacifo.Location = new System.Drawing.Point(25, 224);
            this.criarNovoCacifo.Name = "criarNovoCacifo";
            this.criarNovoCacifo.Size = new System.Drawing.Size(223, 62);
            this.criarNovoCacifo.TabIndex = 4;
            this.criarNovoCacifo.Text = "Criar";
            this.criarNovoCacifo.UseVisualStyleBackColor = true;
            this.criarNovoCacifo.Click += new System.EventHandler(this.criarNovoCacifo_Click);
            // 
            // CriarEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 339);
            this.Controls.Add(this.criarNovoCacifo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cacifoName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localName);
            this.Name = "CriarEscritorio";
            this.Text = "CriarEscritorio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriarEscritorio_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox localName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cacifoName;
        private System.Windows.Forms.Button criarNovoCacifo;
    }
}