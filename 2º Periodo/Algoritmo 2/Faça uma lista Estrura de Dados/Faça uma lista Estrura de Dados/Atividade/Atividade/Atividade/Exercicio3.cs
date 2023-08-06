using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Exercicio3
    {
        public void MenuExercicio3()
        {
            Passageiro novo = null, inicio = null, lista = null, aux = null;

            Biblioteca biblioteca = new Biblioteca();

            string[,] poltrona = new string[10, 2];
            string[] implemento = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            for (int i = 0; i < 10; i++)
            {
                poltrona[i, 0] = "Livre";
                poltrona[i, 1] = implemento[i];
            }

            int op = 0, auxiliar1 = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Incluir passageiro");
                Console.WriteLine("2 - Totalizar passagens");
                Console.WriteLine("3 - Listar passageiros");
                Console.WriteLine("4 - Saír");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();

                            auxiliar1++;

                            string auxiliar2 = "erro";

                            Console.WriteLine("\n--------------------------\n");

                            novo = new Passageiro();
                            Console.Write("Nome: ");
                            novo.nome = Console.ReadLine();

                            Console.WriteLine("\n--------------------------\n");

                            Console.Write("CPF: ");
                            novo.cpf = Console.ReadLine();
                            do
                            {
                                auxiliar2 = "erro";
                                Console.WriteLine("\n--------------------------\n");
                                Console.WriteLine("Escolha a Poltrona");
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine($"Poltrona {poltrona[i, 0]} Nº -> {poltrona[i, 1]}");
                                }

                                Console.Write("\nDigite o número da poltrona: ");
                                string nPultrona = Console.ReadLine();

                                for (int i = 0; i < 10; i++)
                                {
                                    if (poltrona[i, 1] == nPultrona && poltrona[i, 0] == "Livre")
                                    {
                                        poltrona[i, 0] = "Reservado";
                                        auxiliar2 = "Sair";
                                        novo.poltrona = nPultrona;
                                    }
                                }
                                if (auxiliar2 == "erro")
                                {
                                    Console.WriteLine("Poltrona Indisponivel!");
                                    Console.ReadKey();
                                    break;
                                }

                            } while (auxiliar2 != "Sair");

                            if (auxiliar2 == "erro")
                            {
                                break;
                            }

                            Console.WriteLine("\n--------------------------\n");

                            Console.Write("Cidade de Destino: ");
                            novo.cidadeDestino = Console.ReadLine();

                            Console.WriteLine("\n--------------------------\n");

                            Console.Write("Valor da Passagem: ");
                            novo.valorPassagem = Convert.ToDouble(Console.ReadLine());

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

                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            aux = inicio;
                            double resp;
                            int contador = 0, auxiliar = 0;
                            while (aux != null)
                            {
                                contador++;
                                aux = aux.prox;
                            }
                            double[] total = new double[contador];
                            aux = inicio;
                            while (aux != null)
                            {
                                total[auxiliar] = aux.valorPassagem;
                                auxiliar++;
                                aux = aux.prox;
                            }

                            resp = biblioteca.SomaVetor(total, total.Length);
                            Console.WriteLine("\nValor total em passagens: " + resp);
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            aux = inicio;
                            Passageiro aux1 = biblioteca.ordenarListaSimple(aux);
                            while (aux1 != null)
                            {
                                Console.WriteLine(aux1.nome);
                                Console.WriteLine(aux1.cpf);
                                Console.WriteLine(aux1.poltrona);
                                Console.WriteLine(aux1.cidadeDestino);
                                Console.WriteLine(aux1.valorPassagem);
                                Console.WriteLine("\n---------------------------------------\n");
                                aux1 = aux1.prox;
                            }
                            Console.ReadKey();

                            break;
                        }
                }
            } while (op != 4);
        }
    }
}
