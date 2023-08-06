namespace Atividades1AVA.Formularios
{
    partial class exercicio2
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
            this.btLimpar2 = new System.Windows.Forms.Button();
            this.btConverter2 = new System.Windows.Forms.Button();
            this.txtHectares2 = new System.Windows.Forms.TextBox();
            this.txtAlqueirePaulista2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar2
            // 
            this.btLimpar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar2.Location = new System.Drawing.Point(406, 187);
            this.btLimpar2.Name = "btLimpar2";
            this.btLimpar2.Size = new System.Drawing.Size(139, 35);
            this.btLimpar2.TabIndex = 45;
            this.btLimpar2.Text = "Limpar";
            this.btLimpar2.UseVisualStyleBackColor = true;
            this.btLimpar2.Click += new System.EventHandler(this.btLimpar2_Click);
            // 
            // btConverter2
            // 
            this.btConverter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConverter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter2.Location = new System.Drawing.Point(261, 187);
            this.btConverter2.Name = "btConverter2";
            this.btConverter2.Size = new System.Drawing.Size(139, 35);
            this.btConverter2.TabIndex = 44;
            this.btConverter2.Text = "Converter";
            this.btConverter2.UseVisualStyleBackColor = true;
            this.btConverter2.Click += new System.EventHandler(this.btConverter2_Click);
            // 
            // txtHectares2
            // 
            this.txtHectares2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHectares2.Location = new System.Drawing.Point(406, 155);
            this.txtHectares2.Name = "txtHectares2";
            this.txtHectares2.ReadOnly = true;
            this.txtHectares2.Size = new System.Drawing.Size(54, 26);
            this.txtHectares2.TabIndex = 43;
            // 
            // txtAlqueirePaulista2
            // 
            this.txtAlqueirePaulista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlqueirePaulista2.Location = new System.Drawing.Point(346, 155);
            this.txtAlqueirePaulista2.Name = "txtAlqueirePaulista2";
            this.txtAlqueirePaulista2.Size = new System.Drawing.Size(54, 26);
            this.txtAlqueirePaulista2.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = ":Hectares";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Alqueire Paulista:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 118);
            this.label2.TabIndex = 39;
            this.label2.Text = "Converter Alqueire Paulista em Hectares";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar2);
            this.Controls.Add(this.btConverter2);
            this.Controls.Add(this.txtHectares2);
            this.Controls.Add(this.txtAlqueirePaulista2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "exercicio2";
            this.Text = "excercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar2;
        private System.Windows.Forms.Button btConverter2;
        private System.Windows.Forms.TextBox txtHectares2;
        private System.Windows.Forms.TextBox txtAlqueirePaulista2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}