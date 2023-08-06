namespace AppFormTemp
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
            this.components = new System.ComponentModel.Container();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btPare = new System.Windows.Forms.Button();
            this.timerPrimeiroTeste = new System.Windows.Forms.Timer(this.components);
            this.btVerde = new System.Windows.Forms.Button();
            this.btAmarelo = new System.Windows.Forms.Button();
            this.btVermelho = new System.Windows.Forms.Button();
            this.timerVerde = new System.Windows.Forms.Timer(this.components);
            this.timerAmarelo = new System.Windows.Forms.Timer(this.components);
            this.timerVermelho = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(30, 69);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(250, 45);
            this.btIniciar.TabIndex = 0;
            this.btIniciar.Text = "COMEÇAR";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btPare
            // 
            this.btPare.Location = new System.Drawing.Point(286, 69);
            this.btPare.Name = "btPare";
            this.btPare.Size = new System.Drawing.Size(250, 45);
            this.btPare.TabIndex = 1;
            this.btPare.Text = "PARE";
            this.btPare.UseVisualStyleBackColor = true;
            this.btPare.Click += new System.EventHandler(this.btPare_Click);
            // 
            // timerPrimeiroTeste
            // 
            this.timerPrimeiroTeste.Interval = 1000;
            this.timerPrimeiroTeste.Tick += new System.EventHandler(this.timerPrimeiroTeste_Tick);
            // 
            // btVerde
            // 
            this.btVerde.Location = new System.Drawing.Point(30, 164);
            this.btVerde.Name = "btVerde";
            this.btVerde.Size = new System.Drawing.Size(114, 152);
            this.btVerde.TabIndex = 2;
            this.btVerde.UseVisualStyleBackColor = true;
            this.btVerde.Click += new System.EventHandler(this.btVerde_Click);
            // 
            // btAmarelo
            // 
            this.btAmarelo.Location = new System.Drawing.Point(224, 164);
            this.btAmarelo.Name = "btAmarelo";
            this.btAmarelo.Size = new System.Drawing.Size(114, 152);
            this.btAmarelo.TabIndex = 3;
            this.btAmarelo.UseVisualStyleBackColor = true;
            // 
            // btVermelho
            // 
            this.btVermelho.Location = new System.Drawing.Point(422, 164);
            this.btVermelho.Name = "btVermelho";
            this.btVermelho.Size = new System.Drawing.Size(114, 152);
            this.btVermelho.TabIndex = 4;
            this.btVermelho.UseVisualStyleBackColor = true;
            // 
            // timerVerde
            // 
            this.timerVerde.Interval = 1000;
            this.timerVerde.Tick += new System.EventHandler(this.timerVerde_Tick);
            // 
            // timerAmarelo
            // 
            this.timerAmarelo.Interval = 1000;
            this.timerAmarelo.Tick += new System.EventHandler(this.timerAmarelo_Tick);
            // 
            // timerVermelho
            // 
            this.timerVermelho.Interval = 1000;
            this.timerVermelho.Tick += new System.EventHandler(this.timerVermelho_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 377);
            this.Controls.Add(this.btVermelho);
            this.Controls.Add(this.btAmarelo);
            this.Controls.Add(this.btVerde);
            this.Controls.Add(this.btPare);
            this.Controls.Add(this.btIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btPare;
        private System.Windows.Forms.Timer timerPrimeiroTeste;
        private System.Windows.Forms.Button btVerde;
        private System.Windows.Forms.Button btAmarelo;
        private System.Windows.Forms.Button btVermelho;
        private System.Windows.Forms.Timer timerVerde;
        private System.Windows.Forms.Timer timerAmarelo;
        private System.Windows.Forms.Timer timerVermelho;
    }
}

