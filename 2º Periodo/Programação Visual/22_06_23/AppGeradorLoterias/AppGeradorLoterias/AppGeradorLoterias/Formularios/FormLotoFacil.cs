using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotoFacil : Form
    {
        public List<int> NumerosDaSorte = new List<int>();

        public FormLotoFacil()
        {
            InitializeComponent();
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;

            if (impar == 8 && par == 7) { lbClass.Text = "MUITO ALTO!"; lbClass.ForeColor = Color.Green; }
            if (impar == 7 && par == 8) { lbClass.Text = "MÉDIA"; lbClass.ForeColor = Color.Green; }
            if (impar == 9 && par == 6) { lbClass.Text = "MÉDIO"; lbClass.ForeColor = Color.Orange; }
            if (impar == 6 && par == 9) { lbClass.Text = "BAIXO"; lbClass.ForeColor = Color.OrangeRed; }
            if (impar <= 5 && par >= 10) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
            if (impar >= 10 && par <= 5) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
        }

        public void GerarNumeros()
        {
            int numero = 0;
            int cont = 0;
            int qtdPar = 0;//quantidade de números par
            int qtdImpar = 0;//quantidade de números impar
            Random radNum = new Random();
            NumerosDaSorte.Clear();

            while (cont < 15)
            {
                numero = radNum.Next(1, 26);//números aleatórios
                if (!NumerosDaSorte.Contains(numero))// Contains => verifica se o número esta na lita
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0) qtdPar++;
                    if (numero % 2 == 1) qtdImpar++;
                    cont++;
                }
            }
            NumerosDaSorte = NumerosDaSorte.OrderBy(num => num).ToList();// Colocar em ordem crescente
            Comparacao(qtdPar, qtdImpar);
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros}).ToList();
        }

        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new {Numero = Numeros}).ToList();// Colocar os números da Grid (Tabela)
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GerarNumeros();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparTabela();
            lbClass.Text = "CLASSIFICAÇÃO";
            lbClass.ForeColor = Color.Purple;
            lbPar.Text = "PARES";
            lbImpar.Text = "ÍMPARES";
        }

        private void lbClass_Click(object sender, EventArgs e)
        {

        }

        private void lbImpar_Click(object sender, EventArgs e)
        {

        }

        private void lbPar_Click(object sender, EventArgs e)
        {

        }

        private void dtvNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLotoFacil_Load(object sender, EventArgs e)
        {

        }
    }
}
