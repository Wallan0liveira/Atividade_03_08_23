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
    public partial class exercicio3 : Form
    {
        public exercicio3()
        {
            InitializeComponent();
        }

        private void btConverter3_Click(object sender, EventArgs e)
        {
            double m, k;

            m = Convert.ToDouble(txtMetros3.Text);

            k = m / 1000;

            txtQuilometros3.Text = k.ToString();
        }

        private void btLimpar3_Click(object sender, EventArgs e)
        {
            txtMetros3.Clear();
            txtQuilometros3.Clear();
            txtMetros3.Select();
        }
    }
}
