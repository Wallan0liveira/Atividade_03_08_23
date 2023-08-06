using Atividade;

int op = 0;
do
{
    Console.Clear();
    Console.WriteLine("************  MENU PRINCIPAL  ************\n");
    Console.WriteLine("1 - Exercicio 1");
    Console.WriteLine("2 - Exercicio 2");
    Console.WriteLine("3 - Exercicio 3");
    Console.WriteLine("4 - Saír\n");
    Console.Write("Digite uma opção: ");
    op = Convert.ToInt32(Console.ReadLine());


    switch (op)
    {
        case 1:
            {
                Exercicio1 exercicio1 = new Exercicio1();
                exercicio1.MenuExercicio1();
                break;
            }

        case 2:
            {
                Exercicio2 exercicio2 = new Exercicio2();
                exercicio2.MenuExercico2();
                break;
            }
        case 3:
            {
                Exercicio3 exercicio3 = new Exercicio3();
                exercicio3.MenuExercicio3();
                break;
            }
        default:

            break;
    }
} while (op != 4);