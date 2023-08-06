namespace Atividades1AVA.Formularios
{
    partial class exercicio4
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
            this.btLimpar4 = new System.Windows.Forms.Button();
            this.btConverter4 = new System.Windows.Forms.Button();
            this.txtMetros4 = new System.Windows.Forms.TextBox();
            this.txtQuilometros4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar4
            // 
            this.btLimpar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar4.Location = new System.Drawing.Point(409, 181);
            this.btLimpar4.Name = "btLimpar4";
            this.btLimpar4.Size = new System.Drawing.Size(139, 35);
            this.btLimpar4.TabIndex = 47;
            this.btLimpar4.Text = "Limpar";
            this.btLimpar4.UseVisualStyleBackColor = true;
            this.btLimpar4.Click += new System.EventHandler(this.btLimpar4_Click);
            // 
            // btConverter4
            // 
            this.btConverter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConverter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverter4.Location = new System.Drawing.Point(264, 181);
            this.btConverter4.Name = "btConverter4";
            this.btConverter4.Size = new System.Drawing.Size(139, 35);
            this.btConverter4.TabIndex = 46;
            this.btConverter4.Text = "Converter";
            this.btConverter4.UseVisualStyleBackColor = true;
            this.btConverter4.Click += new System.EventHandler(this.btConverter4_Click);
            // 
            // txtMetros4
            // 
            this.txtMetros4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetros4.Location = new System.Drawing.Point(409, 149);
            this.txtMetros4.Name = "txtMetros4";
            this.txtMetros4.ReadOnly = true;
            this.txtMetros4.Size = new System.Drawing.Size(54, 26);
            this.txtMetros4.TabIndex = 45;
            // 
            // txtQuilometros4
            // 
            this.txtQuilometros4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuilometros4.Location = new System.Drawing.Point(349, 149);
            this.txtQuilometros4.Name = "txtQuilometros4";
            this.txtQuilometros4.Size = new System.Drawing.Size(54, 26);
            this.txtQuilometros4.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(469, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = ":Metros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(233, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Quilometros:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 129);
            this.label4.TabIndex = 41;
            this.label4.Text = "Converter quilômetros em metros";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar4);
            this.Controls.Add(this.btConverter4);
            this.Controls.Add(this.txtMetros4);
            this.Controls.Add(this.txtQuilometros4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Name = "exercicio4";
            this.Text = "exercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar4;
        private System.Windows.Forms.Button btConverter4;
        private System.Windows.Forms.TextBox txtMetros4;
        private System.Windows.Forms.TextBox txtQuilometros4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
    }
}