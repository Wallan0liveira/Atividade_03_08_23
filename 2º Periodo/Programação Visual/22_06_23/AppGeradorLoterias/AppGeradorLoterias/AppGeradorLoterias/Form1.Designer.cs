namespace AppGeradorLoterias
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
            this.btQuina = new System.Windows.Forms.Button();
            this.btMega = new System.Windows.Forms.Button();
            this.btLotoFacil = new System.Windows.Forms.Button();
            this.btLotoMania = new System.Windows.Forms.Button();
            this.btDiaDeSorte = new System.Windows.Forms.Button();
            this.btSuperSete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuina
            // 
            this.btQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuina.ForeColor = System.Drawing.Color.Blue;
            this.btQuina.Location = new System.Drawing.Point(13, 103);
            this.btQuina.Name = "btQuina";
            this.btQuina.Size = new System.Drawing.Size(179, 42);
            this.btQuina.TabIndex = 29;
            this.btQuina.Text = "QUINA";
            this.btQuina.UseVisualStyleBackColor = true;
            this.btQuina.Click += new System.EventHandler(this.btQuina_Click);
            // 
            // btMega
            // 
            this.btMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMega.ForeColor = System.Drawing.Color.Green;
            this.btMega.Location = new System.Drawing.Point(13, 14);
            this.btMega.Name = "btMega";
            this.btMega.Size = new System.Drawing.Size(179, 42);
            this.btMega.TabIndex = 28;
            this.btMega.Text = "MEGA SENA";
            this.btMega.UseVisualStyleBackColor = true;
            this.btMega.Click += new System.EventHandler(this.btMega_Click);
            // 
            // btLotoFacil
            // 
            this.btLotoFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotoFacil.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btLotoFacil.Location = new System.Drawing.Point(208, 14);
            this.btLotoFacil.Name = "btLotoFacil";
            this.btLotoFacil.Size = new System.Drawing.Size(179, 42);
            this.btLotoFacil.TabIndex = 27;
            this.btLotoFacil.Text = "LOTOFÁCIL";
            this.btLotoFacil.UseVisualStyleBackColor = true;
            this.btLotoFacil.Click += new System.EventHandler(this.btLotoFacil_Click);
            // 
            // btLotoMania
            // 
            this.btLotoMania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotoMania.ForeColor = System.Drawing.Color.DarkOrange;
            this.btLotoMania.Location = new System.Drawing.Point(208, 103);
            this.btLotoMania.Name = "btLotoMania";
            this.btLotoMania.Size = new System.Drawing.Size(179, 42);
            this.btLotoMania.TabIndex = 30;
            this.btLotoMania.Text = "LOTOMANIA";
            this.btLotoMania.UseVisualStyleBackColor = true;
            this.btLotoMania.Click += new System.EventHandler(this.btLotoMania_Click);
            // 
            // btDiaDeSorte
            // 
            this.btDiaDeSorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiaDeSorte.ForeColor = System.Drawing.Color.Gold;
            this.btDiaDeSorte.Location = new System.Drawing.Point(12, 191);
            this.btDiaDeSorte.Name = "btDiaDeSorte";
            this.btDiaDeSorte.Size = new System.Drawing.Size(180, 42);
            this.btDiaDeSorte.TabIndex = 31;
            this.btDiaDeSorte.Text = "DIA DE SORTE";
            this.btDiaDeSorte.UseVisualStyleBackColor = true;
            this.btDiaDeSorte.Click += new System.EventHandler(this.btDiaDeSorte_Click);
            // 
            // btSuperSete
            // 
            this.btSuperSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuperSete.ForeColor = System.Drawing.Color.LimeGreen;
            this.btSuperSete.Location = new System.Drawing.Point(207, 191);
            this.btSuperSete.Name = "btSuperSete";
            this.btSuperSete.Size = new System.Drawing.Size(180, 42);
            this.btSuperSete.TabIndex = 32;
            this.btSuperSete.Text = "SUPER SETE";
            this.btSuperSete.UseVisualStyleBackColor = true;
            this.btSuperSete.Click += new System.EventHandler(this.btSuperSete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 246);
            this.Controls.Add(this.btSuperSete);
            this.Controls.Add(this.btDiaDeSorte);
            this.Controls.Add(this.btLotoMania);
            this.Controls.Add(this.btQuina);
            this.Controls.Add(this.btMega);
            this.Controls.Add(this.btLotoFacil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuina;
        private System.Windows.Forms.Button btMega;
        private System.Windows.Forms.Button btLotoFacil;
        private System.Windows.Forms.Button btLotoMania;
        private System.Windows.Forms.Button btDiaDeSorte;
        private System.Windows.Forms.Button btSuperSete;
    }
}

