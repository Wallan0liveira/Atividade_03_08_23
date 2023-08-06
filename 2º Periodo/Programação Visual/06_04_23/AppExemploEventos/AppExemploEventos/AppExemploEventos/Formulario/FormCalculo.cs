using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploEventos.Formulario
{
    public partial class FormCalculo : Form
    {
        public FormCalculo()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = 0;
            double valor2 = 0;
            double total = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            if (valor1 == 0 || valor2 == 0)
            {
                MessageBox.Show("Não existe número dividido por zero!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information); ;

            }
            else
            {
                total = valor1 / valor2;
                txtResultado.Text = total.ToString();
            }
        }
    }
}
