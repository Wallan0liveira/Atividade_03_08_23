namespace Listas_de_Exercicios
{
    internal class Lista1Exercicios
    {
        Biblioteca biblioteca = new Biblioteca();// Minha biblioteca (GLOBAL)
        public void Lista1Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("\n* Esse programa mostra quantos dias e temperatura esteve acima da média na semana\n");
            double soma = 0, media, contador = 0;
            double[] diaTemperatura = new double[7];

            Console.WriteLine("");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Digite a temperatura do dia {i + 1}: ");
                diaTemperatura[i] = Convert.ToInt32(Console.ReadLine());
                soma += diaTemperatura[i];
            }

            media = biblioteca.FuncaoMediaVetor(diaTemperatura);

            Console.WriteLine("");

            for (int i = 0; i < 7; i++)
            {
                if (diaTemperatura[i] > media)
                {
                    Console.WriteLine($"O dia {i + 1} teve uma temperatura maior que a média da semana!");
                    contador++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"A soma dos valores é: {soma}\n");
            Console.WriteLine($"A media dos valores é: {media}\n");
            Console.WriteLine($"Quantidade de dia(s) que ficou com a temperatura acima de média semanal: {contador}");
            Console.ReadKey();
        }

        public void Lista1Exercicio2()
        {
            Console.Clear();
            string opcao;
            Console.WriteLine("Escolha o exercicio abaixo:");
            Console.WriteLine("A - Exercicio de letra 'A' (As vogais do alfabeto)");
            Console.WriteLine("B - Exercicio de letra 'B' (A altura de um grupo de dez pessoas)");
            Console.WriteLine("C - Exercicio de letra 'C' (O nome dos meses do ano)");
            opcao = Console.ReadLine().ToUpper();

            switch (opcao)
            {
                case "A":
                    {
                        string[] letra = new string[5];
                        string[] vogal = new string[5];

                        Console.WriteLine("Digite uma letra:");
                        letra[0] = Console.ReadLine().ToUpper();

                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine("Digite outra letra:");
                            letra[i] = Console.ReadLine().ToUpper();
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            switch (letra[i])
                            {
                                case "A":
                                    {
                                        Console.WriteLine($"As vogais digitadas é: {letra[i]}");
                                        vogal[i] = letra[i];
                                        break;
                                    }
                                case "E":
                                    {
                                        Console.WriteLine($"As vogais digitadas é: {letra[i]}");
                                        vogal[i] = letra[i];
                                        break;
                                    }
                                case "I":
                                    {
                                        Console.WriteLine($"As vogais digitadas é: {letra[i]}");
                                        vogal[i] = letra[i];
                                        break;
                                    }
                                case "O":
                                    {
                                        Console.WriteLine($"As vogais digitadas é: {letra[i]}");
                                        vogal[i] = letra[i];
                                        break;
                                    }
                                case "U":
                                    {
                                        Console.WriteLine($"As vogais digitadas é: {letra[i]}");
                                        vogal[i] = letra[i];
                                        break;
                                    }
                                default:
                                    break;
                            }
                        }

                        Console.WriteLine("");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"A letras digitadas é: {letra[i]}");
                        }
                        Console.ReadKey();
                        break;
                    }

                case "B":
                    {
                        double[] altura = new double[10];

                        Console.WriteLine("Digite a altura da primeira pessoa:");
                        altura[0] = Convert.ToDouble(Console.ReadLine());

                        for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine("Digite a altura da próxima pessoa:");
                            altura[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"A altura da {i}º pessoa digitada é {altura[i]}");
                        }

                        Console.ReadKey();
                        break;
                    }
                default:
                    break;

                case "C":
                    {
                        string[] meses = new string[12];

                        for (int i = 0; i < 12; i++)
                        {
                            Console.WriteLine($"Digite o {i+1}º Mês:");
                            meses[i] = Console.ReadLine();
                        }

                        Console.WriteLine("");

                        for (int i = 0; i < 12; i++)
                        {
                            Console.WriteLine($"Os {i + 1}º mese digitado é: {meses[i]}");
                        }
                        Console.ReadKey();
                        break;
                    }
            }
        }

        public void Lista1Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("\n* Histograma para variação de temperatura durante a semana\n");

            double[] temperatura = new double[7];
            string[] dia = new string[7];
            dia[0] = "Segunda-Feira";
            dia[1] = "Terça-Feira";
            dia[2] = "Quarta-Feira";
            dia[3] = "Quinta-Feira";
            dia[4] = "Sexta-Feira";
            dia[5] = "Sábado";
            dia[6] = "Domingo";

            Console.WriteLine("Digte a temperatura de Segunda-Feira:");
            temperatura[0] = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"Digte a temperatura de {dia[i]}:");
                temperatura[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"A temperatura no dia de {dia[i]} é de: {temperatura[i]}ºC");
            }

            Console.WriteLine("");

            char a = '\u25A0';

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            Console.Write(dia[i] + ": ");
                            break;
                        }
                    case 1:
                        {
                            Console.Write(dia[i] + ":   ");
                            break;
                        }
                    case 2:
                        {
                            Console.Write(dia[i] + ":  ");
                            break;
                        }
                    case 3:
                        {
                            Console.Write(dia[i] + ":  ");
                            break;
                        }
                    case 4:
                        {
                            Console.Write(dia[i] + ":   ");
                            break;
                        }
                    case 5:
                        {
                            Console.Write(dia[i] + ":        ");
                            break;
                        }
                    case 6:
                        {
                            Console.Write(dia[i] + ":       ");
                            break;
                        }
                    default:
                        break;
                }

                for (int j = 0; j < temperatura[i]; j++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        public void Lista1Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("\n* Cria 2 vetores A e B para pegar os valores e depois cria outro vetor C que mostra a soma dos vetores A e B");
            double[] vetorA = new double[10];
            double[] vetorB = new double[10];
            double[] vetorC = new double[10];
            double[] aux = new double[10];

            Console.WriteLine("\nDidite os 10 valores do Vetor A:\n");
            for (int i = 0; i < 10; i++)// pega os valores do vetor A
            {
                Console.WriteLine($"Digite o {i + 1}º valor do Vetor A");
                vetorA[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nDidite os 10 valores do Vetor B:\n");
            for (int i = 0; i < 10; i++)// pega os valores do vetor B
            {
                Console.WriteLine($"Digite o {i + 1}º valor do Vetor B");
                vetorB[i] = Convert.ToDouble(Console.ReadLine());
            }

            vetorC = biblioteca.FuncaoVetoresSoma(vetorA, vetorB);
            biblioteca.FuncaoVetorOrdenar(vetorC);

            Console.WriteLine("\n****************************\nSoma Vetor C ordenado:");
            for (int i = 0; i < vetorC.Length; i++)
            {
                    Console.WriteLine(vetorC[i]);
            }
            Console.ReadKey();
        }

        public void Lista1Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("\n* Cria 2 vetores A e B para pegar os valores e depois cria outro vetor C que mostra a união dos vetores A e B");
            double[] vetorA = new double[10];
            double[] vetorB = new double[10];
            double[] vetorC = new double[20];
            double[] aux = new double[20];

            Console.WriteLine("\nDidite os 10 valores do Vetor A:\n");
            for (int i = 0; i < 10; i++)// pega os valores do vetor A
            {
                Console.WriteLine($"Digite o {i + 1}º valor do Vetor A");
                vetorA[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nDidite os 10 valores do Vetor B:\n");
            for (int i = 0; i < 10; i++)// pega os valores do vetor B
            {
                Console.WriteLine($"Digite o {i + 1}º valor do Vetor B");
                vetorB[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)// cria outro vetor "C" e pega os valores dos vetores A e B.
            {
                if (i < 10)
                {
                    vetorC[i] = vetorA[i];
                }
                if (i > 9)
                {
                    vetorC[i] = vetorB[i - 10];
                }
            }

            biblioteca.FuncaoVetorOrdenar(vetorC);

            Console.WriteLine("\n****************************\nResultado do Vetor C ordenado:");
            for (int i = 0; i < vetorC.Length; i++)
            {
                Console.WriteLine(vetorC[i]);
            }
            Console.ReadKey();
        }
    }
}