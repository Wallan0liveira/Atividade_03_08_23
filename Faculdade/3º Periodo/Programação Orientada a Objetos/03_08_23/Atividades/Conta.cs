public class Conta
{
    public string nome;
    public int agencia, conta;
    public double saldo;

    public Conta(string nome, int agencia, int conta, double saldo)
    {
        this.nome = nome;
        this.agencia = agencia;
        this.conta = conta;
        this.saldo = saldo;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
        else
        {
            Console.WriteLine("Valor de deposito Negativo");
            Console.ReadKey();
        }
    }

    public double Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Salso insuficiente");
            Console.ReadKey();
        }

        return saldo;
    }
}