using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Listas_de_Exercicios
{

    internal class Lista2Exercicios
    {
        Biblioteca biblioteca = new Biblioteca();//Minha biblioteca de funções (GLOBAL)

        public void Lista2Exercicio1(double[] numero)
        {
            biblioteca.FuncaoVetorOrdenar(numero);

            Console.WriteLine("***********************\nNúmeros ordenados:");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }
            Console.ReadKey();
        }

        public void Lista2Exercicio2()
        {
            string opcao;
            double[,] matrizA = new double[3, 3];
            do
            {
                Console.Clear();
                Console.WriteLine("A - Preencher a Matriz");
                Console.WriteLine("B - Ordenar os valores da Matriz");
                Console.WriteLine("C - Extrair apenas os núemros Par");
                Console.WriteLine("D - Extrair apenas os núemros Múltiplo de 5");
                Console.WriteLine("E - Saír");
                opcao = Console.ReadLine().ToUpper();
                switch (opcao)
                {
                    case "A":
                        {

                            //pega os valores na matriz
                            Console.WriteLine("Informe os números para matriz abaixo:");
                            for (int i = 0; i < matrizA.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrizA.GetLength(1); j++)
                                {
                                    Console.Write($"Linha {i + 1}, Coluna {j + 1}.: ");
                                    matrizA[i, j] = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                            Console.WriteLine("");

                            //mostra os valores como foram digitados
                            Console.WriteLine("Os valores digitados são:");
                            for (int i = 0; i < matrizA.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrizA.GetLength(1); j++)
                                {
                                    Console.WriteLine(matrizA[i, j]);
                                }
                            }
                            Console.WriteLine("\nPressione qualquer tecla para saír!");
                            Console.ReadKey();
                            break;
                        }

                    case "B":
                        {
                            biblioteca.FuncaoMatrizOrdenar(matrizA);

                            //mostra os números ordenados
                            Console.WriteLine("Números ordenados:");
                            for (int i = 0; i < matrizA.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrizA.GetLength(1); j++)
                                {
                                    Console.WriteLine(matrizA[i, j]);
                                }
                            }
                            Console.WriteLine("\nPressione qualquer tecla para saír!");
                            Console.ReadKey();
                            break;
                        }

                    case "C":
                        {
                            //pegas os números par da uma matriz e passa para outra
                            double[,] matrizPar = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
                            matrizPar = biblioteca.FuncaoMatrizImparPar(matrizA, 1);// 1 para par e 2 para impar
                            Console.WriteLine("");

                            //exibe os números par
                            Console.WriteLine("Números Par:");
                            for (int i = 0; i < matrizA.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrizA.GetLength(1); j++)
                                {
                                    if (matrizPar[i,j] != 0)
                                    {
                                        Console.WriteLine(matrizPar[i, j]);
                                    }
                                }
                            }
                            Console.WriteLine("\nPressione qualquer tecla para saír!");
                            Console.ReadKey();
                            break;
                        }

                    case "D":
                        {
                            //verifica os números multiplo de 5 e passa para outra matriz
                            double[,] matrizMultipli5 = new double[matrizA.GetLength(0), matrizA.GetLength(1)];

                            matrizMultipli5 = biblioteca.FuncaoMatrizMultiplo(matrizA, 5);

                            Console.WriteLine("");

                            //exibe os números multiplos de 5
                            Console.WriteLine("Números Multiplo de 5:");
                            for (int i = 0; i < matrizA.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrizA.GetLength(1); j++)
                                {
                                    if (matrizMultipli5[i, j] != 0)
                                    {
                                        Console.WriteLine(matrizMultipli5[i, j]);
                                    }
                                }
                            }
                            Console.WriteLine("\nPressione qualquer tecla para saír!");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        break;
                }
            } while (opcao != "E");
        }

        public string Lista2Exercicio3(double valorPrincipal, int tipoPrincipal)
        {
            double valor = valorPrincipal;
            string resposta = "";
            int tipo = tipoPrincipal;

            switch (tipo)
            {
                case 1:
                    {
                        resposta = Convert.ToString((valor * 5.05));
                        break;
                    }

                case 2:
                    {
                        resposta = Convert.ToString((valor * 6.29));
                        break;
                    }

                case 3:
                    {
                        resposta = Convert.ToString((valor * 5.59));
                        break;
                    }

                case 4:
                    {
                        resposta = Convert.ToString((valor * 0.038));
                        break;
                    }

                case 5:
                    {
                        resposta = Convert.ToString((valor / 5.05));
                        break;
                    }

                case 6:
                    {
                        resposta = Convert.ToString((valor / 6.29));
                        break;
                    }

                case 7:
                    {
                        resposta = Convert.ToString((valor / 5.59));
                        break;
                    }

                case 8:
                    {
                        resposta = Convert.ToString((valor / 0.038));
                        break;
                    }
                default:
                    break;
            }

            return Convert.ToString(resposta + (Convert.ToString("\nCotação do dia 06/04/23")));//cotação do dia 06/04/23

        }

        public string Lista2Exercicio4(double valor1, double valor2)
        {
            string resposta = "", v1, v2;

            v1 = Convert.ToString(valor1);
            v2 = Convert.ToString(valor2);



            if (valor1 % valor2 == 0)
            {
                resposta = "O número " + v1 + " é divisivel por " + v2;
            }
            else
            {
                resposta = "O número " + v1 + " não é divisivel por " + v2;
            }

            return resposta;
        }

        public int Lista2Exercicio5(double valor)
        {
            int resposta = Convert.ToInt32(valor.ToString("F0"));
            return resposta;
        }

        public double[] lista2Exercicio6Vetor = new double[30];
        public double[] lista2Exercicio6VetorAleatorio = new double[30];
        public double[] Lista2Exercicio6VetorMultiplo = new double[30];
        public double[] Lista2Exercicio6VetorOrdenado = new double[30];
        public void Lista2Exercicio6()
        {
            Random randon = new Random();
            for (int i = 0; i < lista2Exercicio6Vetor.Length; i++)
            {
                lista2Exercicio6Vetor[i] = randon.Next(1, 101);
            }

            for (int i = 0; i < lista2Exercicio6Vetor.Length; i++)
            {
                lista2Exercicio6VetorAleatorio[i] = lista2Exercicio6Vetor[i];
                Lista2Exercicio6VetorOrdenado[i] = lista2Exercicio6Vetor[i];
                Lista2Exercicio6VetorMultiplo[i] = lista2Exercicio6Vetor[i];
            }

            Lista2Exercicio6VetorOrdenado = biblioteca.FuncaoVetorOrdenar(lista2Exercicio6Vetor);
            Lista2Exercicio6VetorMultiplo = biblioteca.FuncaoVetorMultiplo(lista2Exercicio6Vetor, 7);
        }
    }
}