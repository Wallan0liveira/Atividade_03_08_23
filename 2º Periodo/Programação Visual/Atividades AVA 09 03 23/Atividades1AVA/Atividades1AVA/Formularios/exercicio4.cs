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
    public partial class exercicio4 : Form
    {
        public exercicio4()
        {
            InitializeComponent();
        }

        private void btConverter4_Click(object sender, EventArgs e)
        {
            double m, k;

            k = Convert.ToDouble(txtQuilometros4.Text);

            m = k * 1000;

            txtMetros4.Text = m.ToString();
        }

        private void btLimpar4_Click(object sender, EventArgs e)
        {
            txtMetros4.Clear();
            txtQuilometros4.Clear();
            txtQuilometros4.Select();
        }
    }
}
