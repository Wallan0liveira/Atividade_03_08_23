using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Exercicio2
    {
        public void MenuExercico2()
        {
            int op = 0, autorizador = 0;
            Candidato novoCandidato = null, inicioCandidato = null, listaCandidato = null, auxCandidato = null;
            Eleitor novoEleitor = null, inicioEleitor = null, listaEleitor = null, auxEleitor = null;
            Urna novoUrna = null, inicioUrna = null, listaUrna = null, auxUrna = null;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo a Urna de votação.\n");
                Console.WriteLine("1 - Votar");
                Console.WriteLine("2 - Cadastrar Candidato");
                Console.WriteLine("3 - Cadastrar Eleitor");
                Console.WriteLine("4 - Listar todos Candidatos");
                Console.WriteLine("5 - Consultas Eleitores");
                Console.WriteLine("6 - Listar todos Votos");
                Console.WriteLine("7 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();
                            int aux = 0, teste0, b, teste3 = 0;
                            ;
                            Console.WriteLine("Digite o número do titulo:");
                            aux = Convert.ToInt32(Console.ReadLine());

                            novoUrna = new Urna();
                            auxEleitor = inicioEleitor;
                            while (auxEleitor != null)
                            {
                                if (aux.Equals(auxEleitor.titulo))
                                {
                                    novoUrna.tituloEleitor = Convert.ToInt32(aux);
                                    Console.WriteLine("Verificado, continue!");
                                    Console.ReadKey();
                                    autorizador++;
                                }
                                auxEleitor = auxEleitor.prox;
                            }

                            if (autorizador > 0)
                            {
                                autorizador = 0;

                                do
                                {
                                    Console.WriteLine("Escolha a opção desejada:\n1 - Deputado estadual \n2 - Governo estadual \n3 - Sair");
                                    teste0 = Convert.ToInt32(Console.ReadLine());
                                    if (teste0 == 1)
                                    {
                                        Console.Clear();
                                        auxCandidato = inicioCandidato;
                                        while (auxCandidato != null)
                                        {
                                            if ("Deputado estadual".Equals(auxCandidato.cargo))
                                            {
                                                Console.WriteLine(auxCandidato.nome);
                                                Console.WriteLine(auxCandidato.numero);
                                                Console.WriteLine("__________________________\n");
                                            }
                                            auxCandidato = auxCandidato.prox;
                                        }

                                        do
                                        {
                                            Console.Write("Digite o número do seu candidato: ");
                                            int teste1 = Convert.ToInt32(Console.ReadLine());
                                            auxCandidato = inicioCandidato;
                                            while (auxCandidato != null)
                                            {
                                                if (teste1.Equals(auxCandidato.numero) && "Deputado estadual"==auxCandidato.cargo)
                                                {
                                                    novoUrna.numeroCandidato = teste1;
                                                    teste3++;
                                                    Console.WriteLine("\nVocê votou!\n");
                                                    Console.ReadKey();
                                                }
                                                auxCandidato = auxCandidato.prox;
                                            }
                                            if (teste3 == 0)
                                            {
                                                Console.WriteLine("Número Invalido, tente novamente!\n");
                                            }
                                        } while (teste3 == 0);
                                    }
                                    else if (teste0 == 2)
                                    {
                                        Console.Clear();
                                        auxCandidato = inicioCandidato;
                                        while (auxCandidato != null)
                                        {
                                            if ("Governo estadual".Equals(auxCandidato.cargo))
                                            {
                                                Console.WriteLine(auxCandidato.nome);
                                                Console.WriteLine(auxCandidato.numero);
                                                Console.WriteLine("__________________________\n");
                                            }
                                            auxCandidato = auxCandidato.prox;
                                        }

                                        do
                                        {
                                            Console.Write("Digite o número do seu candidato: ");
                                            int teste1 = Convert.ToInt32(Console.ReadLine());
                                            auxCandidato = inicioCandidato;
                                            while (auxCandidato != null)
                                            {
                                                if (teste1.Equals(auxCandidato.numero) && "Governo estadual" == auxCandidato.cargo)
                                                {
                                                    novoUrna.numeroCandidato = teste1;
                                                    teste3++;
                                                    Console.WriteLine("\nVocê votou!\n");
                                                    Console.ReadKey();
                                                }

                                                auxCandidato = auxCandidato.prox;
                                            }
                                            if (teste3 == 0)
                                            {
                                                Console.WriteLine("Número Invalido, tente novamente!\n");
                                            }
                                        } while (teste3 == 0);
                                    }
                                    else if (teste0 == 3)
                                    {
                                        break;
                                    }

                                    if (teste3 == 0)
                                    {
                                        Console.WriteLine("Número invalido, tente novamente!");
                                        Console.ReadKey();
                                        break;
                                    }

                                    teste0 = 3;

                                    if (inicioUrna == null)
                                    {
                                        inicioUrna = novoUrna;
                                        inicioUrna.prox = null;
                                    }
                                    else
                                    {
                                        if (inicioUrna.prox == null)
                                        {
                                            listaUrna = novoUrna;
                                            inicioUrna.prox = listaUrna;
                                            listaUrna.prox = null;
                                        }
                                        listaUrna.prox = novoUrna;
                                        listaUrna = novoUrna;
                                        listaUrna.prox = null;
                                    }
                                } while (teste0 != 3);
                            }
                            else
                            {
                                Console.WriteLine("Titulo Invalido, tente novamente!");
                                Console.ReadKey();
                                autorizador = 0;
                                break;
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            novoCandidato = new Candidato();
                            Console.WriteLine("Digite o Nome do candidato:");
                            novoCandidato.nome = Console.ReadLine();
                            Console.WriteLine("Digite o Número do candidato:");
                            novoCandidato.numero = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite uma opção abaixo:\n1 - Deputado estadutal.\n2 - Governo estadual");
                            int aux = Convert.ToInt32(Console.ReadLine());

                            if (aux == 1)
                            {
                                novoCandidato.cargo = "Deputado estadual";
                            }
                            else if (aux == 2)
                            {
                                novoCandidato.cargo = "Governo estadual";
                            }

                            if (inicioCandidato == null)
                            {
                                inicioCandidato = novoCandidato;
                                inicioCandidato.prox = null;
                            }
                            else
                            {
                                if (inicioCandidato.prox == null)
                                {
                                    listaCandidato = novoCandidato;
                                    inicioCandidato.prox = listaCandidato;
                                    listaCandidato.prox = null;
                                }
                                listaCandidato.prox = novoCandidato;
                                listaCandidato = novoCandidato;
                                listaCandidato.prox = null;
                            }

                            Console.WriteLine("\nCandidato cadastrado com sucesso!");
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            novoEleitor = new Eleitor();
                            Console.WriteLine("Digite o Nome do Eleitor:");
                            novoEleitor.nome = Console.ReadLine();
                            Console.WriteLine("Digite o CPF do Eleitor:");
                            novoEleitor.cpf = Console.ReadLine();
                            Console.WriteLine("Digite o Titulo do Eleitor:");
                            novoEleitor.titulo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o Seção do Eleitor:");
                            novoEleitor.secao = Convert.ToInt32(Console.ReadLine());

                            if (inicioEleitor == null)
                            {
                                inicioEleitor = novoEleitor;
                                inicioEleitor.prox = null;
                            }
                            else
                            {
                                if (inicioEleitor.prox == null)
                                {
                                    listaEleitor = novoEleitor;
                                    inicioEleitor.prox = listaEleitor;
                                    listaEleitor.prox = null;
                                }
                                listaEleitor.prox = novoEleitor;
                                listaEleitor = novoEleitor;
                                listaEleitor.prox = null;
                            }
                            Console.WriteLine("\nEleitor cadastrado com sucesso!");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Lista de todos Candidatos cadastrados:\n");
                            auxCandidato = inicioCandidato;
                            while (auxCandidato != null)
                            {
                                Console.WriteLine("_______________________");
                                Console.WriteLine("Nome: "+auxCandidato.nome);
                                Console.WriteLine("Número: "+auxCandidato.numero);
                                Console.WriteLine("Cargo: "+auxCandidato.cargo);
                                auxCandidato = auxCandidato.prox;
                            }
                            Console.ReadKey();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            op = 0;
                            Console.WriteLine("1 - Consultar Eleitor");
                            Console.WriteLine("2 - Listar todos Eleitores");
                            op = Convert.ToInt32(Console.ReadLine());

                            switch (op)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        op = 0;
                                        Console.WriteLine("1 - Consultar por CPF");
                                        Console.WriteLine("2 - Consultar por Titulo");
                                        op = Convert.ToInt32(Console.ReadLine());

                                        switch (op)
                                        {
                                            case 1:
                                                {
                                                    string cpf;
                                                    Console.Clear();
                                                    Console.Write("Digite o CPF: ");
                                                    cpf = Console.ReadLine();
                                                    auxEleitor = inicioEleitor;
                                                    while (auxEleitor != null)
                                                    {
                                                        if (cpf.Equals(auxEleitor.cpf))
                                                        {
                                                            Console.WriteLine("__________________________________");
                                                            Console.WriteLine("Nome: " + auxEleitor.nome);
                                                            Console.WriteLine("CPF: " + auxEleitor.cpf);
                                                            Console.WriteLine("Titulo: " + auxEleitor.titulo);
                                                            Console.WriteLine("Seção: " + auxEleitor.secao);
                                                            
                                                        }
                                                        auxEleitor = auxEleitor.prox;
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                }

                                            case 2:
                                                {
                                                    int titulo;
                                                    Console.Clear();
                                                    Console.Write("Digite o CPF: ");
                                                    titulo = Convert.ToInt32(Console.ReadLine());
                                                    auxEleitor = inicioEleitor;
                                                    while (auxEleitor != null)
                                                    {
                                                        if (titulo.Equals(auxEleitor.titulo))
                                                        {
                                                            Console.WriteLine("__________________________________");
                                                            Console.WriteLine("Nome: " + auxEleitor.nome);
                                                            Console.WriteLine("CPF: " + auxEleitor.cpf);
                                                            Console.WriteLine("Titulo: " + auxEleitor.titulo);
                                                            Console.WriteLine("Seção: " + auxEleitor.secao);
                                                            
                                                        }
                                                        auxEleitor = auxEleitor.prox;
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            default:
                                                break;
                                        }

                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Lista de todos Eleitores cadastrados:\n");
                                        auxEleitor = inicioEleitor;
                                        while (auxEleitor != null)
                                        {
                                            Console.WriteLine("__________________________________");
                                            Console.WriteLine("Nome: " + auxEleitor.nome);
                                            Console.WriteLine("CPF: " + auxEleitor.cpf);
                                            Console.WriteLine("Titulo: " + auxEleitor.titulo);
                                            Console.WriteLine("Seção: " + auxEleitor.secao);
                                            auxEleitor = auxEleitor.prox;
                                        }
                                        Console.ReadKey();
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Lista de Votos\n");

                            int cont = 0;
                            auxCandidato = inicioCandidato;

                            while (auxCandidato != null)
                            {
                                auxUrna = inicioUrna;
                                Console.WriteLine("Candidato: " + auxCandidato.nome + "\nCargo: " + auxCandidato.cargo);
                                while (auxUrna != null)
                                {
                                    if (auxCandidato.numero.Equals(auxUrna.numeroCandidato))
                                    {
                                        cont++;
                                    }

                                    auxUrna = auxUrna.prox;
                                }
                                Console.WriteLine($"Quantidade de Votos: {cont}");
                                Console.WriteLine("________________________________\n");
                                auxCandidato = auxCandidato.prox;
                                cont = 0;
                            }

                            Console.ReadKey();
                            break;
                        }
                }
            } while (op != 7);
        }
    }
}
