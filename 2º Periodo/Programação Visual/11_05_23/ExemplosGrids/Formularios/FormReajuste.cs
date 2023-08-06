using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosGrids.Formularios
{
    public partial class FormReajuste : Form
    {
        public FormReajuste()
        {
            InitializeComponent();
            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalario.Enabled = false;
            txtSalarioAtual.Enabled = false;

            btDeletar.Enabled = false;
            btSalvar.Enabled = false;

            dgvTabela.Enabled = false;
            
        }

        private void FormReajuste_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtCpf.Enabled=true;
            txtNome.Enabled=true;
            txtReajuste.Enabled=true;
            txtSalario.Enabled=true;
            txtSalarioAtual.Enabled=true;

            btSalvar.Enabled=true;

            dgvTabela.Enabled=true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalario.Enabled = false;
            txtSalarioAtual.Enabled = false;

            btDeletar.Enabled = true;
            btSalvar.Enabled = false;

            dgvTabela.Enabled = false;
        }
    }
}
