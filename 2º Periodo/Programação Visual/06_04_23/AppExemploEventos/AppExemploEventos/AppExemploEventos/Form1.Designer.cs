namespace AppExemploEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCalculadora = new System.Windows.Forms.Button();
            this.btMensagens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalculadora
            // 
            this.btCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculadora.Location = new System.Drawing.Point(477, 151);
            this.btCalculadora.Name = "btCalculadora";
            this.btCalculadora.Size = new System.Drawing.Size(331, 55);
            this.btCalculadora.TabIndex = 7;
            this.btCalculadora.Text = "CÁLCULO";
            this.btCalculadora.UseVisualStyleBackColor = true;
            this.btCalculadora.Click += new System.EventHandler(this.btCalculadora_Click);
            // 
            // btMensagens
            // 
            this.btMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMensagens.Location = new System.Drawing.Point(83, 151);
            this.btMensagens.Name = "btMensagens";
            this.btMensagens.Size = new System.Drawing.Size(331, 55);
            this.btMensagens.TabIndex = 6;
            this.btMensagens.Text = "MENSAGENS";
            this.btMensagens.UseVisualStyleBackColor = true;
            this.btMensagens.Click += new System.EventHandler(this.btMensagens_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU PRINCIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 376);
            this.Controls.Add(this.btCalculadora);
            this.Controls.Add(this.btMensagens);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCalculadora;
        private System.Windows.Forms.Button btMensagens;
        private System.Windows.Forms.Label label1;
    }
}

