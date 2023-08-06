namespace AppExemploEventos.Formulario
{
    partial class FormMensagem
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
            this.btAlerta = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.btErro = new System.Windows.Forms.Button();
            this.btPergunta = new System.Windows.Forms.Button();
            this.btResposta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAlerta
            // 
            this.btAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlerta.Location = new System.Drawing.Point(197, 36);
            this.btAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAlerta.Name = "btAlerta";
            this.btAlerta.Size = new System.Drawing.Size(182, 45);
            this.btAlerta.TabIndex = 36;
            this.btAlerta.Text = "ALERTA";
            this.btAlerta.UseVisualStyleBackColor = true;
            this.btAlerta.Click += new System.EventHandler(this.btAlerta_Click);
            // 
            // btInfo
            // 
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.Location = new System.Drawing.Point(197, 115);
            this.btInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(182, 45);
            this.btInfo.TabIndex = 37;
            this.btInfo.Text = "INFORMAÇÃO";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // btErro
            // 
            this.btErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btErro.Location = new System.Drawing.Point(197, 197);
            this.btErro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btErro.Name = "btErro";
            this.btErro.Size = new System.Drawing.Size(182, 45);
            this.btErro.TabIndex = 38;
            this.btErro.Text = "ERRO";
            this.btErro.UseVisualStyleBackColor = true;
            this.btErro.Click += new System.EventHandler(this.btErro_Click);
            // 
            // btPergunta
            // 
            this.btPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPergunta.Location = new System.Drawing.Point(197, 284);
            this.btPergunta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPergunta.Name = "btPergunta";
            this.btPergunta.Size = new System.Drawing.Size(182, 45);
            this.btPergunta.TabIndex = 39;
            this.btPergunta.Text = "PERGUNTAS";
            this.btPergunta.UseVisualStyleBackColor = true;
            this.btPergunta.Click += new System.EventHandler(this.btPergunta_Click);
            // 
            // btResposta
            // 
            this.btResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResposta.Location = new System.Drawing.Point(159, 355);
            this.btResposta.Margin = new System.Windows.Forms.Padding(2);
            this.btResposta.Name = "btResposta";
            this.btResposta.Size = new System.Drawing.Size(268, 45);
            this.btResposta.TabIndex = 40;
            this.btResposta.Text = "RESPONDA A PERGUNTA";
            this.btResposta.UseVisualStyleBackColor = true;
            this.btResposta.Click += new System.EventHandler(this.btResposta_Click);
            // 
            // FormMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 425);
            this.Controls.Add(this.btResposta);
            this.Controls.Add(this.btPergunta);
            this.Controls.Add(this.btErro);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btAlerta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMensagem";
            this.Text = "FormMensagem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAlerta;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button btErro;
        private System.Windows.Forms.Button btPergunta;
        private System.Windows.Forms.Button btResposta;
    }
}