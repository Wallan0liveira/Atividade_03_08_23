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
    public partial class exercicio5 : Form
    {
        public exercicio5()
        {
            InitializeComponent();
        }

        private void btConverter5_Click(object sender, EventArgs e)
        {
            double h, m;

            h = Convert.ToDouble(txtHoras5.Text);

            m = h * 60;

            txtMinutos5.Text = m.ToString();
        }

        private void btLimpar5_Click(object sender, EventArgs e)
        {
            txtMinutos5.Clear();
            txtHoras5.Clear();
            txtHoras5.Select();
        }
    }
}
