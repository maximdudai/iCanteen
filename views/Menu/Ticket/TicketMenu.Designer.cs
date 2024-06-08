namespace PSI_DA_PL_B.views.Menu.TicketMenu
{
    partial class TicketMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketMenu));
            this.ticketValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ticketTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.createTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketList = new System.Windows.Forms.ListBox();
            this.editTicket = new System.Windows.Forms.Button();
            this.removeTicket = new System.Windows.Forms.Button();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            ((System.ComponentModel.ISupportInitialize)(this.ticketValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketValue
            // 
            this.ticketValue.DecimalPlaces = 2;
            this.ticketValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.ticketValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ticketValue.Location = new System.Drawing.Point(16, 264);
            this.ticketValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ticketValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ticketValue.Name = "ticketValue";
            this.ticketValue.Size = new System.Drawing.Size(413, 31);
            this.ticketValue.TabIndex = 38;
            this.ticketValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Value (€)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-1, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(442, 78);
            this.textBox1.TabIndex = 36;
            // 
            // ticketTime
            // 
            this.ticketTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.ticketTime.Location = new System.Drawing.Point(16, 180);
            this.ticketTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ticketTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ticketTime.Name = "ticketTime";
            this.ticketTime.Size = new System.Drawing.Size(413, 31);
            this.ticketTime.TabIndex = 41;
            this.ticketTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Time (h)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(-1, 149);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(442, 78);
            this.textBox2.TabIndex = 39;
            // 
            // createTicket
            // 
            this.createTicket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.createTicket.Location = new System.Drawing.Point(101, 317);
            this.createTicket.Name = "createTicket";
            this.createTicket.Size = new System.Drawing.Size(236, 45);
            this.createTicket.TabIndex = 42;
            this.createTicket.Text = "CREATE";
            this.createTicket.UseVisualStyleBackColor = true;
            this.createTicket.Click += new System.EventHandler(this.createTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketList);
            this.groupBox1.Location = new System.Drawing.Point(17, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 174);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // ticketList
            // 
            this.ticketList.FormattingEnabled = true;
            this.ticketList.Location = new System.Drawing.Point(7, 20);
            this.ticketList.Name = "ticketList";
            this.ticketList.Size = new System.Drawing.Size(285, 147);
            this.ticketList.TabIndex = 0;
            // 
            // editTicket
            // 
            this.editTicket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.editTicket.Location = new System.Drawing.Point(324, 387);
            this.editTicket.Name = "editTicket";
            this.editTicket.Size = new System.Drawing.Size(108, 67);
            this.editTicket.TabIndex = 44;
            this.editTicket.Text = "EDIT";
            this.editTicket.UseVisualStyleBackColor = true;
            // 
            // removeTicket
            // 
            this.removeTicket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.removeTicket.Location = new System.Drawing.Point(324, 485);
            this.removeTicket.Name = "removeTicket";
            this.removeTicket.Size = new System.Drawing.Size(108, 67);
            this.removeTicket.TabIndex = 45;
            this.removeTicket.Text = "REMOVE";
            this.removeTicket.UseVisualStyleBackColor = true;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(-1, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(442, 119);
            this.header1.TabIndex = 0;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 581);
            this.Controls.Add(this.editTicket);
            this.Controls.Add(this.removeTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createTicket);
            this.Controls.Add(this.ticketTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ticketValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.ticketValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.NumericUpDown ticketValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown ticketTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editTicket;
        private System.Windows.Forms.Button removeTicket;
        private System.Windows.Forms.ListBox ticketList;
    }
}