namespace ExemplosGrids
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
            this.cbForms = new System.Windows.Forms.ComboBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbForms
            // 
            this.cbForms.FormattingEnabled = true;
            this.cbForms.Items.AddRange(new object[] {
            "Pedido",
            "Reajuste",
            "Notas"});
            this.cbForms.Location = new System.Drawing.Point(315, 113);
            this.cbForms.Name = "cbForms";
            this.cbForms.Size = new System.Drawing.Size(121, 21);
            this.cbForms.TabIndex = 0;
            this.cbForms.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(337, 84);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 1;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.cbForms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbForms;
        private System.Windows.Forms.Button btEntrar;
    }
}

