namespace PSI_DA_PL_B.views.Menu.Dish.Edit
{
    partial class EditDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDish));
            this.finishDishEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dishDescription = new System.Windows.Forms.TextBox();
            this.dishActive = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dishType = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // finishDishEdit
            // 
            this.finishDishEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.finishDishEdit.Location = new System.Drawing.Point(151, 494);
            this.finishDishEdit.Name = "finishDishEdit";
            this.finishDishEdit.Size = new System.Drawing.Size(152, 58);
            this.finishDishEdit.TabIndex = 36;
            this.finishDishEdit.Text = "Guardar";
            this.finishDishEdit.UseVisualStyleBackColor = true;
            this.finishDishEdit.Click += new System.EventHandler(this.finishDishEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descrição";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Peru;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(13, 357);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(431, 29);
            this.textBox5.TabIndex = 34;
            // 
            // dishDescription
            // 
            this.dishDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dishDescription.Location = new System.Drawing.Point(14, 392);
            this.dishDescription.Multiline = true;
            this.dishDescription.Name = "dishDescription";
            this.dishDescription.Size = new System.Drawing.Size(430, 93);
            this.dishDescription.TabIndex = 33;
            this.dishDescription.TextChanged += new System.EventHandler(this.dishDescription_TextChanged);
            // 
            // dishActive
            // 
            this.dishActive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.dishActive.FormattingEnabled = true;
            this.dishActive.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.dishActive.Location = new System.Drawing.Point(263, 268);
            this.dishActive.Name = "dishActive";
            this.dishActive.Size = new System.Drawing.Size(181, 76);
            this.dishActive.TabIndex = 32;
            this.dishActive.SelectedIndexChanged += new System.EventHandler(this.dishActive_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(335, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ativo";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Peru;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(263, 233);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(181, 29);
            this.textBox3.TabIndex = 30;
            // 
            // dishType
            // 
            this.dishType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.dishType.FormattingEnabled = true;
            this.dishType.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegetariano"});
            this.dishType.Location = new System.Drawing.Point(13, 268);
            this.dishType.Name = "dishType";
            this.dishType.Size = new System.Drawing.Size(185, 76);
            this.dishType.TabIndex = 29;
            this.dishType.SelectedIndexChanged += new System.EventHandler(this.dishType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(13, 233);
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
            this.label1.Location = new System.Drawing.Point(133, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Editar Prato";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-1, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 50);
            this.textBox1.TabIndex = 25;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(-1, -1);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(459, 119);
            this.header1.TabIndex = 24;
            // 
            // EditDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 561);
            this.Controls.Add(this.finishDishEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dishDescription);
            this.Controls.Add(this.dishActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dishType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDish_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishDishEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox dishDescription;
        private System.Windows.Forms.CheckedListBox dishActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckedListBox dishType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
    }
}