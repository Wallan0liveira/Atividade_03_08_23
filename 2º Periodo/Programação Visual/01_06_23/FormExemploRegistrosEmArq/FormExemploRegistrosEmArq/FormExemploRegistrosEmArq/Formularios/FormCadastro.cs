using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormExemploRegistrosEmArq.Formularios
{
    public partial class FormCadastro : Form
    {
        private int id;
        public FormCadastro()
        {
            InitializeComponent();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            id++;
            StreamWriter sw = new StreamWriter("cad_veiculo.csv", true);
            string registro = id + ";" + txtModelo.Text + ";"+ txtPlaca.Text + ";" + txtAno.Text;

            sw.WriteLine(registro);
            MessageBox.Show("SALVO COM SUCESSO!",//mensagem
                "ADS 2P",//titulo
                MessageBoxButtons.OK,//botões
                MessageBoxIcon.Information );//icone

            sw.Close();
            txtAno.Clear(); txtModelo.Clear(); txtPlaca.Clear();
        }


    }
}
