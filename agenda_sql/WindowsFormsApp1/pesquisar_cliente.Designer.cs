namespace WindowsFormsApp1
{
    partial class pesquisar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisar_cliente));
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.text_pesquisa = new System.Windows.Forms.TextBox();
            this.cmd_confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(120, 48);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(99, 31);
            this.cmd_cancelar.TabIndex = 0;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // text_pesquisa
            // 
            this.text_pesquisa.Location = new System.Drawing.Point(12, 22);
            this.text_pesquisa.Name = "text_pesquisa";
            this.text_pesquisa.Size = new System.Drawing.Size(207, 20);
            this.text_pesquisa.TabIndex = 1;
            // 
            // cmd_confirmar
            // 
            this.cmd_confirmar.Location = new System.Drawing.Point(12, 48);
            this.cmd_confirmar.Name = "cmd_confirmar";
            this.cmd_confirmar.Size = new System.Drawing.Size(102, 31);
            this.cmd_confirmar.TabIndex = 2;
            this.cmd_confirmar.Text = "Confirmar";
            this.cmd_confirmar.UseVisualStyleBackColor = true;
            this.cmd_confirmar.Click += new System.EventHandler(this.cmd_confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termo de Pesquisa";
            // 
            // pesquisar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 94);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_confirmar);
            this.Controls.Add(this.text_pesquisa);
            this.Controls.Add(this.cmd_cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisar_cliente";
            this.Text = "pesquisar_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.TextBox text_pesquisa;
        private System.Windows.Forms.Button cmd_confirmar;
        private System.Windows.Forms.Label label1;
    }
}