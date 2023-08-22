public class Program
{
    static void Main(string[] args)
    {
        // Aluno: Wallan Oliveira da Silva
        int op = 10, aux = 10, agencia = 0, conta = 0;
        string nome = "";
        List<Conta> listaConta = new List<Conta>();
        Conta minhaConta = new Conta("", 0, 0, 0.00);

        do
        {
            Console.Clear();
            Console.WriteLine("1 - Cricar um Nova Conta");
            Console.WriteLine("2 - Ja tem uma Conta");
            Console.WriteLine("0 - Sair");
            aux = Convert.ToInt32(Console.ReadLine());

            switch (aux)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Innforme os dados abaixo:");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Conta: ");
                        conta = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Agencia: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        minhaConta = new Conta(nome, agencia, conta, 0.00);

                        listaConta.Add(minhaConta);

                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Informe os dados abaixo:");
                        Console.Write("Conta: ");
                        int auxConta = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Agencia: ");
                        int auxAgencia = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in listaConta)
                        {
                            if (item.conta.Equals(auxConta) && item.agencia.Equals(auxAgencia))
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Olá {item.nome}, o saldo da conta é R${item.saldo}\n");
                                    Console.WriteLine("1 - Depositar");
                                    Console.WriteLine("2 - Sacar");
                                    Console.WriteLine("0 - Sair");
                                    op = Convert.ToInt32(Console.ReadLine());

                                    switch (op)
                                    {
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.Write("Informe o valor para depositar: ");
                                                double deposito = Convert.ToDouble(Console.ReadLine());
                                                item.Depositar(deposito);
                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.Clear();
                                                Console.Write("Informe o valor para sacar: ");
                                                double sacar = Convert.ToDouble(Console.ReadLine());
                                                Console.WriteLine(item.Sacar(sacar));

                                                break;
                                            }
                                    }

                                } while (op != 0);
                            }
                        }
                        break;
                    }
            }
        } while (aux != 0);
    }
}

