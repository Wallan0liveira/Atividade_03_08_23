namespace AtividadeAvaliativa.Formularios
{
    partial class Atividade3
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
            txtMediaFianal = new TextBox();
            txtMediaExame = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbResposta = new Label();
            btCalcular = new Button();
            button1 = new Button();
            label4 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 26);
            label1.TabIndex = 0;
            label1.Text = "FORM para verificar se o aluno foi aprovado no exame final";
            // 
            // txtMediaFianal
            // 
            txtMediaFianal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMediaFianal.Location = new Point(12, 165);
            txtMediaFianal.Name = "txtMediaFianal";
            txtMediaFianal.Size = new Size(150, 29);
            txtMediaFianal.TabIndex = 1;
            // 
            // txtMediaExame
            // 
            txtMediaExame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMediaExame.Location = new Point(12, 248);
            txtMediaExame.Name = "txtMediaExame";
            txtMediaExame.Size = new Size(150, 29);
            txtMediaExame.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 3;
            label2.Text = "Informe a média final:";
            // 
            // label3
            // 
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 4;
            label3.Text = "Informe a nota do exame:";
            // 
            // lbResposta
            // 
            lbResposta.BorderStyle = BorderStyle.FixedSingle;
            lbResposta.Location = new Point(12, 306);
            lbResposta.Name = "lbResposta";
            lbResposta.Size = new Size(477, 64);
            lbResposta.TabIndex = 5;
            lbResposta.Text = "Resposta";
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCalcular.Location = new Point(248, 391);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(109, 43);
            btCalcular.TabIndex = 6;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(133, 391);
            button1.Name = "button1";
            button1.Size = new Size(109, 43);
            button1.TabIndex = 7;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Location = new Point(12, 56);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 9;
            label4.Text = "Informe seu nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 29);
            txtNome.TabIndex = 8;
            // 
            // Atividade3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 456);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(button1);
            Controls.Add(btCalcular);
            Controls.Add(lbResposta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMediaExame);
            Controls.Add(txtMediaFianal);
            Controls.Add(label1);
            Name = "Atividade3";
            Text = "Atividade3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMediaFianal;
        private TextBox txtMediaExame;
        private Label label2;
        private Label label3;
        private Label lbResposta;
        private Button btCalcular;
        private Button button1;
        private Label label4;
        private TextBox txtNome;
    }
}