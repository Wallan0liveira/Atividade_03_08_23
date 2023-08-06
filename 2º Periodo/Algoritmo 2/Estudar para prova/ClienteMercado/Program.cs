using ClienteMercado;

// 1 criar o cad, inicio, lista e aux
Cliente cad, inicio = null, lista=null, aux =null;
int qp = 0, op = 0;

// 2 ter do while para fazer varias vezes
do {
    qp = 0;
    // 3 criar nova lista
    cad = new Cliente();
    Console.WriteLine("Digite o nome do Cliente");
    cad.Name = Console.ReadLine();
    Console.WriteLine("Digite o CPF do Cliente");
    cad.cpf = Console.ReadLine();
    Endereco n = new Endereco();
    Console.WriteLine("Digite o Logradouro do Cliente");
    n.logradouro = Console.ReadLine();
    Console.WriteLine("Digite o Bairro do Cliente");
    n.bairro = Console.ReadLine();
    Console.WriteLine("Digite o numero do Cliente");
    n.numero = Console.ReadLine();
    Console.WriteLine("Digite o CEP do Cliente");
    n.cep = Console.ReadLine();
    Console.WriteLine("Digite o Cidade do Cliente");
    n.cidade = Console.ReadLine();
    Console.WriteLine("Digite o Estado do Cliente");
    n.uf = Console.ReadLine();

    // aqui coloco o objeto endereço no endereço do cliente
    cad.end = n;

    Console.WriteLine("Quantos produtos o cliente quer");
    qp = Convert.ToInt32(Console.ReadLine());
    cad.valorproduto = new double[qp];
    cad.nomeproduto = new string[qp];

    for (int i = 0; i < qp; i++)
    {
        Console.WriteLine("Digite o Nome do Produto");
        cad.nomeproduto[i] = Console.ReadLine();
        Console.WriteLine("Digite o Valor do Produto");
        cad.valorproduto[i] = Convert.ToDouble(Console.ReadLine());
    }

    //4 ver se a lista tem inicio
    if (inicio == null)
    {
        // primeiro elemento da lista
        inicio = cad;
        inicio.prox = null;
    }
    else
    {
        //segundo elemento da lista
        //5 ver se a lista tem segundo elemento
        if (inicio.prox == null)
        {
            lista = cad;
            inicio.prox = lista;
            lista.prox = null;
        }
        //6 acrescentar itens da lista
        lista.prox = cad;
        lista = cad;
        lista.prox = null;
    }
    Console.WriteLine("Para cadastrar mais, digite 1");
    Console.WriteLine("Para sair, digite 0");
    op = Convert.ToInt32(Console.ReadLine());

} while (op!=0);

//7 aux para percorrer e mostrar a lista
aux = inicio;
// 8 aux vai até ser nulo
while (aux!= null)
{
    Console.WriteLine("Nome do Cliente");
    Console.WriteLine(aux.Name) ;
    Console.WriteLine("O Endereço do Cliente");
    Console.WriteLine(aux.end.logradouro);
    Console.WriteLine(aux.end.cep);

    for (int i = 0; i < aux.valorproduto.Length; i++)
    {
        Console.WriteLine("Nome do Produto "+ (i+ 1));
        Console.WriteLine(aux.nomeproduto[i]);

        Console.WriteLine("Valor do Produto " + (i + 1));
        Console.WriteLine(aux.valorproduto[i]);
    }
    // 9 o aux recebe o proximo elemento, até ser nulo
    aux = aux.prox;
}

Console.ReadKey();

