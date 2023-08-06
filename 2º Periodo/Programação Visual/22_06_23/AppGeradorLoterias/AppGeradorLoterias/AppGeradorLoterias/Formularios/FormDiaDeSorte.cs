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
    public partial class FormDiaDeSorte : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        public FormDiaDeSorte()
        {
            InitializeComponent();
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;

            if (impar == 4 && par == 3) { lbClass.Text = "MUITO ALTO!"; lbClass.ForeColor = Color.Green; }
            if (impar == 3 && par == 4) { lbClass.Text = "ALTO!"; lbClass.ForeColor = Color.Green; }
            if (impar == 2 && par == 5) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Green; }
            if (impar == 5 && par == 2) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Orange; }
            if (impar == 6 && par == 1) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.Orange; }
            if (impar == 1 && par == 6) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.OrangeRed; }
            if ((impar == 0 || par == 7) && (impar == 7 || par == 0)) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }

        }

        public void Mes()
        {
            List<string> mesesDoAno = new List<string>()
                {
                "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            };

            // Escolher um mês aleatório
            Random random = new Random();
            int indiceAleatorio = random.Next(mesesDoAno.Count);
            lbMes.Text = mesesDoAno[indiceAleatorio];
            lbMes.ForeColor = Color.Gold;
            lbMes.BackColor = Color.DarkGoldenrod;
        }

        public void GerarNumeros()
        {
            int numero = 0;
            int cont = 0;
            int qtdPar = 0;//quantidade de números par
            int qtdImpar = 0;//quantidade de números impar
            Random radNum = new Random();
            NumerosDaSorte.Clear();

            while (cont < 7)
            {
                numero = radNum.Next(1, 32);//números aleatórios
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
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
        }

        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();// Colocar os números da Grid (Tabela)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerarNumeros();
            Mes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparTabela();
            lbClass.Text = "CLASSIFICAÇÃO";
            lbClass.ForeColor = Color.Gold;
            lbPar.Text = "PARES";
            lbImpar.Text = "ÍMPARES";
            lbMes.Text = "Mês";
            lbMes.BackColor = SystemColors.ActiveBorder;
            lbMes.ForeColor = Color.Black;
        }
    }
}
