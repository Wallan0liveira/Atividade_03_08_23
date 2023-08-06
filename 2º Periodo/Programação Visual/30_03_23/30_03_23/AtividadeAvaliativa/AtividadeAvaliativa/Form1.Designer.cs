namespace AtividadeAvaliativa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btExercicio1 = new Button();
            btExercicio2 = new Button();
            btExercicio3 = new Button();
            SuspendLayout();
            // 
            // btExercicio1
            // 
            btExercicio1.BackColor = SystemColors.MenuHighlight;
            btExercicio1.ForeColor = SystemColors.ButtonHighlight;
            btExercicio1.Location = new Point(53, 25);
            btExercicio1.Name = "btExercicio1";
            btExercicio1.Size = new Size(187, 60);
            btExercicio1.TabIndex = 0;
            btExercicio1.Text = "Simular média";
            btExercicio1.UseVisualStyleBackColor = false;
            btExercicio1.Click += btExercicio1_Click;
            // 
            // btExercicio2
            // 
            btExercicio2.BackColor = SystemColors.MenuHighlight;
            btExercicio2.ForeColor = SystemColors.ButtonHighlight;
            btExercicio2.Location = new Point(53, 105);
            btExercicio2.Name = "btExercicio2";
            btExercicio2.Size = new Size(187, 60);
            btExercicio2.TabIndex = 1;
            btExercicio2.Text = "Nota mínima para ser aprovado no Exame";
            btExercicio2.UseVisualStyleBackColor = false;
            btExercicio2.Click += btExercicio2_Click;
            // 
            // btExercicio3
            // 
            btExercicio3.BackColor = SystemColors.MenuHighlight;
            btExercicio3.ForeColor = SystemColors.ButtonHighlight;
            btExercicio3.Location = new Point(53, 185);
            btExercicio3.Name = "btExercicio3";
            btExercicio3.Size = new Size(187, 60);
            btExercicio3.TabIndex = 2;
            btExercicio3.Text = "Verificar a média final após a nota do Exame Final";
            btExercicio3.UseVisualStyleBackColor = false;
            btExercicio3.Click += btExercicio3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 287);
            Controls.Add(btExercicio3);
            Controls.Add(btExercicio2);
            Controls.Add(btExercicio1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btExercicio1;
        private Button btExercicio2;
        private Button btExercicio3;
    }
}