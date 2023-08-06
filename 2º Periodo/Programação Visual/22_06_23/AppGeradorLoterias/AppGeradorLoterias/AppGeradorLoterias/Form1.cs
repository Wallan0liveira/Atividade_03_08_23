using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGeradorLoterias;
using AppGeradorLoterias.Formularios;

namespace AppGeradorLoterias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLotoFacil_Click(object sender, EventArgs e)
        {
            Formularios.FormLotoFacil formLotoFacil = new Formularios.FormLotoFacil();
            formLotoFacil.ShowDialog();
        }

        private void btMega_Click(object sender, EventArgs e)
        {
            Formularios.FormMegaSena formMegaSena = new Formularios.FormMegaSena();
            formMegaSena.ShowDialog();
        }

        private void btQuina_Click(object sender, EventArgs e)
        {
            Formularios.FormQuina formQuina = new Formularios.FormQuina();
            formQuina.ShowDialog();
        }

        private void btLotoMania_Click(object sender, EventArgs e)
        {
            Formularios.FormLotoMania formLotoMania = new Formularios.FormLotoMania();
            formLotoMania.ShowDialog();
        }

        private void btDiaDeSorte_Click(object sender, EventArgs e)
        {
           Formularios.FormDiaDeSorte formDiaDeSorte = new Formularios.FormDiaDeSorte();
            formDiaDeSorte.ShowDialog();
        }

        private void btSuperSete_Click(object sender, EventArgs e)
        {
            Formularios.FormSuperSete formSuperSete = new FormSuperSete();
            formSuperSete.ShowDialog();
        }
    }
}
