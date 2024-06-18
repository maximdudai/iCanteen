namespace PSI_DA_PL_B.views.Menu.Balance
{
    partial class Balance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClientNameInput = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientTypeInput = new System.Windows.Forms.Label();
            this.typeClientlabel = new System.Windows.Forms.Label();
            this.ClientNifInput = new System.Windows.Forms.Label();
            this.ClientNifLabel = new System.Windows.Forms.Label();
            this.LoadBalanceButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueToLoad = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CurrentBalance = new System.Windows.Forms.Label();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            ((System.ComponentModel.ISupportInitialize)(this.ValueToLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Peru;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(-1, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(276, 376);
            this.textBox2.TabIndex = 52;
            // 
            // ClientNameInput
            // 
            this.ClientNameInput.AutoSize = true;
            this.ClientNameInput.BackColor = System.Drawing.Color.Peru;
            this.ClientNameInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.ClientNameInput.ForeColor = System.Drawing.Color.White;
            this.ClientNameInput.Location = new System.Drawing.Point(35, 221);
            this.ClientNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameInput.Name = "ClientNameInput";
            this.ClientNameInput.Size = new System.Drawing.Size(163, 28);
            this.ClientNameInput.TabIndex = 54;
            this.ClientNameInput.Text = "Nome cliente";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.BackColor = System.Drawing.Color.Peru;
            this.ClientNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.ClientNameLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.ClientNameLabel.Location = new System.Drawing.Point(38, 201);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(54, 18);
            this.ClientNameLabel.TabIndex = 53;
            this.ClientNameLabel.Text = "Nome";
            // 
            // ClientTypeInput
            // 
            this.ClientTypeInput.AutoSize = true;
            this.ClientTypeInput.BackColor = System.Drawing.Color.Peru;
            this.ClientTypeInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.ClientTypeInput.ForeColor = System.Drawing.Color.White;
            this.ClientTypeInput.Location = new System.Drawing.Point(35, 402);
            this.ClientTypeInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientTypeInput.Name = "ClientTypeInput";
            this.ClientTypeInput.Size = new System.Drawing.Size(128, 28);
            this.ClientTypeInput.TabIndex = 56;
            this.ClientTypeInput.Text = "Estudante";
            // 
            // typeClientlabel
            // 
            this.typeClientlabel.AutoSize = true;
            this.typeClientlabel.BackColor = System.Drawing.Color.Peru;
            this.typeClientlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.typeClientlabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.typeClientlabel.Location = new System.Drawing.Point(36, 382);
            this.typeClientlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeClientlabel.Name = "typeClientlabel";
            this.typeClientlabel.Size = new System.Drawing.Size(126, 18);
            this.typeClientlabel.TabIndex = 55;
            this.typeClientlabel.Text = "Tipo de Cliente";
            // 
            // ClientNifInput
            // 
            this.ClientNifInput.AutoSize = true;
            this.ClientNifInput.BackColor = System.Drawing.Color.Peru;
            this.ClientNifInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.ClientNifInput.ForeColor = System.Drawing.Color.White;
            this.ClientNifInput.Location = new System.Drawing.Point(35, 311);
            this.ClientNifInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNifInput.Name = "ClientNifInput";
            this.ClientNifInput.Size = new System.Drawing.Size(138, 28);
            this.ClientNifInput.TabIndex = 58;
            this.ClientNifInput.Text = "999999999";
            // 
            // ClientNifLabel
            // 
            this.ClientNifLabel.AutoSize = true;
            this.ClientNifLabel.BackColor = System.Drawing.Color.Peru;
            this.ClientNifLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.ClientNifLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.ClientNifLabel.Location = new System.Drawing.Point(38, 291);
            this.ClientNifLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNifLabel.Name = "ClientNifLabel";
            this.ClientNifLabel.Size = new System.Drawing.Size(54, 18);
            this.ClientNifLabel.TabIndex = 57;
            this.ClientNifLabel.Text = "Nome";
            // 
            // LoadBalanceButton
            // 
            this.LoadBalanceButton.BackColor = System.Drawing.Color.White;
            this.LoadBalanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadBalanceButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.LoadBalanceButton.ForeColor = System.Drawing.Color.Peru;
            this.LoadBalanceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadBalanceButton.Location = new System.Drawing.Point(336, 438);
            this.LoadBalanceButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoadBalanceButton.Name = "LoadBalanceButton";
            this.LoadBalanceButton.Size = new System.Drawing.Size(219, 55);
            this.LoadBalanceButton.TabIndex = 62;
            this.LoadBalanceButton.Text = "Carregar";
            this.LoadBalanceButton.UseVisualStyleBackColor = false;
            this.LoadBalanceButton.Click += new System.EventHandler(this.LoadBalanceButton_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.BalanceLabel.ForeColor = System.Drawing.Color.Black;
            this.BalanceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BalanceLabel.Location = new System.Drawing.Point(367, 183);
            this.BalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(144, 28);
            this.BalanceLabel.TabIndex = 66;
            this.BalanceLabel.Text = "Saldo Atual";
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(331, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "Valor a carregar (€)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueToLoad
            // 
            this.ValueToLoad.DecimalPlaces = 2;
            this.ValueToLoad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.ValueToLoad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ValueToLoad.Location = new System.Drawing.Point(365, 358);
            this.ValueToLoad.Margin = new System.Windows.Forms.Padding(4);
            this.ValueToLoad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.ValueToLoad.Name = "ValueToLoad";
            this.ValueToLoad.Size = new System.Drawing.Size(154, 35);
            this.ValueToLoad.TabIndex = 70;
            this.ValueToLoad.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.AutoSize = true;
            this.CurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalance.Location = new System.Drawing.Point(403, 230);
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.Size = new System.Drawing.Size(62, 29);
            this.CurrentBalance.TabIndex = 73;
            this.CurrentBalance.Text = "0,00";
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(-1, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(5);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(589, 146);
            this.header1.TabIndex = 2;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 520);
            this.Controls.Add(this.CurrentBalance);
            this.Controls.Add(this.ValueToLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.LoadBalanceButton);
            this.Controls.Add(this.ClientNifInput);
            this.Controls.Add(this.ClientNifLabel);
            this.Controls.Add(this.ClientTypeInput);
            this.Controls.Add(this.typeClientlabel);
            this.Controls.Add(this.ClientNameInput);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregar Saldo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Balance_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ValueToLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.Header header1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ClientNameInput;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientTypeInput;
        private System.Windows.Forms.Label typeClientlabel;
        private System.Windows.Forms.Label ClientNifInput;
        private System.Windows.Forms.Label ClientNifLabel;
        private System.Windows.Forms.Button LoadBalanceButton;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ValueToLoad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label CurrentBalance;
    }
}