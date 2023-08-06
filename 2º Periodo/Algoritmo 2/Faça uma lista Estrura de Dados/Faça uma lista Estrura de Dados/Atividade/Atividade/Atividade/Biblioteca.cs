using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Biblioteca
    {
        public double CalcularSalario(double salario, double vendas)
        {
            salario = salario + (vendas * 0.12);

            return salario;
        }

        public double SomaVetor(double[] valor1, double valor2)
        {
            double total=0.0;
            for (int i = 0; i < valor2; i++)
            {
                total += valor1[i];

            }
            return total;
        }

        public Passageiro ordenarListaSimple(Passageiro lista)
        {
            Passageiro atual = lista;

            while (atual != null)
            {
                Passageiro menor = atual;
                Passageiro aux = atual.prox;

                while (aux != null)
                {
                    if (string.Compare(aux.poltrona, menor.poltrona) < 0)
                    {
                        menor = aux;
                    }

                    aux = aux.prox;
                }

                if (menor != atual)
                {
                    TrocarNos(atual, menor);
                }

                atual = atual.prox;
            }

            return lista;
        }

        private void TrocarNos(Passageiro no1, Passageiro no2)
        {
            string tempNome = no1.nome;
            string tempCpf = no1.cpf;
            string tempPoltrona = no1.poltrona;
            string tempCidadeDestino = no1.cidadeDestino;
            double tempValorPassagem = no1.valorPassagem;

            no1.nome = no2.nome;
            no1.cpf = no2.cpf;
            no1.poltrona = no2.poltrona;
            no1.cidadeDestino = no2.cidadeDestino;
            no1.valorPassagem = no2.valorPassagem;

            no2.nome = tempNome;
            no2.cpf = tempCpf;
            no2.poltrona = tempPoltrona;
            no2.cidadeDestino = tempCidadeDestino;
            no2.valorPassagem = tempValorPassagem;
        }

    }
}
