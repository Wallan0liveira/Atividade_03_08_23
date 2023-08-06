namespace Atividades1AVA.Formularios
{
    partial class exercicio3
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
            this.btLimpar3 = new System.Windows.Forms.Button();
            this.btConverter3 = new System.Windows.Forms.Button();
            this.txtQuilometros3 = new System.Windows.Forms.TextBox();
            this.txtMetros3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar3
            // 
            this.btLimpar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar3.Location = new System.Drawing.Point(407, 192);
            this.btLimpar3.Name = "btLimpar3";
            this.btLimpar3.Size = new System.Drawing.Size(139, 35);
            this.btLimpar3.TabIndex = 46;
            this.btLimpar3.Text = "Limpar";
            this.btLimpar3.UseVisualStyleBackColor = true;
            this.btLimpar3.Click += new System.EventHandler(this.btLimpar3_Click);
            // 
            // btConverter3
            // 
            this.btConverter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConverter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter3.Location = new System.Drawing.Point(262, 192);
            this.btConverter3.Name = "btConverter3";
            this.btConverter3.Size = new System.Drawing.Size(139, 35);
            this.btConverter3.TabIndex = 45;
            this.btConverter3.Text = "Converter";
            this.btConverter3.UseVisualStyleBackColor = true;
            this.btConverter3.Click += new System.EventHandler(this.btConverter3_Click);
            // 
            // txtQuilometros3
            // 
            this.txtQuilometros3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuilometros3.Location = new System.Drawing.Point(407, 160);
            this.txtQuilometros3.Name = "txtQuilometros3";
            this.txtQuilometros3.ReadOnly = true;
            this.txtQuilometros3.Size = new System.Drawing.Size(54, 26);
            this.txtQuilometros3.TabIndex = 44;
            // 
            // txtMetros3
            // 
            this.txtMetros3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetros3.Location = new System.Drawing.Point(347, 160);
            this.txtMetros3.Name = "txtMetros3";
            this.txtMetros3.Size = new System.Drawing.Size(54, 26);
            this.txtMetros3.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(467, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = ":Quilometros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Metros:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 137);
            this.label3.TabIndex = 40;
            this.label3.Text = " Converter metros em quilômetros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar3);
            this.Controls.Add(this.btConverter3);
            this.Controls.Add(this.txtQuilometros3);
            this.Controls.Add(this.txtMetros3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Name = "exercicio3";
            this.Text = "exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar3;
        private System.Windows.Forms.Button btConverter3;
        private System.Windows.Forms.TextBox txtQuilometros3;
        private System.Windows.Forms.TextBox txtMetros3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
    }
}