namespace AppCalculadoraDiversa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCalculadoraFinanceira = new System.Windows.Forms.Button();
            this.btCalcularDesconto = new System.Windows.Forms.Button();
            this.btCalcularRaizes = new System.Windows.Forms.Button();
            this.btSimularSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Pincipal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalculadoraFinanceira
            // 
            this.btCalculadoraFinanceira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculadoraFinanceira.Location = new System.Drawing.Point(12, 67);
            this.btCalculadoraFinanceira.Name = "btCalculadoraFinanceira";
            this.btCalculadoraFinanceira.Size = new System.Drawing.Size(214, 42);
            this.btCalculadoraFinanceira.TabIndex = 1;
            this.btCalculadoraFinanceira.Text = "Calculadora Financeira";
            this.btCalculadoraFinanceira.UseVisualStyleBackColor = true;
            this.btCalculadoraFinanceira.Click += new System.EventHandler(this.btCalculadoraFinanceira_Click);
            // 
            // btCalcularDesconto
            // 
            this.btCalcularDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularDesconto.Location = new System.Drawing.Point(12, 127);
            this.btCalcularDesconto.Name = "btCalcularDesconto";
            this.btCalcularDesconto.Size = new System.Drawing.Size(214, 42);
            this.btCalcularDesconto.TabIndex = 2;
            this.btCalcularDesconto.Text = "Calcular Desconto";
            this.btCalcularDesconto.UseVisualStyleBackColor = true;
            this.btCalcularDesconto.Click += new System.EventHandler(this.btCalcularDesconto_Click);
            // 
            // btCalcularRaizes
            // 
            this.btCalcularRaizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularRaizes.Location = new System.Drawing.Point(253, 67);
            this.btCalcularRaizes.Name = "btCalcularRaizes";
            this.btCalcularRaizes.Size = new System.Drawing.Size(214, 42);
            this.btCalcularRaizes.TabIndex = 3;
            this.btCalcularRaizes.Text = "Calcular Raizes";
            this.btCalcularRaizes.UseVisualStyleBackColor = true;
            this.btCalcularRaizes.Click += new System.EventHandler(this.btCalcularRaizes_Click);
            // 
            // btSimularSalario
            // 
            this.btSimularSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularSalario.Location = new System.Drawing.Point(253, 127);
            this.btSimularSalario.Name = "btSimularSalario";
            this.btSimularSalario.Size = new System.Drawing.Size(214, 42);
            this.btSimularSalario.TabIndex = 4;
            this.btSimularSalario.Text = "Simular Salario";
            this.btSimularSalario.UseVisualStyleBackColor = true;
            this.btSimularSalario.Click += new System.EventHandler(this.btSimularSalario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 185);
            this.Controls.Add(this.btSimularSalario);
            this.Controls.Add(this.btCalcularRaizes);
            this.Controls.Add(this.btCalcularDesconto);
            this.Controls.Add(this.btCalculadoraFinanceira);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalculadoraFinanceira;
        private System.Windows.Forms.Button btCalcularDesconto;
        private System.Windows.Forms.Button btCalcularRaizes;
        private System.Windows.Forms.Button btSimularSalario;
    }
}

