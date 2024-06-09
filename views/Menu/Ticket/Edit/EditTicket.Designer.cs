namespace PSI_DA_PL_B.views.Menu.Ticket.Edit
{
    partial class EditTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTicket));
            this.editTicketButton = new System.Windows.Forms.Button();
            this.newTicketTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.newTicketValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.currentTicketValue = new System.Windows.Forms.Label();
            this.currentTicketTime = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.currentTicketId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newTicketTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTicketValue)).BeginInit();
            this.SuspendLayout();
            // 
            // editTicketButton
            // 
            this.editTicketButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.editTicketButton.Location = new System.Drawing.Point(103, 522);
            this.editTicketButton.Name = "editTicketButton";
            this.editTicketButton.Size = new System.Drawing.Size(236, 45);
            this.editTicketButton.TabIndex = 53;
            this.editTicketButton.Text = "EDIT";
            this.editTicketButton.UseVisualStyleBackColor = true;
            this.editTicketButton.Click += new System.EventHandler(this.editTicketButton_Click);
            // 
            // newTicketTime
            // 
            this.newTicketTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.newTicketTime.Location = new System.Drawing.Point(16, 307);
            this.newTicketTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.newTicketTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newTicketTime.Name = "newTicketTime";
            this.newTicketTime.Size = new System.Drawing.Size(413, 31);
            this.newTicketTime.TabIndex = 52;
            this.newTicketTime.Value = new decimal(new int[] {
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
            this.label1.Location = new System.Drawing.Point(14, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Time (h)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(-1, 276);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(442, 78);
            this.textBox2.TabIndex = 50;
            // 
            // newTicketValue
            // 
            this.newTicketValue.DecimalPlaces = 2;
            this.newTicketValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.newTicketValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.newTicketValue.Location = new System.Drawing.Point(16, 447);
            this.newTicketValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.newTicketValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.newTicketValue.Name = "newTicketValue";
            this.newTicketValue.Size = new System.Drawing.Size(413, 31);
            this.newTicketValue.TabIndex = 49;
            this.newTicketValue.Value = new decimal(new int[] {
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
            this.label2.Location = new System.Drawing.Point(14, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Value (€)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-1, 416);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(442, 78);
            this.textBox1.TabIndex = 47;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(-1, -1);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(442, 119);
            this.header1.TabIndex = 46;
            // 
            // currentTicketValue
            // 
            this.currentTicketValue.AutoSize = true;
            this.currentTicketValue.BackColor = System.Drawing.Color.White;
            this.currentTicketValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.currentTicketValue.ForeColor = System.Drawing.Color.Peru;
            this.currentTicketValue.Location = new System.Drawing.Point(12, 395);
            this.currentTicketValue.Name = "currentTicketValue";
            this.currentTicketValue.Size = new System.Drawing.Size(173, 18);
            this.currentTicketValue.TabIndex = 54;
            this.currentTicketValue.Text = "Current Value: 0.00€";
            // 
            // currentTicketTime
            // 
            this.currentTicketTime.AutoSize = true;
            this.currentTicketTime.BackColor = System.Drawing.Color.White;
            this.currentTicketTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.currentTicketTime.ForeColor = System.Drawing.Color.Peru;
            this.currentTicketTime.Location = new System.Drawing.Point(13, 255);
            this.currentTicketTime.Name = "currentTicketTime";
            this.currentTicketTime.Size = new System.Drawing.Size(141, 18);
            this.currentTicketTime.TabIndex = 55;
            this.currentTicketTime.Text = "Current Time: 2h";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Peru;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(-1, 199);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(442, 10);
            this.textBox3.TabIndex = 56;
            // 
            // currentTicketId
            // 
            this.currentTicketId.AutoSize = true;
            this.currentTicketId.BackColor = System.Drawing.Color.Peru;
            this.currentTicketId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.currentTicketId.ForeColor = System.Drawing.Color.White;
            this.currentTicketId.Location = new System.Drawing.Point(163, 158);
            this.currentTicketId.Name = "currentTicketId";
            this.currentTicketId.Padding = new System.Windows.Forms.Padding(10);
            this.currentTicketId.Size = new System.Drawing.Size(113, 42);
            this.currentTicketId.TabIndex = 57;
            this.currentTicketId.Text = "Ticket #2";
            // 
            // EditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 593);
            this.Controls.Add(this.currentTicketId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.currentTicketTime);
            this.Controls.Add(this.currentTicketValue);
            this.Controls.Add(this.editTicketButton);
            this.Controls.Add(this.newTicketTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.newTicketValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTicket";
            ((System.ComponentModel.ISupportInitialize)(this.newTicketTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTicketValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editTicketButton;
        private System.Windows.Forms.NumericUpDown newTicketTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown newTicketValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
        private System.Windows.Forms.Label currentTicketValue;
        private System.Windows.Forms.Label currentTicketTime;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label currentTicketId;
    }
}