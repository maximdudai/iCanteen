namespace PSI_DA_PL_B.views.Reserve
{
    partial class ChooseTabReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTabReserve));
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.ChooseMakeReserve = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ChooseConfirmeReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(605, 144);
            this.header1.TabIndex = 22;
            // 
            // ChooseMakeReserve
            // 
            this.ChooseMakeReserve.BackColor = System.Drawing.Color.White;
            this.ChooseMakeReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChooseMakeReserve.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseMakeReserve.ForeColor = System.Drawing.Color.Peru;
            this.ChooseMakeReserve.Location = new System.Drawing.Point(23, 244);
            this.ChooseMakeReserve.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseMakeReserve.Name = "ChooseMakeReserve";
            this.ChooseMakeReserve.Size = new System.Drawing.Size(265, 84);
            this.ChooseMakeReserve.TabIndex = 18;
            this.ChooseMakeReserve.Text = "Efetuar Reserva";
            this.ChooseMakeReserve.UseVisualStyleBackColor = false;
            this.ChooseMakeReserve.Click += new System.EventHandler(this.ChooseMakeReserve_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Peru;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(0, 198);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(608, 177);
            this.textBox4.TabIndex = 21;
            // 
            // ChooseConfirmeReserve
            // 
            this.ChooseConfirmeReserve.BackColor = System.Drawing.Color.White;
            this.ChooseConfirmeReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChooseConfirmeReserve.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseConfirmeReserve.ForeColor = System.Drawing.Color.Peru;
            this.ChooseConfirmeReserve.Location = new System.Drawing.Point(313, 244);
            this.ChooseConfirmeReserve.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseConfirmeReserve.Name = "ChooseConfirmeReserve";
            this.ChooseConfirmeReserve.Size = new System.Drawing.Size(265, 84);
            this.ChooseConfirmeReserve.TabIndex = 23;
            this.ChooseConfirmeReserve.Text = "Confirmar Reserva";
            this.ChooseConfirmeReserve.UseVisualStyleBackColor = false;
            this.ChooseConfirmeReserve.Click += new System.EventHandler(this.ChooseConfirmeReserve_Click);
            // 
            // ChooseTabReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 423);
            this.Controls.Add(this.ChooseConfirmeReserve);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.ChooseMakeReserve);
            this.Controls.Add(this.textBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseTabReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar/ Confirmar Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseTabReserve_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.Button ChooseMakeReserve;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ChooseConfirmeReserve;
    }
}