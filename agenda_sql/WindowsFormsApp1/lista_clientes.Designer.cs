namespace WindowsFormsApp1
{
    partial class lista_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lista_clientes));
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.grade_de_dados = new System.Windows.Forms.DataGridView();
            this.registros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grade_de_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(396, 279);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(96, 31);
            this.cmd_sair.TabIndex = 1;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(294, 279);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(96, 31);
            this.cmd_apagar.TabIndex = 3;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(192, 279);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(96, 31);
            this.cmd_editar.TabIndex = 4;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // grade_de_dados
            // 
            this.grade_de_dados.AllowUserToAddRows = false;
            this.grade_de_dados.AllowUserToDeleteRows = false;
            this.grade_de_dados.AllowUserToOrderColumns = true;
            this.grade_de_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade_de_dados.Location = new System.Drawing.Point(15, 12);
            this.grade_de_dados.Name = "grade_de_dados";
            this.grade_de_dados.ReadOnly = true;
            this.grade_de_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade_de_dados.Size = new System.Drawing.Size(475, 261);
            this.grade_de_dados.TabIndex = 5;
            this.grade_de_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grade_de_dados_CellClick);
            // 
            // registros
            // 
            this.registros.AutoSize = true;
            this.registros.Location = new System.Drawing.Point(12, 279);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(35, 13);
            this.registros.TabIndex = 6;
            this.registros.Text = "label1";
            // 
            // lista_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 322);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.grade_de_dados);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.cmd_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lista_clientes";
            this.Text = "lista_clientes";
            this.Load += new System.EventHandler(this.lista_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grade_de_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.DataGridView grade_de_dados;
        private System.Windows.Forms.Label registros;
    }
}