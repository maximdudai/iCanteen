namespace PSI_DA_PL_B.views.Menu.MenuList.Edit
{
    partial class EditMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenu));
            this.menuTypeJantar = new System.Windows.Forms.RadioButton();
            this.menuTypeAlmoco = new System.Windows.Forms.RadioButton();
            this.menuStockValue = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.createPriceTeach = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.createPriceStudent = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.priceForTeacher = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.priceForStudent = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuDefinedType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuDefinedDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addDishToMenu = new System.Windows.Forms.Button();
            this.addExtraToMenu = new System.Windows.Forms.Button();
            this.addedExtraList = new System.Windows.Forms.ListBox();
            this.addedDishList = new System.Windows.Forms.ListBox();
            this.availableExtraList = new System.Windows.Forms.ListBox();
            this.availableDishList = new System.Windows.Forms.ListBox();
            this.saveMenuList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            ((System.ComponentModel.ISupportInitialize)(this.menuStockValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPriceTeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPriceStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTypeJantar
            // 
            this.menuTypeJantar.AutoSize = true;
            this.menuTypeJantar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.menuTypeJantar.Location = new System.Drawing.Point(360, 244);
            this.menuTypeJantar.Name = "menuTypeJantar";
            this.menuTypeJantar.Size = new System.Drawing.Size(14, 13);
            this.menuTypeJantar.TabIndex = 147;
            this.menuTypeJantar.UseVisualStyleBackColor = true;
            this.menuTypeJantar.CheckedChanged += new System.EventHandler(this.menuTypeJantar_CheckedChanged);
            // 
            // menuTypeAlmoco
            // 
            this.menuTypeAlmoco.AutoSize = true;
            this.menuTypeAlmoco.Checked = true;
            this.menuTypeAlmoco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.menuTypeAlmoco.Location = new System.Drawing.Point(299, 244);
            this.menuTypeAlmoco.Name = "menuTypeAlmoco";
            this.menuTypeAlmoco.Size = new System.Drawing.Size(14, 13);
            this.menuTypeAlmoco.TabIndex = 146;
            this.menuTypeAlmoco.TabStop = true;
            this.menuTypeAlmoco.UseVisualStyleBackColor = true;
            this.menuTypeAlmoco.CheckedChanged += new System.EventHandler(this.menuTypeAlmoco_CheckedChanged);
            // 
            // menuStockValue
            // 
            this.menuStockValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.menuStockValue.Location = new System.Drawing.Point(8, 417);
            this.menuStockValue.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.menuStockValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.menuStockValue.Name = "menuStockValue";
            this.menuStockValue.Size = new System.Drawing.Size(430, 29);
            this.menuStockValue.TabIndex = 145;
            this.menuStockValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.menuStockValue.ValueChanged += new System.EventHandler(this.menuStockValue_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Peru;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 144;
            this.label11.Text = "Stock";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.Peru;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox13.Location = new System.Drawing.Point(8, 382);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(430, 29);
            this.textBox13.TabIndex = 143;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Peru;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(242, 468);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 17);
            this.label20.TabIndex = 142;
            this.label20.Text = "Prato";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Peru;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox11.Location = new System.Drawing.Point(238, 462);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(200, 29);
            this.textBox11.TabIndex = 141;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Peru;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 468);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 17);
            this.label19.TabIndex = 140;
            this.label19.Text = "Extra";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Peru;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox10.Location = new System.Drawing.Point(8, 462);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(200, 29);
            this.textBox10.TabIndex = 139;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(346, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 32);
            this.label18.TabIndex = 138;
            this.label18.Text = "Jantar\r\n18:00 - 20:00";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createPriceTeach
            // 
            this.createPriceTeach.DecimalPlaces = 2;
            this.createPriceTeach.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.createPriceTeach.Location = new System.Drawing.Point(238, 336);
            this.createPriceTeach.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.createPriceTeach.Name = "createPriceTeach";
            this.createPriceTeach.Size = new System.Drawing.Size(173, 29);
            this.createPriceTeach.TabIndex = 137;
            this.createPriceTeach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.createPriceTeach.ValueChanged += new System.EventHandler(this.createPriceTeach_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(414, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 22);
            this.label9.TabIndex = 136;
            this.label9.Text = "€";
            // 
            // createPriceStudent
            // 
            this.createPriceStudent.DecimalPlaces = 2;
            this.createPriceStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.createPriceStudent.Location = new System.Drawing.Point(8, 336);
            this.createPriceStudent.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.createPriceStudent.Name = "createPriceStudent";
            this.createPriceStudent.Size = new System.Drawing.Size(173, 29);
            this.createPriceStudent.TabIndex = 135;
            this.createPriceStudent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.createPriceStudent.ValueChanged += new System.EventHandler(this.createPriceStudent_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(184, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 22);
            this.label17.TabIndex = 134;
            this.label17.Text = "€";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Peru;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(242, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 133;
            this.label16.Text = "Valor (Prof)";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Peru;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox12.Location = new System.Drawing.Point(238, 301);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(200, 29);
            this.textBox12.TabIndex = 132;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Peru;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 131;
            this.label15.Text = "Valor (Est)";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Peru;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.Location = new System.Drawing.Point(8, 301);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(200, 29);
            this.textBox9.TabIndex = 130;
            // 
            // priceForTeacher
            // 
            this.priceForTeacher.AutoSize = true;
            this.priceForTeacher.BackColor = System.Drawing.Color.White;
            this.priceForTeacher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.priceForTeacher.ForeColor = System.Drawing.Color.Black;
            this.priceForTeacher.Location = new System.Drawing.Point(597, 318);
            this.priceForTeacher.Name = "priceForTeacher";
            this.priceForTeacher.Size = new System.Drawing.Size(62, 17);
            this.priceForTeacher.TabIndex = 129;
            this.priceForTeacher.Text = "00.00 €";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Peru;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(597, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 128;
            this.label12.Text = "Valor (Prof)";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Peru;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Location = new System.Drawing.Point(594, 286);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(129, 29);
            this.textBox7.TabIndex = 127;
            // 
            // priceForStudent
            // 
            this.priceForStudent.AutoSize = true;
            this.priceForStudent.BackColor = System.Drawing.Color.White;
            this.priceForStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.priceForStudent.ForeColor = System.Drawing.Color.Black;
            this.priceForStudent.Location = new System.Drawing.Point(455, 318);
            this.priceForStudent.Name = "priceForStudent";
            this.priceForStudent.Size = new System.Drawing.Size(62, 17);
            this.priceForStudent.TabIndex = 126;
            this.priceForStudent.Text = "00.00 €";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Peru;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(455, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 125;
            this.label14.Text = "Valor (Est)";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Peru;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.Location = new System.Drawing.Point(452, 286);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(132, 29);
            this.textBox8.TabIndex = 124;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Peru;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(242, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 123;
            this.label10.Text = "Horário";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Peru;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Location = new System.Drawing.Point(238, 204);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(200, 29);
            this.textBox6.TabIndex = 122;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(235, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 121;
            this.label8.Text = "Almoço\r\n12:00 - 14:00";
            // 
            // menuDefinedType
            // 
            this.menuDefinedType.AutoSize = true;
            this.menuDefinedType.BackColor = System.Drawing.Color.White;
            this.menuDefinedType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.menuDefinedType.ForeColor = System.Drawing.Color.Black;
            this.menuDefinedType.Location = new System.Drawing.Point(597, 236);
            this.menuDefinedType.Name = "menuDefinedType";
            this.menuDefinedType.Size = new System.Drawing.Size(63, 17);
            this.menuDefinedType.TabIndex = 120;
            this.menuDefinedType.Text = "Almoço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Peru;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(597, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 119;
            this.label6.Text = "Horário ";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Peru;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(594, 204);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(129, 29);
            this.textBox5.TabIndex = 118;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(8, 239);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 117;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // menuDefinedDate
            // 
            this.menuDefinedDate.AutoSize = true;
            this.menuDefinedDate.BackColor = System.Drawing.Color.White;
            this.menuDefinedDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.menuDefinedDate.ForeColor = System.Drawing.Color.Black;
            this.menuDefinedDate.Location = new System.Drawing.Point(455, 236);
            this.menuDefinedDate.Name = "menuDefinedDate";
            this.menuDefinedDate.Size = new System.Drawing.Size(90, 17);
            this.menuDefinedDate.TabIndex = 116;
            this.menuDefinedDate.Text = "00-00-0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Data";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Peru;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(8, 204);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(200, 29);
            this.textBox4.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Data";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(452, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 29);
            this.textBox2.TabIndex = 112;
            // 
            // addDishToMenu
            // 
            this.addDishToMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.addDishToMenu.Location = new System.Drawing.Point(238, 618);
            this.addDishToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.addDishToMenu.Name = "addDishToMenu";
            this.addDishToMenu.Size = new System.Drawing.Size(200, 52);
            this.addDishToMenu.TabIndex = 111;
            this.addDishToMenu.Text = "Adicionar";
            this.addDishToMenu.UseVisualStyleBackColor = true;
            this.addDishToMenu.Click += new System.EventHandler(this.addDishToMenu_Click);
            // 
            // addExtraToMenu
            // 
            this.addExtraToMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.addExtraToMenu.Location = new System.Drawing.Point(8, 618);
            this.addExtraToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.addExtraToMenu.Name = "addExtraToMenu";
            this.addExtraToMenu.Size = new System.Drawing.Size(200, 52);
            this.addExtraToMenu.TabIndex = 110;
            this.addExtraToMenu.Text = "Adicionar";
            this.addExtraToMenu.UseVisualStyleBackColor = true;
            this.addExtraToMenu.Click += new System.EventHandler(this.addExtraToMenu_Click);
            // 
            // addedExtraList
            // 
            this.addedExtraList.FormattingEnabled = true;
            this.addedExtraList.Location = new System.Drawing.Point(452, 468);
            this.addedExtraList.Name = "addedExtraList";
            this.addedExtraList.Size = new System.Drawing.Size(271, 121);
            this.addedExtraList.TabIndex = 109;
            this.addedExtraList.DoubleClick += new System.EventHandler(this.addedExtraList_DoubleClick);
            // 
            // addedDishList
            // 
            this.addedDishList.FormattingEnabled = true;
            this.addedDishList.Location = new System.Drawing.Point(452, 352);
            this.addedDishList.Name = "addedDishList";
            this.addedDishList.Size = new System.Drawing.Size(271, 108);
            this.addedDishList.TabIndex = 108;
            this.addedDishList.DoubleClick += new System.EventHandler(this.addedDishList_DoubleClick);
            // 
            // availableExtraList
            // 
            this.availableExtraList.FormattingEnabled = true;
            this.availableExtraList.Location = new System.Drawing.Point(8, 497);
            this.availableExtraList.Name = "availableExtraList";
            this.availableExtraList.Size = new System.Drawing.Size(200, 95);
            this.availableExtraList.TabIndex = 107;
            // 
            // availableDishList
            // 
            this.availableDishList.FormattingEnabled = true;
            this.availableDishList.Location = new System.Drawing.Point(238, 498);
            this.availableDishList.Name = "availableDishList";
            this.availableDishList.Size = new System.Drawing.Size(200, 95);
            this.availableDishList.TabIndex = 106;
            // 
            // saveMenuList
            // 
            this.saveMenuList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.saveMenuList.Location = new System.Drawing.Point(452, 618);
            this.saveMenuList.Margin = new System.Windows.Forms.Padding(2);
            this.saveMenuList.Name = "saveMenuList";
            this.saveMenuList.Size = new System.Drawing.Size(271, 52);
            this.saveMenuList.TabIndex = 105;
            this.saveMenuList.Text = "Guardar";
            this.saveMenuList.UseVisualStyleBackColor = true;
            this.saveMenuList.Click += new System.EventHandler(this.createMenuList_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(444, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(2, 523);
            this.textBox1.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 103;
            this.label1.Text = "Criar Menu";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Peru;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Location = new System.Drawing.Point(0, 125);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(739, 42);
            this.textBox3.TabIndex = 102;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(739, 119);
            this.header1.TabIndex = 101;
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 688);
            this.Controls.Add(this.menuTypeJantar);
            this.Controls.Add(this.menuTypeAlmoco);
            this.Controls.Add(this.menuStockValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.createPriceTeach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.createPriceStudent);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.priceForTeacher);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.priceForStudent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuDefinedType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuDefinedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.addDishToMenu);
            this.Controls.Add(this.addExtraToMenu);
            this.Controls.Add(this.addedExtraList);
            this.Controls.Add(this.addedDishList);
            this.Controls.Add(this.availableExtraList);
            this.Controls.Add(this.availableDishList);
            this.Controls.Add(this.saveMenuList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.menuStockValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPriceTeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPriceStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton menuTypeJantar;
        private System.Windows.Forms.RadioButton menuTypeAlmoco;
        private System.Windows.Forms.NumericUpDown menuStockValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown createPriceTeach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown createPriceStudent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label priceForTeacher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label priceForStudent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label menuDefinedType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label menuDefinedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addDishToMenu;
        private System.Windows.Forms.Button addExtraToMenu;
        private System.Windows.Forms.ListBox addedExtraList;
        private System.Windows.Forms.ListBox addedDishList;
        private System.Windows.Forms.ListBox availableExtraList;
        private System.Windows.Forms.ListBox availableDishList;
        private System.Windows.Forms.Button saveMenuList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private components.Header header1;
    }
}