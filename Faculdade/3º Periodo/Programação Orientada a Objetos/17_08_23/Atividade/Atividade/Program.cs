Console.Write("Informe o CPF:");
string cpf = Console.ReadLine();

bool test = Validacoes.ValidaCPF(cpf);

Console.WriteLine($"O CPF é: {test}");