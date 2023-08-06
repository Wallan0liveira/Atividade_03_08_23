namespace Atividades1AVA.Formularios
{
    partial class exercicio5
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
            this.btLimpar5 = new System.Windows.Forms.Button();
            this.btConverter5 = new System.Windows.Forms.Button();
            this.txtMinutos5 = new System.Windows.Forms.TextBox();
            this.txtHoras5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar5
            // 
            this.btLimpar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar5.Location = new System.Drawing.Point(406, 186);
            this.btLimpar5.Name = "btLimpar5";
            this.btLimpar5.Size = new System.Drawing.Size(139, 35);
            this.btLimpar5.TabIndex = 48;
            this.btLimpar5.Text = "Limpar";
            this.btLimpar5.UseVisualStyleBackColor = true;
            this.btLimpar5.Click += new System.EventHandler(this.btLimpar5_Click);
            // 
            // btConverter5
            // 
            this.btConverter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConverter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter5.Location = new System.Drawing.Point(261, 186);
            this.btConverter5.Name = "btConverter5";
            this.btConverter5.Size = new System.Drawing.Size(139, 35);
            this.btConverter5.TabIndex = 47;
            this.btConverter5.Text = "Converter";
            this.btConverter5.UseVisualStyleBackColor = true;
            this.btConverter5.Click += new System.EventHandler(this.btConverter5_Click);
            // 
            // txtMinutos5
            // 
            this.txtMinutos5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos5.Location = new System.Drawing.Point(406, 154);
            this.txtMinutos5.Name = "txtMinutos5";
            this.txtMinutos5.ReadOnly = true;
            this.txtMinutos5.Size = new System.Drawing.Size(54, 26);
            this.txtMinutos5.TabIndex = 46;
            // 
            // txtHoras5
            // 
            this.txtHoras5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras5.Location = new System.Drawing.Point(346, 154);
            this.txtHoras5.Name = "txtHoras5";
            this.txtHoras5.Size = new System.Drawing.Size(54, 26);
            this.txtHoras5.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(466, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 20);
            this.label16.TabIndex = 44;
            this.label16.Text = ":Minutos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(278, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "Horas:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 118);
            this.label5.TabIndex = 42;
            this.label5.Text = "Converter Horas em Minutos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar5);
            this.Controls.Add(this.btConverter5);
            this.Controls.Add(this.txtMinutos5);
            this.Controls.Add(this.txtHoras5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Name = "exercicio5";
            this.Text = "exercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar5;
        private System.Windows.Forms.Button btConverter5;
        private System.Windows.Forms.TextBox txtMinutos5;
        private System.Windows.Forms.TextBox txtHoras5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
    }
}