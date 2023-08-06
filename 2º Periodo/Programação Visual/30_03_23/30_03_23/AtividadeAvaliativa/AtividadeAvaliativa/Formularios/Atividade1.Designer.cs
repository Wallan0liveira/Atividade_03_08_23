namespace AtividadeAvaliativa.Formularios
{
    partial class Atividade1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPrimeiraNota = new TextBox();
            txtSegundaNota = new TextBox();
            txtMedia = new TextBox();
            label4 = new Label();
            lbResposta = new Label();
            btNovo = new Button();
            btCalcular = new Button();
            txtNome = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 137);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Informa a nota da 1º etapa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 196);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Informa a nota da 2º etapa:";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 9);
            label3.Name = "label3";
            label3.Size = new Size(249, 29);
            label3.TabIndex = 2;
            label3.Text = "Simulador de Notas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrimeiraNota
            // 
            txtPrimeiraNota.Location = new Point(25, 155);
            txtPrimeiraNota.Name = "txtPrimeiraNota";
            txtPrimeiraNota.Size = new Size(100, 23);
            txtPrimeiraNota.TabIndex = 3;
            // 
            // txtSegundaNota
            // 
            txtSegundaNota.Location = new Point(25, 214);
            txtSegundaNota.Name = "txtSegundaNota";
            txtSegundaNota.Size = new Size(100, 23);
            txtSegundaNota.TabIndex = 4;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(25, 275);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 257);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Média:";
            // 
            // lbResposta
            // 
            lbResposta.AutoSize = true;
            lbResposta.Location = new Point(25, 321);
            lbResposta.Name = "lbResposta";
            lbResposta.Size = new Size(136, 15);
            lbResposta.TabIndex = 7;
            lbResposta.Text = "Aprovado ou Reprovado";
            lbResposta.Click += lbResposta_Click;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(25, 363);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(128, 23);
            btNovo.TabIndex = 8;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(159, 363);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(128, 23);
            btCalcular.TabIndex = 9;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(249, 23);
            txtNome.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 71);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 11;
            label5.Text = "Infirme seu nome:";
            // 
            // Atividade1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 404);
            Controls.Add(label5);
            Controls.Add(txtNome);
            Controls.Add(btCalcular);
            Controls.Add(btNovo);
            Controls.Add(lbResposta);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(txtSegundaNota);
            Controls.Add(txtPrimeiraNota);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Atividade1";
            Text = "Atividade1";
            Load += Atividade1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPrimeiraNota;
        private TextBox txtSegundaNota;
        private TextBox txtMedia;
        private Label label4;
        private Label lbResposta;
        private Button btNovo;
        private Button btCalcular;
        private TextBox txtNome;
        private Label label5;
    }
}