namespace PSI_DA_PL_B.views.Menu.Dish
{
    partial class Dish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dish));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dishActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dishListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dishCreate = new System.Windows.Forms.Button();
            this.createReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dishEdit = new System.Windows.Forms.Button();
            this.dishRemove = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dishType = new System.Windows.Forms.Label();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.label3 = new System.Windows.Forms.Label();
            this.dishDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Peru;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // dishActive
            // 
            resources.ApplyResources(this.dishActive, "dishActive");
            this.dishActive.BackColor = System.Drawing.Color.Transparent;
            this.dishActive.ForeColor = System.Drawing.Color.Black;
            this.dishActive.Name = "dishActive";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // dishListBox
            // 
            resources.ApplyResources(this.dishListBox, "dishListBox");
            this.dishListBox.FormattingEnabled = true;
            this.dishListBox.Items.AddRange(new object[] {
            resources.GetString("dishListBox.Items"),
            resources.GetString("dishListBox.Items1"),
            resources.GetString("dishListBox.Items2"),
            resources.GetString("dishListBox.Items3"),
            resources.GetString("dishListBox.Items4"),
            resources.GetString("dishListBox.Items5")});
            this.dishListBox.Name = "dishListBox";
            this.dishListBox.SelectedIndexChanged += new System.EventHandler(this.HandleSelectDish);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dishCreate
            // 
            this.dishCreate.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dishCreate, "dishCreate");
            this.dishCreate.ForeColor = System.Drawing.Color.Peru;
            this.dishCreate.Name = "dishCreate";
            this.dishCreate.UseVisualStyleBackColor = false;
            this.dishCreate.Click += new System.EventHandler(this.dishCreate_Click);
            // 
            // createReservation
            // 
            this.createReservation.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.createReservation, "createReservation");
            this.createReservation.ForeColor = System.Drawing.Color.Peru;
            this.createReservation.Name = "createReservation";
            this.createReservation.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Name = "label1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // dishEdit
            // 
            this.dishEdit.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dishEdit, "dishEdit");
            this.dishEdit.ForeColor = System.Drawing.Color.Peru;
            this.dishEdit.Name = "dishEdit";
            this.dishEdit.UseVisualStyleBackColor = false;
            this.dishEdit.Click += new System.EventHandler(this.dishEdit_Click);
            // 
            // dishRemove
            // 
            this.dishRemove.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dishRemove, "dishRemove");
            this.dishRemove.ForeColor = System.Drawing.Color.Peru;
            this.dishRemove.Name = "dishRemove";
            this.dishRemove.UseVisualStyleBackColor = false;
            this.dishRemove.Click += new System.EventHandler(this.dishRemove_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Peru;
            this.label11.Name = "label11";
            // 
            // dishType
            // 
            resources.ApplyResources(this.dishType, "dishType");
            this.dishType.BackColor = System.Drawing.Color.Transparent;
            this.dishType.ForeColor = System.Drawing.Color.Black;
            this.dishType.Name = "dishType";
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            resources.ApplyResources(this.header1, "header1");
            this.header1.Name = "header1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Name = "label3";
            // 
            // dishDescription
            // 
            this.dishDescription.BackColor = System.Drawing.Color.White;
            this.dishDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dishDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.dishDescription, "dishDescription");
            this.dishDescription.Name = "dishDescription";
            this.dishDescription.ReadOnly = true;
            // 
            // Dish
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dishDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dishType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dishRemove);
            this.Controls.Add(this.dishEdit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dishActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dishListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.dishCreate);
            this.Controls.Add(this.createReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "Dish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dish_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dishActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox dishListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private components.Header header1;
        private System.Windows.Forms.Button dishCreate;
        private System.Windows.Forms.Button createReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button dishEdit;
        private System.Windows.Forms.Button dishRemove;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dishType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dishDescription;
    }
}