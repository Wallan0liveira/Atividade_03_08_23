// 5 colocar o namespace 

using Lista_Revisao;

// 6 criar o tipos de elementos
Eleitor cad = null, inicio = null, lista = null, aux = null;
int op = 1;

// 7 inserir os dados do elemento da lista

do
{
    Console.WriteLine(@"Digite as opcoes
       1 - Para cadastrar
       2 - Para listar todos
       3 - Para consultar um nome especifico
       0 - Para sair");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:

            cad = new Eleitor();

            Console.WriteLine("Digite o nome da pessoa");
            cad.nome = Console.ReadLine();

            // 8 encadear lista

            // 8.1 colocar no inicio da lista
            if (inicio == null)
            {
                // primeiro elemento da lista
                inicio = cad;
                inicio.prox = null;
            }
            else
            {
                // 8.2 colocar no segundo nó da lista
                // ver se a lista tem segundo elemento
                if (inicio.prox == null)
                {
                    lista = cad;
                    inicio.prox = lista;
                    lista.prox = null;
                }
                // 8.3 colocar nos demais nós da lista
                lista.prox = cad;
                lista = cad;
                lista.prox = null;
            }


            break;
        case 2:
            // 9 consultar lista
            aux = inicio;

            // 10 percorrer a lista
            while (aux != null)
            {
                Console.WriteLine(aux.nome);
                aux = aux.prox;
            }

            break;

        case 3:
            // 11 consultar lista por nome
            aux = inicio;

            Console.WriteLine("Digite o nome para buscar na lista");
            string nome = Console.ReadLine();
            bool achou = false;
            

            // 10 percorrer a lista
            while (aux != null)
            {
                string nm = aux.nome.ToLower() ;
                nome = nome.ToLower();
                if (nm.Equals(nome))
                {
                    Console.WriteLine(aux.nome);
                    achou = true;
                    break;
                }
                else
                {
                    achou = false;
                }
                
                aux = aux.prox;
            }

            if (!achou)
            {
                Console.WriteLine("Nao achei nada ");
            }

            break;
        case 0:
            Console.WriteLine("Até mais ");
            break;

        default:
            Console.WriteLine("Digite certo meu filho");
            break;
    }

    



} while (op != 0);

Console.WriteLine("Adeus bagaça");
Console.ReadKey();
