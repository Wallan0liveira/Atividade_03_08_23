namespace ListaSimplesAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 colocar namespace
            // 6 criar os elementos
           Aluno novo = null, inicio = null,
                lista = null, aux = null;
            int op = 0;
            // 7 inserir os dados do elemento
            do
            {
                Console.WriteLine(@"Escolhe sua opção
                    1 - Para Cadastrar
                    2 - Para Listar todos
                    3 - Para Consultar um nome especifico
                    0 - Para Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        // 8 dados dos alunos
                        novo = new Aluno();

                        Console.WriteLine("Digite o nome do aluno");
                        novo.nome = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do aluno");
                        novo.cpf = Console.ReadLine();
                        Console.WriteLine("Digite nota  do aluno");
                        novo.notas = Convert.ToDouble(Console.ReadLine());

                        //9 encadeamento da lista
                        // 9.1 colocar no inicio da lista
                        if (inicio == null)
                        {
                            inicio = novo;
                            inicio.prox = null;
                        }
                        else
                        {
                            // 9.2 colocar no 2 nó
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
                    case 2:
                        // 10 consultar lista
                        aux = inicio;

                        // 11 percorrer a lista
                        while (aux != null)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine( aux.nome );
                            Console.WriteLine( aux.cpf );
                            Console.WriteLine( aux.notas );
                            aux = aux.prox;
                        }
                        break;                    
                    
                    default:
                        break;
                }

            } while (op != 0);

        }
    }
}