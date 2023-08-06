namespace Atividades1AVA.Formularios
{
    partial class exercicio1
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
            this.btLimpar1 = new System.Windows.Forms.Button();
            this.btConverter1 = new System.Windows.Forms.Button();
            this.txtAlqueirePaulista1 = new System.Windows.Forms.TextBox();
            this.txtHectares1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar1
            // 
            this.btLimpar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar1.Location = new System.Drawing.Point(409, 175);
            this.btLimpar1.Name = "btLimpar1";
            this.btLimpar1.Size = new System.Drawing.Size(139, 35);
            this.btLimpar1.TabIndex = 44;
            this.btLimpar1.Text = "Limpar";
            this.btLimpar1.UseVisualStyleBackColor = true;
            this.btLimpar1.Click += new System.EventHandler(this.btLimpar1_Click);
            // 
            // btConverter1
            // 
            this.btConverter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConverter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter1.Location = new System.Drawing.Point(264, 175);
            this.btConverter1.Name = "btConverter1";
            this.btConverter1.Size = new System.Drawing.Size(139, 35);
            this.btConverter1.TabIndex = 43;
            this.btConverter1.Text = "Converter";
            this.btConverter1.UseVisualStyleBackColor = true;
            this.btConverter1.Click += new System.EventHandler(this.btConverter1_Click);
            // 
            // txtAlqueirePaulista1
            // 
            this.txtAlqueirePaulista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlqueirePaulista1.Location = new System.Drawing.Point(409, 143);
            this.txtAlqueirePaulista1.Name = "txtAlqueirePaulista1";
            this.txtAlqueirePaulista1.ReadOnly = true;
            this.txtAlqueirePaulista1.Size = new System.Drawing.Size(54, 26);
            this.txtAlqueirePaulista1.TabIndex = 42;
            this.txtAlqueirePaulista1.TextChanged += new System.EventHandler(this.txtAlqueirePaulista1_TextChanged);
            // 
            // txtHectares1
            // 
            this.txtHectares1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHectares1.Location = new System.Drawing.Point(349, 143);
            this.txtHectares1.Name = "txtHectares1";
            this.txtHectares1.Size = new System.Drawing.Size(54, 26);
            this.txtHectares1.TabIndex = 41;
            this.txtHectares1.TextChanged += new System.EventHandler(this.txtHectares1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = ":Alqueire Paulista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Hectares:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 129);
            this.label1.TabIndex = 38;
            this.label1.Text = "Converter Hectares em Alqueire Paulista";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar1);
            this.Controls.Add(this.btConverter1);
            this.Controls.Add(this.txtAlqueirePaulista1);
            this.Controls.Add(this.txtHectares1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "exercicio1";
            this.Text = "exercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar1;
        private System.Windows.Forms.Button btConverter1;
        private System.Windows.Forms.TextBox txtAlqueirePaulista1;
        private System.Windows.Forms.TextBox txtHectares1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}