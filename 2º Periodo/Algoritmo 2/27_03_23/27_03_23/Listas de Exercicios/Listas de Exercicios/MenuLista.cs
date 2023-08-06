using Listas_de_Exercicios;// pucha as funções da aba MinhaBlibioteca

int opcao;
do
{
    Console.Clear();
    Console.WriteLine("Aluno: Wallan Oliveira da Silva\n");
    Console.WriteLine("Escolha uma opção abaixo:");
    Console.WriteLine("1 - Lista de Exercícios 1 (6.4)");
    Console.WriteLine("2 - Lista de Exercícios 2 (7.7)");
    Console.WriteLine("3 - Area de testes");
    Console.WriteLine("0 - Para sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                MenuExercicio Lista1 = new MenuExercicio();
                Lista1.Lista1();
                break;
            }

        case 2:
            {
                MenuExercicio Lista2 = new MenuExercicio();
                Lista2.Lista2();
                break;
            }
        case 3:
            {
                teste teste = new teste();
                teste.funcaoTeste();
                break;
            }

        case 0:
            {
                Console.WriteLine("Até Mais!");
                break;
            }
        default:
            Console.Clear();
            break;
    }
} while (opcao != 0);