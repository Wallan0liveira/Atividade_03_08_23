using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Atividade;

namespace Atividade
{
    internal class Exercicio1
    {
        public void MenuExercicio1()
        {
            Console.Clear();
            Funcionario novo = null, inicio = null, lista = null, aux = null;
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastra Funcionario");
                Console.WriteLine("2 - Cadastra Venda");
                Console.WriteLine("3 - Listar Todos Funcionarios");
                Console.WriteLine("4 - Consultar Funcionario");
                Console.WriteLine("5 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();
                            novo = new Funcionario();

                            Console.WriteLine("\n*************************\nInforme os dados abaixo:\n");
                            Console.WriteLine("Nome:");
                            novo.nome = Console.ReadLine();
                            Console.WriteLine("\nCPF");
                            novo.cpf = Console.ReadLine().ToLower();
                            Console.WriteLine("\nMatricula");
                            novo.matricula = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nProfissão");
                            novo.profissao = Console.ReadLine();
                            Console.WriteLine("\nSalário");
                            novo.salario = Convert.ToDouble(Console.ReadLine());

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

                            Console.WriteLine("Funcionario cadastrado com sucesso!");
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um CPF da Lista de Funcionarios");
                            string cpf = Console.ReadLine().ToLower();

                            aux = inicio;

                            while (aux != null)
                            {
                                if (cpf == (aux.cpf))
                                {
                                    Console.WriteLine("\nDigite o valor total em vendas:");
                                    double valorVendas = Convert.ToDouble((Console.ReadLine()));

                                    Biblioteca biblioteca = new Biblioteca();
                                    aux.salario = biblioteca.CalcularSalario(aux.salario, valorVendas);

                                    Console.WriteLine("\nAtualizado!");
                                    Console.ReadKey();
                                }
                                aux = aux.prox;
                            }
                                break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            aux = inicio;
                            Console.WriteLine("Lista de Usuarios cadastrado:\n");

                            while (aux != null)
                            {
                                Console.WriteLine(aux.nome);
                                Console.WriteLine(aux.cpf);
                                Console.WriteLine(aux.matricula);
                                Console.WriteLine(aux.profissao);
                                Console.WriteLine(aux.salario);
                                aux = aux.prox;
                                Console.WriteLine("\n__________________________\n");
                            }
                            Console.ReadKey();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            int case4 = 0, matricula;
                            string cpf;

                            
                            do
                            {
                                Console.WriteLine("Digite como deseja consultar:");
                                Console.WriteLine("1 - CPF");
                                Console.WriteLine("2 - Matricula");
                                Console.WriteLine("3 - Sair");
                                case4 = Convert.ToInt32(Console.ReadLine());
                                switch (case4)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("\nDigite o CPF:");
                                            cpf = Console.ReadLine().ToLower();

                                            aux = inicio;

                                            while (aux != null)
                                            {
                                                if (cpf.Equals(aux.cpf))
                                                {
                                                    Console.WriteLine(aux.nome);
                                                    Console.WriteLine(aux.cpf);
                                                    Console.WriteLine(aux.matricula);
                                                    Console.WriteLine(aux.profissao);
                                                    Console.WriteLine(aux.salario);
                                                }
                                                aux = aux.prox;
                                            }
                                            Console.ReadKey();
                                            case4 = 3;
                                            break;
                                        }

                                    case 2:
                                        {
                                            Console.WriteLine("\nDigite a Matricula:");
                                            matricula = Convert.ToInt32(Console.ReadLine());

                                            aux = inicio;

                                            while (aux != null)
                                            {
                                                if (matricula.Equals(aux.matricula))
                                                {
                                                    Console.WriteLine(aux.nome);
                                                    Console.WriteLine(aux.cpf);
                                                    Console.WriteLine(aux.matricula);
                                                    Console.WriteLine(aux.profissao);
                                                    Console.WriteLine(aux.salario);
                                                }
                                                aux = aux.prox;
                                            }
                                            Console.ReadKey();
                                            case4 = 3;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                            } while (case4 != 3);
                            break;
                        }
                }
            } while (op != 5);
        }
    }
}