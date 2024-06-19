namespace PSI_DA_PL_B.views.Menu.MenuList
{
    partial class MenuList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuList));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuNextWeek = new System.Windows.Forms.Button();
            this.menuPrevWeek = new System.Windows.Forms.Button();
            this.currentWeekLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyMenuGroup = new System.Windows.Forms.GroupBox();
            this.menuListDays = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.createNewMenu = new System.Windows.Forms.Button();
            this.editMenu = new System.Windows.Forms.Button();
            this.removeMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuType = new System.Windows.Forms.Label();
            this.menuQntAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.menuStudentPrice = new System.Windows.Forms.Label();
            this.menuTeacherPrice = new System.Windows.Forms.Label();
            this.dishList = new System.Windows.Forms.ListBox();
            this.extraList = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.dailyMenuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Peru;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Location = new System.Drawing.Point(13, 150);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(188, 42);
            this.textBox3.TabIndex = 31;
            // 
            // menuNextWeek
            // 
            this.menuNextWeek.BackColor = System.Drawing.Color.Peru;
            this.menuNextWeek.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.menuNextWeek.ForeColor = System.Drawing.Color.White;
            this.menuNextWeek.Location = new System.Drawing.Point(149, 198);
            this.menuNextWeek.Name = "menuNextWeek";
            this.menuNextWeek.Size = new System.Drawing.Size(52, 47);
            this.menuNextWeek.TabIndex = 38;
            this.menuNextWeek.Text = ">";
            this.menuNextWeek.UseVisualStyleBackColor = false;
            this.menuNextWeek.Click += new System.EventHandler(this.menuNextWeek_Click);
            // 
            // menuPrevWeek
            // 
            this.menuPrevWeek.BackColor = System.Drawing.Color.Peru;
            this.menuPrevWeek.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.menuPrevWeek.ForeColor = System.Drawing.Color.White;
            this.menuPrevWeek.Location = new System.Drawing.Point(13, 198);
            this.menuPrevWeek.Name = "menuPrevWeek";
            this.menuPrevWeek.Size = new System.Drawing.Size(52, 47);
            this.menuPrevWeek.TabIndex = 37;
            this.menuPrevWeek.Text = "<";
            this.menuPrevWeek.UseVisualStyleBackColor = false;
            this.menuPrevWeek.Click += new System.EventHandler(this.menuPrevWeek_Click);
            // 
            // currentWeekLabel
            // 
            this.currentWeekLabel.AutoSize = true;
            this.currentWeekLabel.BackColor = System.Drawing.Color.Peru;
            this.currentWeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.currentWeekLabel.ForeColor = System.Drawing.Color.White;
            this.currentWeekLabel.Location = new System.Drawing.Point(71, 196);
            this.currentWeekLabel.Name = "currentWeekLabel";
            this.currentWeekLabel.Size = new System.Drawing.Size(72, 51);
            this.currentWeekLabel.TabIndex = 36;
            this.currentWeekLabel.Text = "22";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Semana";
            // 
            // dailyMenuGroup
            // 
            this.dailyMenuGroup.Controls.Add(this.menuListDays);
            this.dailyMenuGroup.Location = new System.Drawing.Point(13, 263);
            this.dailyMenuGroup.Name = "dailyMenuGroup";
            this.dailyMenuGroup.Size = new System.Drawing.Size(188, 279);
            this.dailyMenuGroup.TabIndex = 40;
            this.dailyMenuGroup.TabStop = false;
            this.dailyMenuGroup.Text = "Menu Diário";
            // 
            // menuListDays
            // 
            this.menuListDays.FormattingEnabled = true;
            this.menuListDays.Location = new System.Drawing.Point(8, 19);
            this.menuListDays.Name = "menuListDays";
            this.menuListDays.Size = new System.Drawing.Size(172, 251);
            this.menuListDays.TabIndex = 0;
            this.menuListDays.SelectedIndexChanged += new System.EventHandler(this.menuListDays_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 37);
            this.label3.TabIndex = 42;
            this.label3.Text = "Informações";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(219, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(323, 95);
            this.textBox1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(630, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "Gerir";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(559, 150);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(244, 95);
            this.textBox2.TabIndex = 43;
            // 
            // createNewMenu
            // 
            this.createNewMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.createNewMenu.Location = new System.Drawing.Point(559, 263);
            this.createNewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.createNewMenu.Name = "createNewMenu";
            this.createNewMenu.Size = new System.Drawing.Size(244, 89);
            this.createNewMenu.TabIndex = 45;
            this.createNewMenu.Text = "Criar";
            this.createNewMenu.UseVisualStyleBackColor = true;
            this.createNewMenu.Click += new System.EventHandler(this.createNewMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.editMenu.Location = new System.Drawing.Point(559, 358);
            this.editMenu.Margin = new System.Windows.Forms.Padding(2);
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(244, 89);
            this.editMenu.TabIndex = 46;
            this.editMenu.Text = "Editar";
            this.editMenu.UseVisualStyleBackColor = true;
            // 
            // removeMenu
            // 
            this.removeMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.removeMenu.Location = new System.Drawing.Point(559, 453);
            this.removeMenu.Margin = new System.Windows.Forms.Padding(2);
            this.removeMenu.Name = "removeMenu";
            this.removeMenu.Size = new System.Drawing.Size(244, 89);
            this.removeMenu.TabIndex = 47;
            this.removeMenu.Text = "Apagar";
            this.removeMenu.UseVisualStyleBackColor = true;
            this.removeMenu.Click += new System.EventHandler(this.removeMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(223, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Horário";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Peru;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(219, 269);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(322, 20);
            this.textBox4.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(223, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Qtd. Disponivel";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Peru;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(219, 326);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(323, 20);
            this.textBox5.TabIndex = 50;
            // 
            // menuType
            // 
            this.menuType.AutoSize = true;
            this.menuType.BackColor = System.Drawing.Color.White;
            this.menuType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.menuType.ForeColor = System.Drawing.Color.Black;
            this.menuType.Location = new System.Drawing.Point(223, 292);
            this.menuType.Name = "menuType";
            this.menuType.Size = new System.Drawing.Size(18, 18);
            this.menuType.TabIndex = 52;
            this.menuType.Text = "--";
            // 
            // menuQntAvailable
            // 
            this.menuQntAvailable.AutoSize = true;
            this.menuQntAvailable.BackColor = System.Drawing.Color.White;
            this.menuQntAvailable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.menuQntAvailable.ForeColor = System.Drawing.Color.Black;
            this.menuQntAvailable.Location = new System.Drawing.Point(223, 349);
            this.menuQntAvailable.Name = "menuQntAvailable";
            this.menuQntAvailable.Size = new System.Drawing.Size(18, 18);
            this.menuQntAvailable.TabIndex = 53;
            this.menuQntAvailable.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Peru;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(223, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 32);
            this.label8.TabIndex = 55;
            this.label8.Text = "Preço\r\nEstudante";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Peru;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Location = new System.Drawing.Point(219, 374);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(160, 37);
            this.textBox6.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Peru;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(386, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 32);
            this.label9.TabIndex = 57;
            this.label9.Text = "Preço\r\nProfessor";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Peru;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Location = new System.Drawing.Point(382, 374);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(159, 37);
            this.textBox7.TabIndex = 56;
            // 
            // menuStudentPrice
            // 
            this.menuStudentPrice.AutoSize = true;
            this.menuStudentPrice.BackColor = System.Drawing.Color.White;
            this.menuStudentPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.menuStudentPrice.ForeColor = System.Drawing.Color.Black;
            this.menuStudentPrice.Location = new System.Drawing.Point(223, 414);
            this.menuStudentPrice.Name = "menuStudentPrice";
            this.menuStudentPrice.Size = new System.Drawing.Size(67, 18);
            this.menuStudentPrice.TabIndex = 58;
            this.menuStudentPrice.Text = "00.00 €";
            // 
            // menuTeacherPrice
            // 
            this.menuTeacherPrice.AutoSize = true;
            this.menuTeacherPrice.BackColor = System.Drawing.Color.White;
            this.menuTeacherPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.menuTeacherPrice.ForeColor = System.Drawing.Color.Black;
            this.menuTeacherPrice.Location = new System.Drawing.Point(386, 414);
            this.menuTeacherPrice.Name = "menuTeacherPrice";
            this.menuTeacherPrice.Size = new System.Drawing.Size(67, 18);
            this.menuTeacherPrice.TabIndex = 59;
            this.menuTeacherPrice.Text = "00.00 €";
            // 
            // dishList
            // 
            this.dishList.FormattingEnabled = true;
            this.dishList.Location = new System.Drawing.Point(220, 473);
            this.dishList.Name = "dishList";
            this.dishList.Size = new System.Drawing.Size(159, 69);
            this.dishList.TabIndex = 60;
            // 
            // extraList
            // 
            this.extraList.FormattingEnabled = true;
            this.extraList.Location = new System.Drawing.Point(382, 473);
            this.extraList.Name = "extraList";
            this.extraList.Size = new System.Drawing.Size(160, 69);
            this.extraList.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Peru;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(223, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 63;
            this.label12.Text = "Pratos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Peru;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(392, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 65;
            this.label13.Text = "Extras";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Peru;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.Location = new System.Drawing.Point(382, 446);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(160, 23);
            this.textBox9.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Peru;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(432, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 40);
            this.label14.TabIndex = 66;
            this.label14.Text = "Menu";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Peru;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.Location = new System.Drawing.Point(221, 446);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(158, 23);
            this.textBox8.TabIndex = 67;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(-1, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(819, 119);
            this.header1.TabIndex = 0;
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 560);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.extraList);
            this.Controls.Add(this.dishList);
            this.Controls.Add(this.menuTeacherPrice);
            this.Controls.Add(this.menuStudentPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.menuQntAvailable);
            this.Controls.Add(this.menuType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.createNewMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dailyMenuGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuNextWeek);
            this.Controls.Add(this.menuPrevWeek);
            this.Controls.Add(this.currentWeekLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.editMenu);
            this.Controls.Add(this.removeMenu);
            this.Controls.Add(this.textBox8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuList_FormClosing);
            this.dailyMenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button menuNextWeek;
        private System.Windows.Forms.Button menuPrevWeek;
        private System.Windows.Forms.Label currentWeekLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dailyMenuGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createNewMenu;
        private System.Windows.Forms.Button editMenu;
        private System.Windows.Forms.Button removeMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label menuType;
        private System.Windows.Forms.Label menuQntAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label menuStudentPrice;
        private System.Windows.Forms.Label menuTeacherPrice;
        private System.Windows.Forms.ListBox dishList;
        private System.Windows.Forms.ListBox extraList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListBox menuListDays;
    }
}