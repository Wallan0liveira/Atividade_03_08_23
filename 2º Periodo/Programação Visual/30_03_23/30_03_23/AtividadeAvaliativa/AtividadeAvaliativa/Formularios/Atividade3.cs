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
    public partial class Atividade3 : Form
    {
        public Atividade3()
        {
            InitializeComponent();
            lbResposta.Text = "";
            txtNome.Select();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double resposta = 0.00, mediaFinal = 0.00, notaExame = 0.00;
            string nome;

            mediaFinal = Convert.ToDouble(txtMediaFianal.Text);
            notaExame = Convert.ToDouble(txtMediaExame.Text);
            nome = txtNome.Text;

            resposta = ((6 * mediaFinal) + (4 * notaExame)) / 10;

            if (resposta <= 50)
            {
                lbResposta.Text = nome + ", você não foi aprovado(a).";
            }
            if (resposta >= 50)
            {
                lbResposta.Text = nome + ", você foi aprovado(a).";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMediaFianal.Clear();
            txtMediaExame.Clear();
            txtNome.Select();
        }
    }
}
