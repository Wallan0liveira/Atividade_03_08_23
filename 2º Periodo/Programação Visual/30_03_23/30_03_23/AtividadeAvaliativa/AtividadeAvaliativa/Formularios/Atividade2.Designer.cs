namespace AtividadeAvaliativa.Formularios
{
    partial class Atividade2
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
            txtMeidaFinal = new TextBox();
            lbResposta = new Label();
            btCalcular = new Button();
            btNovo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(401, 30);
            label1.TabIndex = 0;
            label1.Text = "Simulador para saber qual a nota mínima para aprovação no exame final";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 1;
            label2.Text = "Informe a Média Final:";
            // 
            // txtMeidaFinal
            // 
            txtMeidaFinal.Location = new Point(12, 73);
            txtMeidaFinal.Name = "txtMeidaFinal";
            txtMeidaFinal.Size = new Size(125, 23);
            txtMeidaFinal.TabIndex = 2;
            // 
            // lbResposta
            // 
            lbResposta.BorderStyle = BorderStyle.FixedSingle;
            lbResposta.Location = new Point(12, 110);
            lbResposta.Name = "lbResposta";
            lbResposta.Size = new Size(401, 43);
            lbResposta.TabIndex = 4;
            lbResposta.Text = "Média Final ";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(212, 172);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(131, 40);
            btCalcular.TabIndex = 5;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(75, 172);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(131, 40);
            btNovo.TabIndex = 6;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // Atividade2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 233);
            Controls.Add(btNovo);
            Controls.Add(btCalcular);
            Controls.Add(lbResposta);
            Controls.Add(txtMeidaFinal);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Atividade2";
            Text = "Atividade2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMeidaFinal;
        private Label lbResposta;
        private Button btCalcular;
        private Button btNovo;
    }
}