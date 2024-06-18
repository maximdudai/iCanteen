using PSI_DA_PL_B.Properties;

namespace PSI_DA_PL_B.views.Menu.Extra.Create
{
    partial class CreateExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateExtra));
            this.createExtraButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.extraDescription = new System.Windows.Forms.TextBox();
            this.extraActive = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.extraPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createExtraButton
            // 
            this.createExtraButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.createExtraButton.Location = new System.Drawing.Point(152, 495);
            this.createExtraButton.Name = "createExtraButton";
            this.createExtraButton.Size = new System.Drawing.Size(152, 58);
            this.createExtraButton.TabIndex = 36;
            this.createExtraButton.Text = "Criar";
            this.createExtraButton.UseVisualStyleBackColor = true;
            this.createExtraButton.Click += new System.EventHandler(this.createExtraButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descrição";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Peru;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(14, 358);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(431, 29);
            this.textBox5.TabIndex = 34;
            // 
            // extraDescription
            // 
            this.extraDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraDescription.Location = new System.Drawing.Point(15, 393);
            this.extraDescription.Multiline = true;
            this.extraDescription.Name = "extraDescription";
            this.extraDescription.Size = new System.Drawing.Size(430, 93);
            this.extraDescription.TabIndex = 33;
            // 
            // extraActive
            // 
            this.extraActive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.extraActive.FormattingEnabled = true;
            this.extraActive.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.extraActive.Location = new System.Drawing.Point(264, 269);
            this.extraActive.Name = "extraActive";
            this.extraActive.Size = new System.Drawing.Size(181, 76);
            this.extraActive.TabIndex = 32;
            this.extraActive.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.extraActive_ItemCheck_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ativo";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Peru;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(264, 234);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(181, 29);
            this.textBox3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Preço";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(14, 234);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(185, 29);
            this.textBox2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Criar Extra";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 50);
            this.textBox1.TabIndex = 25;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(459, 119);
            this.header1.TabIndex = 24;
            // 
            // extraPrice
            // 
            this.extraPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraPrice.Location = new System.Drawing.Point(14, 269);
            this.extraPrice.Name = "extraPrice";
            this.extraPrice.Size = new System.Drawing.Size(185, 20);
            this.extraPrice.TabIndex = 37;
            // 
            // CreateExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 564);
            this.Controls.Add(this.extraPrice);
            this.Controls.Add(this.createExtraButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.extraDescription);
            this.Controls.Add(this.extraActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateExtra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateExtra_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createExtraButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox extraDescription;
        private System.Windows.Forms.CheckedListBox extraActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
        private System.Windows.Forms.TextBox extraPrice;
    }
}