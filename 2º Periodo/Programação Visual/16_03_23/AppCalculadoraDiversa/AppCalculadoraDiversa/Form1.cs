using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCalculadoraDiversa.Formularios; // para ter acesso aos formularios criados dentro da pasta "Formularios"

namespace AppCalculadoraDiversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculadoraFinanceira_Click(object sender, EventArgs e)
        {
            FormCalculadoraFinanceira form = new FormCalculadoraFinanceira();
            form.ShowDialog();
        }

        private void btCalcularDesconto_Click(object sender, EventArgs e)
        {
            FormCalcularDesconto form = new FormCalcularDesconto();
            form.ShowDialog();
        }

        private void btCalcularRaizes_Click(object sender, EventArgs e)
        {
            FormCalcularRaizes form = new FormCalcularRaizes();
            form.ShowDialog();
        }

        private void btSimularSalario_Click(object sender, EventArgs e)
        {
            FormSimularSalario form = new FormSimularSalario();
            form.ShowDialog();
        }
    }
}
