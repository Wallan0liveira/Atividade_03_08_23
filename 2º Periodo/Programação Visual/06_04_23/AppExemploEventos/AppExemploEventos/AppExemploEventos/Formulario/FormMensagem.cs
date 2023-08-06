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
    public partial class FormMensagem : Form
    {
        public FormMensagem()
        {
            InitializeComponent();
        }

        private void btAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa","Título da caixa",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btResposta_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string pergunta = "Palmeiras não tem muindial?";
            string titulo = "Título";
            string resposta;
            resp = MessageBox.Show(pergunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                resposta = "Sim, Palmeiras tem mundial";
                MessageBox.Show(resposta, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                resposta = "Não, Palmeiras não tem mundial";
                MessageBox.Show(resposta, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
