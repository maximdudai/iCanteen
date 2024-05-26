namespace PSI_DA_PL_B.views.components
{
    partial class ManageUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesList = new System.Windows.Forms.ListBox();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.editEmployee = new System.Windows.Forms.Button();
            this.Criar = new System.Windows.Forms.Button();
            this.searchEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filterEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new PSI_DA_PL_B.views.components.Header();
            this.SuspendLayout();
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.Location = new System.Drawing.Point(12, 362);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(539, 212);
            this.employeesList.TabIndex = 20;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.deleteEmployee.Location = new System.Drawing.Point(278, 314);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(127, 32);
            this.deleteEmployee.TabIndex = 19;
            this.deleteEmployee.Text = "Apagar";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            // 
            // editEmployee
            // 
            this.editEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.editEmployee.Location = new System.Drawing.Point(145, 314);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(127, 32);
            this.editEmployee.TabIndex = 18;
            this.editEmployee.Text = "Editar";
            this.editEmployee.UseVisualStyleBackColor = true;
            // 
            // Criar
            // 
            this.Criar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Criar.Location = new System.Drawing.Point(12, 314);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(127, 32);
            this.Criar.TabIndex = 17;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = true;
            // 
            // searchEmployee
            // 
            this.searchEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.searchEmployee.Location = new System.Drawing.Point(424, 276);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(127, 32);
            this.searchEmployee.TabIndex = 16;
            this.searchEmployee.Text = "Pesquisar";
            this.searchEmployee.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username data";
            // 
            // filterEmployee
            // 
            this.filterEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.filterEmployee.Location = new System.Drawing.Point(12, 276);
            this.filterEmployee.Name = "filterEmployee";
            this.filterEmployee.Size = new System.Drawing.Size(393, 32);
            this.filterEmployee.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de Funcionarios";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 161);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(558, 51);
            this.textBox1.TabIndex = 12;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.Peru;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(558, 117);
            this.header1.TabIndex = 11;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.employeesList);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.searchEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header1);
            this.Name = "ManageUser";
            this.Size = new System.Drawing.Size(558, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeesList;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Button editEmployee;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button searchEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Header header1;
    }
}
