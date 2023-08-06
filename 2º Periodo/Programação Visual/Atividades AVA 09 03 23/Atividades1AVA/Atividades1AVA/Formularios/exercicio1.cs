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
    public partial class exercicio1 : Form
    {
        public exercicio1()
        {
            InitializeComponent();
        }

        private void btLimpar1_Click(object sender, EventArgs e)
        {
            txtAlqueirePaulista1.Clear();
            txtHectares1.Clear();
            txtHectares1.Select();
        }

        private void txtHectares1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlqueirePaulista1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btConverter1_Click(object sender, EventArgs e)
        {
            double ap, hc;

            hc = Convert.ToDouble(txtHectares1.Text);

            ap = hc / 2.42;

            txtAlqueirePaulista1.Text = ap.ToString();

        }
    }
}
