int qtCliente = 0;
int qtPorCliente = 0;

Console.WriteLine("Quantas vendas quer cadastrar ");
qtCliente = Convert.ToInt32(Console.ReadLine());

string[] nomeCliente = new string[qtCliente];
string[][] nomeProduto = new string[qtCliente][];
int[] prodCliente = new int[qtCliente];
double[][] valorProduto = new double[qtCliente][];

for (int i = 0; i < nomeCliente.Length; i++)
{
    Console.WriteLine("Digite o nome do Cliente");
    nomeCliente[i] = Console.ReadLine();
    Console.WriteLine("Quantos Produtos ele deseja comprar");
    qtPorCliente = int.Parse(Console.ReadLine());
    prodCliente[i] = qtPorCliente;
    nomeProduto[i] = new string[qtPorCliente];
    valorProduto[i] = new double[qtPorCliente];

    for (int j = 0; j < prodCliente[i]; j++)
    {
        Console.WriteLine("Nome do produto");
        nomeProduto[i][j] = Console.ReadLine();
        Console.WriteLine("Valor do produto");
        valorProduto[i][j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < nomeCliente.Length; i++)
{
    double somaProduto = 0.00;
    Console.WriteLine("\nNome do Cliente");
    Console.WriteLine(nomeCliente[i]);
    Console.WriteLine("Produtos");
    Console.WriteLine("***************************************");
    for (int j = 0; j < prodCliente[i]; j++)
    {
        Console.Write("\nNome do produto: ");
        Console.Write(nomeProduto[i][j]);
        Console.Write("\nValor do produto: ");
        Console.WriteLine(valorProduto[i][j]);
        somaProduto = somaProduto + valorProduto[i][j];
        Console.Write("O valor total da compra: " + somaProduto);
    }
}