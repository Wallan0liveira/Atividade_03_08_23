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
    public partial class FormPerdido : Form
    {
        public FormPerdido()
        {
            InitializeComponent();
            //bloquear  campos de edição
            txtDescricao.Enabled = false;
            txtQuant.Enabled = false;
            txtTotal.Enabled = false;
            txtTotalGeral.Enabled = false;
            txtValorUnit.Enabled = false;

            // bloquear botoes
            btCancelar.Enabled = false;
            btDeletar.Enabled = false;
            btSalvar.Enabled = false;

            // bloquear a tabela
            dgvTabela.Enabled = false;

            txtDescricao.TabIndex = 0;
            txtValorUnit.TabIndex = 1;
            txtQuant.TabIndex = 2;
            btSalvar.TabIndex = 3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtDescricao.Text,
                Convert.ToDouble(txtValorUnit.Text),
                Convert.ToDouble(txtQuant.Text),
                Convert.ToDouble(txtTotal.Text));
            Totalizar();
            // bloquea botoes
            btCancelar.Enabled=false;
            btSalvar.Enabled=false;

            //limpar os campos
            txtTotal.Clear();
            txtValorUnit.Clear();
            txtQuant.Clear();
            txtDescricao.Clear();
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
                Totalizar();
            }
            
        }

        private void Totalizar()
        {
            double total = 0.00;

            for (int i = 0; i < dgvTabela.RowCount; i++)
            {
                total = Convert.ToDouble(dgvTabela[3, i].Value) + total;
            }

            txtTotalGeral.Text = total.ToString("C2"); // "C2" => R$ 0,00
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotal_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtValorUnit.Select();
            }
        }

        private void txtValorUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuant.Select();
            }
        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double quant = Convert.ToDouble(txtQuant.Text);
                double valorUnit = Convert.ToDouble(txtValorUnit.Text);
                double total = quant * valorUnit;

                txtTotal.Text = total.ToString();
                txtTotal.Select();
                txtTotal.ReadOnly = true;

                btSalvar.Enabled = true;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // liberar componentes
            txtDescricao.Enabled = true;
            txtValorUnit.Enabled = true;
            txtQuant.Enabled = true;
            txtTotal.Enabled = true;
            txtTotalGeral.Enabled = true;

            btCancelar.Enabled = true;
            btDeletar.Enabled = true;

            dgvTabela.Enabled = true;

            txtDescricao.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja mesmo cancelar?","ADS",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                // bloquea botoes
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;

                //bloquea campos texto
                txtDescricao.Enabled=false;
                txtQuant.Enabled=false;
                txtValorUnit.Enabled=false;
                txtTotal.Enabled=false;
                txtTotalGeral.Enabled=false;

                //limpar os campos
                txtTotal.Clear();
                txtValorUnit.Clear();
                txtQuant.Clear();
                txtDescricao.Clear();
            }
        }

        private void FormPerdido_Load(object sender, EventArgs e)
        {

        }
    }
}
