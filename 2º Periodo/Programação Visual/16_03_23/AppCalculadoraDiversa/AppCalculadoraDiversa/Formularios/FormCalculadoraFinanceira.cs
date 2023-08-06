using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraDiversa.Formularios
{
    public partial class FormCalculadoraFinanceira : Form
    {
        public FormCalculadoraFinanceira()
        {
            InitializeComponent();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //para deixar a formartação padrão antes de entrar no switch
            txtTaxa.BackColor = SystemColors.Window;
            txtTaxa.ReadOnly = false;
            txtTempo.BackColor = SystemColors.Window;
            txtTempo.ReadOnly = false;
            txtCapital.BackColor = SystemColors.Window;
            txtCapital.ReadOnly = false;
            txtMontante.BackColor = SystemColors.Window;
            txtMontante.ReadOnly = false;

            

            int idex = cbOpcao.SelectedIndex;

            switch (idex)
            {//inicio do switch

                case 0:
                    {
                        txtMontante.BackColor = Color.Blue;//pinta o caixa de texto
                        txtMontante.ReadOnly = true;//trava para edições
                        break;
                    }

                case 1:
                    {
                       txtCapital.BackColor = Color.Blue;
                        txtCapital.ReadOnly = true;
                        break;
                    }

                case 2:
                    {
                        txtTempo.BackColor = Color.Blue;
                        txtTempo.ReadOnly = true;
                        break;
                    }

                case 3:
                    {
                        txtTaxa.BackColor = Color.Blue;
                        txtTaxa.ReadOnly = true;
                        break;
                    }

            }//fim do switch
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double montante = 0.00, capital = 0.00, taxa = 0.00, juros = 0.00, tempo = 0;        

            int index = cbOpcao.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        capital = Convert.ToDouble(txtCapital.Text);// pega da caixa de texto o valor
                        taxa = (Convert.ToDouble(txtTaxa.Text))/100;// pega da caixa de texto o valor
                        tempo = Convert.ToDouble(txtTempo.Text);// pega da caixa de texto o valor

                        montante = capital * (1 + taxa * tempo);

                        txtMontante.Text = montante.ToString("C");// mostra na caixa de texto o valor

                        juros = montante - capital;

                        txtJuros.Text = juros.ToString("C");// mostra na caixa de texto o valor
                        break;
                    }
                
                case 1:
                    {
                        montante = Convert.ToDouble(txtCapital.Text);// pega da caixa de texto o valor
                        taxa = (Convert.ToDouble((txtTaxa.Text)))/100;// pega da caixa de texto o valor
                        tempo = Convert.ToDouble((txtTempo.Text));// pega da caixa de texto o valor

                        capital = montante / (1 + taxa * tempo);

                        txtCapital.Text = capital.ToString("C");// mostra na caixa de texto o valor

                        juros = montante - capital;

                        txtJuros.Text = juros.ToString("C");// mostra na caixa de texto o valor
                        break;
                    }
                
                case 2:
                    {
                        montante = Convert.ToDouble(txtCapital.Text);
                        taxa = Convert.ToDouble(txtTaxa);
                        capital = Convert.ToDouble(txtCapital.Text);

                        tempo = (montante - capital) / (capital * taxa);

                        txtTempo.Text = tempo.ToString("C");

                        juros = tempo - capital;

                        txtJuros.Text= juros.ToString("C");


                        break;
                    }
                
                case 3:
                    {
                        montante = Convert.ToDouble(txtMontante.Text);
                        capital = Convert.ToDouble(txtCapital.Text);
                        tempo = Convert.ToDouble(txtTempo.Text);

                        taxa = (montante - capital) / (capital * tempo);

                        txtTaxa.Text = taxa.ToString("C");

                        juros = (montante - capital);

                        txtJuros.Text = juros.ToString("C");

                        break;
                    }               
            }                       
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtCapital.Clear();
            txtJuros.Clear();
            txtMontante.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtMontante.Select();
            txtTaxa.BackColor = SystemColors.Window;
            txtTaxa.ReadOnly = false;
            txtTempo.BackColor = SystemColors.Window;
            txtTempo.ReadOnly = false;
            txtCapital.BackColor = SystemColors.Window;
            txtCapital.ReadOnly = false;
            txtMontante.BackColor = SystemColors.Window;
            txtMontante.ReadOnly = false;
        }
    }
}