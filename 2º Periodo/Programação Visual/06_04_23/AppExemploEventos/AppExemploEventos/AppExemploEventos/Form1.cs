using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploEventos.Formulario; 

namespace AppExemploEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMensagens_Click(object sender, EventArgs e)
        {
            FormMensagem form = new FormMensagem();
            form.ShowDialog(); 
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculo form = new FormCalculo();
            form.ShowDialog(); 
        }
    }
}
