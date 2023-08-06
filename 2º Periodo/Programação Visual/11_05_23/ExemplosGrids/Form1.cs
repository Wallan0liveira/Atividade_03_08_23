using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemplosGrids.Formularios;

namespace ExemplosGrids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = cbForms.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        FormPerdido form = new FormPerdido();
                        form.Show();
                        break;
                    }
                    case 1:
                    {
                        FormReajuste form = new FormReajuste();
                        form.Show();
                        break;
                    }
                    case 2:
                    {
                        FormRegistroDeNotas form = new FormRegistroDeNotas();
                        form.Show();
                        break;
                    }
                default:
                    break;
            }

            
            
        }
    }
}
