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
    public partial class FormRegistroDeNotas : Form
    {
        public FormRegistroDeNotas()
        {
            InitializeComponent();
            txtMedia.Enabled = false;
            txtMediaGeral.Enabled = false;
            txtNome.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;

            btDeletar.Enabled = false;
            btFinalizarRegistro.Enabled = false;
            btSalvar.Enabled = false;

            dgvTabela.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtMedia.Enabled = true;
            txtMediaGeral.Enabled = true;
            txtNome.Enabled = true;
            txtNota1.Enabled = true;
            txtNota2.Enabled = true;

            btFinalizarRegistro.Enabled = true;
            btSalvar.Enabled = true;

            dgvTabela.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            btDeletar.Enabled = true;
        }
    }
}
