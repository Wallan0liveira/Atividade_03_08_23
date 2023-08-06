using Lista;

Pessoa cad, novo, lista, inicio = null;

cad = new Pessoa();

Console.WriteLine("Digite o nome da Pessoa");
cad.nome = Console.ReadLine();
Console.WriteLine("Digite o email da Pessoa");
cad.email = Console.ReadLine();

Console.WriteLine("Digite o idade da Pessoa");
cad.idade = Convert.ToInt32(Console.ReadLine());

novo = cad;

Console.WriteLine("O nome da pessoa é: " + cad.nome);

if (inicio == null)
{
    inicio = cad;
}



