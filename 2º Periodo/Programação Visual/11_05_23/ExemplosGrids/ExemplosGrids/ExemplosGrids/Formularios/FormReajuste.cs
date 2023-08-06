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
            btCancelar.Enabled = false;

            dgvTabela.Enabled = false;

            txtNome.TabIndex = 0;
            txtCpf.TabIndex = 1;
            txtSalario.TabIndex = 2;
            txtReajuste.TabIndex = 3;
            btSalvar.TabIndex = 4;

        }

        private void FormReajuste_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtCpf.Enabled = true;
            txtNome.Enabled = true;
            txtReajuste.Enabled = true;
            txtSalario.Enabled = true;
            txtSalarioAtual.Enabled = true;

            btSalvar.Enabled = true;
            btCancelar.Enabled = true;

            dgvTabela.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtNome.Text, txtCpf.Text, Convert.ToDouble(txtSalario.Text), Convert.ToDouble(txtReajuste.Text),Convert.ToDouble(txtSalarioAtual.Text));

            Totalizador();

            txtCpf.Clear();
            txtNome.Clear();
            txtReajuste.Clear();
            txtSalario.Clear();
            txtSalarioAtual.Clear();

            btDeletar.Enabled = true;
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalario.Enabled = false;
            txtSalarioAtual.Enabled = false;


            dgvTabela.Enabled = true;


        }

        public void Totalizador()
        {
            double total = 0.0;
            for (int i = 0; i < dgvTabela.RowCount; i++)
            {
                total = Convert.ToDouble(dgvTabela[4,i].Value)+total;
            }
            txtMediaSalarial.Text = total.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            txtCpf.Clear();
            txtNome.Clear();
            txtReajuste.Clear();
            txtSalario.Clear();
            txtSalarioAtual.Clear();

            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalario.Enabled = false;
            txtSalarioAtual.Enabled = false;

            btDeletar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
            btCancelar.Enabled = false;

            dgvTabela.Enabled = false;


        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index; // Pega a linha selecionada
            int qtdLinha = dgvTabela.RowCount;// Pega a quantidade de linhas existente na tabela

            DialogResult resp = MessageBox.Show("Deseja mesmo Deletar?",// Mensagem pergunta?
                "ADS", //titulo
                MessageBoxButtons.YesNo,// botão sim ou não
                MessageBoxIcon.Question);// icone


            if (resp == DialogResult.Yes)
            {
                dgvTabela.Rows.RemoveAt(linha);

            }
            Totalizador();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtReajuste_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double resultado = 0.0;
                double salario = Convert.ToDouble(txtSalario.Text);
                double ajuste = Convert.ToDouble(txtReajuste.Text);

                resultado = salario + (salario * (ajuste / 100));

                txtSalarioAtual.Text = resultado.ToString();
            }
        }
    }
}
