using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Exercicio
    {
        Gado novo = null, inicio = null, lista = null, aux = null;

        public void AdicionarLista()
        {
            Console.Clear();
            novo = new Gado();

            Console.WriteLine("Informe os dados abaixo:\n");
            Console.Write("Código :");
            novo.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Raça :");
            novo.raca = Console.ReadLine().ToUpper();
            Console.Write("Cor :");
            novo.cor = Console.ReadLine().ToUpper();
            Console.Write("Descrição :");
            novo.descricao = Console.ReadLine().ToUpper();
            Console.Write("Sexo (M,F) :");
            novo.sexo = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Peso (Kg) :");
            novo.peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Idade (Meses):");
            novo.idade = Convert.ToDouble(Console.ReadLine());

            if (inicio == null)
            {
                inicio = novo;
                inicio.prox = null;
            }
            else
            {
                if (inicio.prox == null)
                {
                    lista = novo;
                    inicio.prox = lista;
                    lista.prox = null;
                }

                lista.prox = novo;
                lista = novo;
                lista.prox = null;
            }
        }

        public void Consultar()
        {
            
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção de consulta abaixo:\n");
                Console.WriteLine("1 - Raça");
                Console.WriteLine("2 - Idade");
                Console.WriteLine("0 - Voltar");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            ConsultaRaca();
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            ConsultaIdade();
                            Console.ReadKey();
                            break;
                        }

                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção Invalida!");
                            Console.ReadKey();
                            break;
                        }
                }

            } while (op != 0);

        }

        void ConsultaRaca()
        {
            Console.Clear();
            Console.Write("Digite a Raça:");
            string raca = Console.ReadLine().ToUpper();

            aux = inicio;
            while (aux != null)
            {
                if (aux.raca.Equals(raca))
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Console.WriteLine($"Código : {aux.codigo}");
                    Console.WriteLine($"Raça : {aux.raca}");
                    Console.WriteLine($"Cor : {aux.cor}");
                    Console.WriteLine($"Idade : {aux.idade}");
                    Console.WriteLine($"Descrição : {aux.descricao}");
                    Console.WriteLine($"Peso : {aux.peso}");
                    Console.WriteLine($"Sexo : {aux.sexo}");
                    Console.WriteLine("");
                }
                aux = aux.prox;
            }
        }

        void ConsultaIdade()
        {
            Console.Clear();
            Console.Write("Digite a Idade:");
            double idade = Convert.ToDouble(Console.ReadLine());

            aux = inicio;
            while (aux != null)
            {
                if (aux.idade.Equals(idade))
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Console.WriteLine($"Código : {aux.codigo}");
                    Console.WriteLine($"Raça : {aux.raca}");
                    Console.WriteLine($"Cor : {aux.cor}");
                    Console.WriteLine($"Idade : {aux.idade}");
                    Console.WriteLine($"Descrição : {aux.descricao}");
                    Console.WriteLine($"Peso : {aux.peso}");
                    Console.WriteLine($"Sexo : {aux.sexo}");
                    Console.WriteLine("");
                }
                aux = aux.prox;
            }
        }

        public void TodosElementos()
        {
            Console.Clear();
            int contador = 0;
            aux = inicio;
            while (aux != null)
            {
                Console.WriteLine("\n--------------------------------\n");
                Console.WriteLine($"Código : {aux.codigo}");
                Console.WriteLine($"Raça : {aux.raca}");
                Console.WriteLine($"Cor : {aux.cor}");
                Console.WriteLine($"Idade : {aux.idade}");
                Console.WriteLine($"Descrição : {aux.descricao}");
                Console.WriteLine($"Peso : {aux.peso}");
                Console.WriteLine($"Sexo : {aux.sexo}"); ;
                Console.WriteLine("");
                contador++;
                aux = aux.prox;
            }
            Console.WriteLine($"Quantidade de cadastros na lista: {contador}");
            Console.ReadKey();
        }

        public void ConsultaPorSexo()
        {
            Console.Clear();
            int m = 0, f = 0;
            aux = inicio;
            while (aux != null)
            {
                if (aux.sexo.Equals('M'))
                {
                    m++;
                }
                if (aux.sexo.Equals('F'))
                {
                    f++;
                }
                aux = aux.prox;
            }
            Console.WriteLine($"Qunatidade de animais por sexo:\n" +
                $"Macho: {m}\n" +
                $"Femea: {f}");
            Console.ReadKey();
        }

        public void ValorAnimal()
        {
            Console.Clear();
            Console.WriteLine("Obs: Considere o peso do gado vivo R$ 220,00 por cada 30kg");
            double valor = 0.0;
            aux = inicio;
            while (aux != null)
            {
                Console.WriteLine("\n--------------------------------\n");
                Console.WriteLine($"Código : {aux.codigo}");
                Console.WriteLine($"Raça : {aux.raca}");
                Console.WriteLine($"Cor : {aux.cor}");
                Console.WriteLine($"Idade : {aux.idade}");
                Console.WriteLine($"Descrição : {aux.descricao}");
                Console.WriteLine($"Peso : {aux.peso}");
                Console.WriteLine($"Sexo : {aux.sexo}");
                valor = CalculaValorAnimal(aux.peso);
                Console.WriteLine($"\nValor do animal: R${valor}");
                Console.WriteLine("");
                aux = aux.prox;
            }
            Console.ReadKey();
        }

        double CalculaValorAnimal(double peso)
        {
            double valor = 0.0;

            valor = (peso / 30) * 220;

            return valor;
        }
    }
}
