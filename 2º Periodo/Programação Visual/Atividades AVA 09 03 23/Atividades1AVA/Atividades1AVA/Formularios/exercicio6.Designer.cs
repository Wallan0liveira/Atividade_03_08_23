namespace Atividades1AVA.Formularios
{
    partial class exercicio6
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
            this.btLimpar6 = new System.Windows.Forms.Button();
            this.btConverter6 = new System.Windows.Forms.Button();
            this.txtHoras6 = new System.Windows.Forms.TextBox();
            this.txtMinutos6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar6
            // 
            this.btLimpar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar6.Location = new System.Drawing.Point(403, 191);
            this.btLimpar6.Name = "btLimpar6";
            this.btLimpar6.Size = new System.Drawing.Size(139, 35);
            this.btLimpar6.TabIndex = 49;
            this.btLimpar6.Text = "Limpar";
            this.btLimpar6.UseVisualStyleBackColor = true;
            this.btLimpar6.Click += new System.EventHandler(this.btLimpar6_Click);
            // 
            // btConverter6
            // 
            this.btConverter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConverter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter6.Location = new System.Drawing.Point(258, 191);
            this.btConverter6.Name = "btConverter6";
            this.btConverter6.Size = new System.Drawing.Size(139, 35);
            this.btConverter6.TabIndex = 48;
            this.btConverter6.Text = "Converter";
            this.btConverter6.UseVisualStyleBackColor = true;
            this.btConverter6.Click += new System.EventHandler(this.btConverter6_Click);
            // 
            // txtHoras6
            // 
            this.txtHoras6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras6.Location = new System.Drawing.Point(403, 156);
            this.txtHoras6.Name = "txtHoras6";
            this.txtHoras6.ReadOnly = true;
            this.txtHoras6.Size = new System.Drawing.Size(54, 26);
            this.txtHoras6.TabIndex = 47;
            // 
            // txtMinutos6
            // 
            this.txtMinutos6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos6.Location = new System.Drawing.Point(343, 156);
            this.txtMinutos6.Name = "txtMinutos6";
            this.txtMinutos6.Size = new System.Drawing.Size(54, 26);
            this.txtMinutos6.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(463, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 45;
            this.label18.Text = ":Horas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(260, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Minutos:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 137);
            this.label6.TabIndex = 43;
            this.label6.Text = "Converter Minutos em Horas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar6);
            this.Controls.Add(this.btConverter6);
            this.Controls.Add(this.txtHoras6);
            this.Controls.Add(this.txtMinutos6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Name = "exercicio6";
            this.Text = "exercicio6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar6;
        private System.Windows.Forms.Button btConverter6;
        private System.Windows.Forms.TextBox txtHoras6;
        private System.Windows.Forms.TextBox txtMinutos6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
    }
}