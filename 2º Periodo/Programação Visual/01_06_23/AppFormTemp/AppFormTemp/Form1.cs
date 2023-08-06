using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormTemp
{
    public partial class Form1 : Form
    {
        int cont = 0;

        public Form1()
        {
            InitializeComponent();

            //timerPrimeiroTeste.Start();

            btAmarelo.BackColor = Color.White;
            btVerde.BackColor = Color.White;
            btVermelho.BackColor = Color.White;
            // while (cont <25)
            {
                
                //if (cont >= 0 && cont < 5)
                {
                    timerVerde.Start();
                }
                if (cont >= 5 && cont < 8)
                {
                    timerAmarelo.Start();
                }
                if (cont >= 8 && cont < 12)
                {
                    timerVermelho.Start();
                }
            }
        }

        private void timerPrimeiroTeste_Tick(object sender, EventArgs e)
        {
            // cont++;
            // MessageBox.Show("TEMPO"+ cont); --> 

            //if (cont > 10)
            {
                // btPare.BackColor = Color.Blue;
            }
            //if (cont > 15)
            {
                //  btPare.BackColor = Color.Yellow;
            }
            //if (cont > 20)
            {
                // btPare.BackColor = Color.Red;
            }

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            timerPrimeiroTeste.Start();
        }

        private void btPare_Click(object sender, EventArgs e)
        {
            timerPrimeiroTeste.Stop();
        }

        private void btVerde_Click(object sender, EventArgs e)
        {

        }

        private void timerVerde_Tick(object sender, EventArgs e)
        {
            cont++;
            timerAmarelo.Stop();
            timerVermelho.Stop();
            if (cont <5)
            {

                btVerde.BackColor = Color.Green;
                btAmarelo.BackColor = Color.White;
                btVermelho.BackColor = Color.White;
            }

        }

        private void timerAmarelo_Tick(object sender, EventArgs e)
        {
            cont++;
            timerVerde.Stop();
            timerVermelho.Stop();
            if (cont <3)
            {

            }
            {




                btVerde.BackColor = Color.White;
                btAmarelo.BackColor = Color.Yellow;
                btVermelho.BackColor = Color.White;
            }
        }

        private void timerVermelho_Tick(object sender, EventArgs e)
        {
            cont++;

            timerVerde.Stop();
            timerAmarelo.Stop();

            if (cont <5)
            {

                btVerde.BackColor = Color.White;
                btAmarelo.BackColor = Color.White;
                btVermelho.BackColor = Color.Red;
            }
        }
    }
}
