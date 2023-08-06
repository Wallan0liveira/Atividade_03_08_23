using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_de_Exercicios;// para chamar as funções da aba Lista1Exercicios e Lista2Exercicios

namespace Listas_de_Exercicios
{
    internal class MenuExercicio // nome da minha classe
    {
        public void Lista1() // meu menu secundario para entrar na lista 1 de exercicios
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo a Lista Número 1 de Exercicios, Escolha uma Opção Abaixo:");
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Exercício 4");
                Console.WriteLine("5 - Exercício 5");
                Console.WriteLine("0 - Para Volta ao Menu");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Lista1Exercicios Lista1Exercicio1 = new Lista1Exercicios();
                            Lista1Exercicio1.Lista1Exercicio1();
                            break;
                        }
                    case 2:
                        {
                            Lista1Exercicios Lista1Exercicio2 = new Lista1Exercicios();
                            Lista1Exercicio2.Lista1Exercicio2();
                            break;
                        }
                    case 3:
                        {
                            Lista1Exercicios Lista1Exercicio3 = new Lista1Exercicios();
                            Lista1Exercicio3.Lista1Exercicio3();
                            break;
                        }
                    case 4:
                        {
                            Lista1Exercicios Lista1Exercicios4 = new Lista1Exercicios();
                            Lista1Exercicios4.Lista1Exercicio4();
                            break;
                        }
                    case 5:
                        {
                            Lista1Exercicios Lista1Exercicio5 = new Lista1Exercicios();
                            Lista1Exercicio5.Lista1Exercicio5();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Resposta Volta ao Menu");
                            Console.Clear();
                            break;
                        }
                }
            } while (opcao != 0);
        }

        public void Lista2() // meu menu secondario para entrar na lista 2 de exercicios
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo a Lista Número 2 de Exercicios, Escolha uma Opção Abaixo:");
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Exercício 4");
                Console.WriteLine("5 - Exercício 5");
                Console.WriteLine("6 - Exercício 6");
                Console.WriteLine("0 - Para Volta ao Menu");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("\n* Ordena três números fornecidos pelo usúario\n");
                            Lista2Exercicios Lista2Exercicio1 = new Lista2Exercicios();
                            double[] numero = new double[3];// aqui falo qual o tamanho do meu vetor para o exercicio

                            for (int i = 0; i < numero.Length; i++)
                            {
                                Console.WriteLine($"Digite o {i + 1}º número:");
                                numero[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Lista2Exercicio1.Lista2Exercicio1(numero);
                            break;
                        }
                    case 2:
                        {
                            Lista2Exercicios Lista2Exercicio2 = new Lista2Exercicios();
                            Lista2Exercicio2.Lista2Exercicio2();
                            break;
                        }
                    case 3:
                        {
                            Lista2Exercicios Lista2Ecercico3 = new Lista2Exercicios();
                            int opcaoEx3 = 0;
                            double valor = 0.00;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1 - Converter Real Brasileiro em Dólar Americano");
                                Console.WriteLine("2 - Converter Real Brasileiro em Libra esterlina");
                                Console.WriteLine("3 - Converter Real Brasileiro em Franco Suíço");
                                Console.WriteLine("4 - Converter Real Brasileiro em Iene Japonês");
                                Console.WriteLine("5 - Converter Dólar Americano em  Real Brasileiro");
                                Console.WriteLine("6 - Converter Libra esterlina em Real Brasileiro");
                                Console.WriteLine("7 - Converter Franco Suíço em Real Brasileiro");
                                Console.WriteLine("8 - Converter Iene Japonês em Real Brasileiro");
                                Console.WriteLine("9 - Saír");
                                opcaoEx3 = Convert.ToInt32(Console.ReadLine());
                            } while ((opcaoEx3 > 8 || opcaoEx3 < 1) && opcaoEx3 != 9);
                            if (opcaoEx3 != 9)
                            {
                                Console.WriteLine("Digite o valor para converter (Somente Números)");
                                valor = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine(Lista2Ecercico3.Lista2Exercicio3(valor, opcaoEx3));
                                Console.ReadKey();
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n* Verifica se um número é divisivel por outro\n");
                            Lista2Exercicios Lista2Exercicio4 = new Lista2Exercicios();
                            double valor1, valor2;
                            string resposta;
                            Console.WriteLine("Informe o 1º Valor:");
                            valor1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Informe o 2º Valor:");
                            valor2 = Convert.ToDouble(Console.ReadLine());

                            resposta = Lista2Exercicio4.Lista2Exercicio4(valor1, valor2);

                            Console.WriteLine(resposta);
                            Console.ReadKey();

                            break;
                        }
                    case 5:
                        {
                            Lista2Exercicios Lista2Exercicio5 = new Lista2Exercicios();
                            double valor, resposta;

                            Console.WriteLine("Digite um número fracionado para converter em inteiro:");
                            valor = Convert.ToDouble(Console.ReadLine());
                            resposta = Lista2Exercicio5.Lista2Exercicio5(valor);
                            Console.WriteLine(resposta);
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Lista2Exercicios Lista2Exercicio6 = new Lista2Exercicios();
                            Console.WriteLine("O vetor é preenchido de forma aleatíroa e automatica!");
                            Lista2Exercicio6.Lista2Exercicio6();
                            double[] teste = new double[30];
                            
                            
                            Console.WriteLine("\n*****  Vetor - Aleatório: *****");
                            for (int i = 0; i < Lista2Exercicio6.lista2Exercicio6Vetor.Length; i++)
                            {
                                Console.WriteLine(Lista2Exercicio6.lista2Exercicio6VetorAleatorio[i]);
                            }
                            
                            Console.WriteLine("\n*****  Vetor - Ordenado: *****");
                            for (int i = 0; i < Lista2Exercicio6.lista2Exercicio6Vetor.Length; i++)
                            {
                                Console.WriteLine(Lista2Exercicio6.Lista2Exercicio6VetorOrdenado[i]);
                            }
                            
                            Console.WriteLine("\n*****  Vetor - Multiplo de 7: *****");
                            for (int i = 0; i < Lista2Exercicio6.lista2Exercicio6Vetor.Length; i++)
                            {
                                if (Lista2Exercicio6.Lista2Exercicio6VetorMultiplo[i] !=0)
                                {
                                    Console.WriteLine(Lista2Exercicio6.Lista2Exercicio6VetorMultiplo[i]);
                                }
                            }

                            Console.ReadKey();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Resposta Volta ao Menu");
                            break;
                            Console.Clear();
                        }
                }
            } while (opcao != 0);
        }
    }
}
