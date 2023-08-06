using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades1AVA.Formularios
{
    public partial class exercicio2 : Form
    {
        public exercicio2()
        {
            InitializeComponent();
        }

        private void btConverter2_Click(object sender, EventArgs e)
        {
            double ap, hc;

            ap = Convert.ToDouble(txtAlqueirePaulista2.Text);

            hc = ap * 2.42;

            txtHectares2.Text = hc.ToString();
        }

        private void btLimpar2_Click(object sender, EventArgs e)
        {
            txtHectares2.Clear();
            txtAlqueirePaulista2.Clear();
            txtAlqueirePaulista2.Select();
        }
    }
}
