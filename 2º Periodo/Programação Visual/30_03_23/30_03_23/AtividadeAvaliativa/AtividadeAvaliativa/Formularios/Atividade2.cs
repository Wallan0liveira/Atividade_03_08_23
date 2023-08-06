using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa.Formularios
{
    public partial class Atividade2 : Form
    {
        public Atividade2()
        {
            InitializeComponent();
            lbResposta.Text = "";
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double media = 0.00;
            double resposta = 0.00;

            media = Convert.ToDouble(txtMeidaFinal.Text);

            resposta = (500 - 6 * media) / 4;

            lbResposta.Text = "O acadêmico precisa de " + resposta.ToString() + " pontos para aprovação";

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtMeidaFinal.Clear();
            txtMeidaFinal.Select();
            lbResposta.Text = "";
        }
    }
}
