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
    public partial class exercicio6 : Form
    {
        public exercicio6()
        {
            InitializeComponent();
        }

        private void btConverter6_Click(object sender, EventArgs e)
        {
            double m, h;

            m = Convert.ToDouble(txtMinutos6.Text);

            h = m / 60;

            txtHoras6.Text = h.ToString();
        }

        private void btLimpar6_Click(object sender, EventArgs e)
        {
            txtHoras6.Clear();
            txtMinutos6.Clear();
            txtMinutos6.Select();
        }
    }
}
