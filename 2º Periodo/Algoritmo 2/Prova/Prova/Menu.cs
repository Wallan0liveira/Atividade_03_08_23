using Prova;

int op = 0;
Exercicio exercicio = new Exercicio();
do
{
    Console.Clear();
    Console.WriteLine("Aluno: Wallan Oliveira da Silva\n\n");
    Console.WriteLine(" **************** MENU **************** \n");
    Console.WriteLine("1 - Cadastrar Gado");
    Console.WriteLine("2 - Consultar");
    Console.WriteLine("3 - Listar Todos");
    Console.WriteLine("4 - Quantidade de animais por sexo");
    Console.WriteLine("5 - Valor do animal");
    Console.WriteLine("0 - Saír");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            {
                exercicio.AdicionarLista();
                break;
            }

        case 2:
            {
                exercicio.Consultar();
                break;
            }

        case 3:
            {
                exercicio.TodosElementos();
                break;
            }

        case 4:
            {
                exercicio.ConsultaPorSexo();
                break;
            }

        case 5:
            {
                exercicio.ValorAnimal();
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