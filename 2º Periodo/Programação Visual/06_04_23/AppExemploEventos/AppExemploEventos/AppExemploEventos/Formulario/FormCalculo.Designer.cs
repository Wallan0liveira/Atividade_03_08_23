namespace AppExemploEventos.Formulario
{
    partial class FormCalculo
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
            this.lbLadoC = new System.Windows.Forms.Label();
            this.lbLadoB = new System.Windows.Forms.Label();
            this.lbLadoA = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLadoC
            // 
            this.lbLadoC.AutoSize = true;
            this.lbLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadoC.Location = new System.Drawing.Point(65, 308);
            this.lbLadoC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLadoC.Name = "lbLadoC";
            this.lbLadoC.Size = new System.Drawing.Size(117, 20);
            this.lbLadoC.TabIndex = 38;
            this.lbLadoC.Text = "RESULTADO";
            // 
            // lbLadoB
            // 
            this.lbLadoB.AutoSize = true;
            this.lbLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadoB.Location = new System.Drawing.Point(62, 137);
            this.lbLadoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLadoB.Name = "lbLadoB";
            this.lbLadoB.Size = new System.Drawing.Size(89, 20);
            this.lbLadoB.TabIndex = 37;
            this.lbLadoB.Text = "VALOR 2:";
            // 
            // lbLadoA
            // 
            this.lbLadoA.AutoSize = true;
            this.lbLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadoA.Location = new System.Drawing.Point(62, 67);
            this.lbLadoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLadoA.Name = "lbLadoA";
            this.lbLadoA.Size = new System.Drawing.Size(89, 20);
            this.lbLadoA.TabIndex = 36;
            this.lbLadoA.Text = "VALOR 1:";
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(297, 233);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(182, 45);
            this.btNovo.TabIndex = 35;
            this.btNovo.Text = "NOVO CÁLCULO";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(65, 233);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(182, 45);
            this.btCalcular.TabIndex = 34;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(65, 331);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(134, 28);
            this.txtResultado.TabIndex = 33;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(65, 160);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(134, 28);
            this.txtValor2.TabIndex = 32;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(65, 90);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(134, 28);
            this.txtValor1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "DIVISÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLadoC);
            this.Controls.Add(this.lbLadoB);
            this.Controls.Add(this.lbLadoA);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCalculo";
            this.Text = "FormCalculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLadoC;
        private System.Windows.Forms.Label lbLadoB;
        private System.Windows.Forms.Label lbLadoA;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label1;
    }
}