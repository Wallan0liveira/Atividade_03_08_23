using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa.Formularios
{
    public partial class Atividade1 : Form
    {
        public Atividade1()
        {
            InitializeComponent();
            txtMedia.ReadOnly = true;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double media = 0.00;
            double nota1 = 0.00;
            double nota2 = 0.00;

            nota1 = Convert.ToDouble(txtPrimeiraNota.Text);
            nota2 = Convert.ToDouble(txtSegundaNota.Text);

            media = (nota1 + nota2) / 2;

            txtMedia.Text = media.ToString();
            if (media >= 60)
            {
                string nome = txtNome.Text;
                lbResposta.Text = nome + " você foi aprovado(a)!";
            }
            if (media < 60)
            {
                string nome = txtNome.Text;
                lbResposta.Text = nome + " você foi reprovado(a)!";
            }
        }

        private void Atividade1_Load(object sender, EventArgs e)
        {

        }

        private void lbResposta_Click(object sender, EventArgs e)
        {
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtMedia.Clear();
            txtNome.Clear();
            txtPrimeiraNota.Clear();
            txtSegundaNota.Clear();
            txtNome.Select();
        }
    }
}
