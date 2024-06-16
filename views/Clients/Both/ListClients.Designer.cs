namespace PSI_DA_PL_B.views.Clients.Both
{
    partial class ListClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClients));
            this.clientsListbox = new System.Windows.Forms.ListBox();
            this.deleteClient = new System.Windows.Forms.Button();
            this.editClient = new System.Windows.Forms.Button();
            this.createClient = new System.Windows.Forms.Button();
            this.searchClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filterClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // clientsListbox
            // 
            this.clientsListbox.FormattingEnabled = true;
            this.clientsListbox.ItemHeight = 16;
            this.clientsListbox.Location = new System.Drawing.Point(16, 446);
            this.clientsListbox.Margin = new System.Windows.Forms.Padding(4);
            this.clientsListbox.Name = "clientsListbox";
            this.clientsListbox.Size = new System.Drawing.Size(717, 260);
            this.clientsListbox.TabIndex = 6;
            // 
            // deleteClient
            // 
            this.deleteClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.deleteClient.Location = new System.Drawing.Point(371, 386);
            this.deleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(169, 39);
            this.deleteClient.TabIndex = 5;
            this.deleteClient.Text = "Apagar";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // editClient
            // 
            this.editClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.editClient.Location = new System.Drawing.Point(194, 386);
            this.editClient.Margin = new System.Windows.Forms.Padding(4);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(169, 39);
            this.editClient.TabIndex = 4;
            this.editClient.Text = "Editar";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // createClient
            // 
            this.createClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.createClient.Location = new System.Drawing.Point(16, 386);
            this.createClient.Margin = new System.Windows.Forms.Padding(4);
            this.createClient.Name = "createClient";
            this.createClient.Size = new System.Drawing.Size(169, 39);
            this.createClient.TabIndex = 3;
            this.createClient.Text = "Criar";
            this.createClient.UseVisualStyleBackColor = true;
            this.createClient.Click += new System.EventHandler(this.CreateClient_Click);
            // 
            // searchClient
            // 
            this.searchClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.searchClient.Location = new System.Drawing.Point(565, 340);
            this.searchClient.Margin = new System.Windows.Forms.Padding(4);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(169, 39);
            this.searchClient.TabIndex = 2;
            this.searchClient.Text = "Pesquisar";
            this.searchClient.UseVisualStyleBackColor = true;
            this.searchClient.Click += new System.EventHandler(this.SearchClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(16, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome do cliente";
            // 
            // filterClient
            // 
            this.filterClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.filterClient.Location = new System.Drawing.Point(16, 340);
            this.filterClient.Margin = new System.Windows.Forms.Padding(4);
            this.filterClient.Name = "filterClient";
            this.filterClient.Size = new System.Drawing.Size(523, 37);
            this.filterClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de Clientes";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 198);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(757, 62);
            this.textBox1.TabIndex = 9;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(757, 144);
            this.header1.TabIndex = 7;
            // 
            // ListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 715);
            this.Controls.Add(this.clientsListbox);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.editClient);
            this.Controls.Add(this.createClient);
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientsListbox;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button createClient;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private components.Header header1;
    }
}