using ListaSimplesAluno;
using System.Xml;
// 5 colocar o namespace (using) caso não tenha
// 6 criar os elementos
Aluno novo = null, inicio = null, lista = null, aux = null;
int op = 0;
// 7 inserir os dados do elemento

do
{
    Console.WriteLine(@"Escolha sua opção
        1 - Para Cadastrar
        2 - Para Listar Todos
        3 - Para Consultar um Nome Especifico
        0 - Para Sair");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            {
                novo = new Aluno();
                Console.WriteLine("Digite o Nome do Aluno:");
                novo.nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF do Aluno:");
                novo.cpf = Console.ReadLine();
                Console.WriteLine("Digite a Nota do aluno:");
                novo.notas = Convert.ToDouble(Console.ReadLine());

                // 9 Encadeamento da Lista
                // 9.1 Colocar no Inicio da Lista
                if (inicio == null)
                {
                    inicio = novo;
                    inicio.prox = null;
                }
                else
                {
                    // 9.2 Colocar no 2º nó
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
                // 10 Consultar Lista
                aux = inicio;

                // 11 Percorrer  a lista

                while (aux != null)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine(aux.nome);
                    Console.WriteLine(aux.cpf);
                    Console.WriteLine(aux.notas);
                    aux = aux.prox;

                }
                break;
            }

        case 3:
            {
                Console.WriteLine("Digite um CPF da Lista de Alunos para Consultar");
                string cpf = Console.ReadLine().ToLower();

                aux = inicio;
                // 13 percorre a lista
                while (aux != null)
                {
                    if (cpf.Equals(aux.cpf))
                    { 
                        Console.WriteLine("Sua consulta retornou esses dados:");
                        Console.WriteLine(aux.nome);
                        Console.WriteLine(aux.cpf);
                        Console.WriteLine(aux.notas);
                    }
                    aux = aux.prox;
                }
                break;
            }

        default:
            break;
    }

} while (op != 0);
Console.WriteLine("Final");