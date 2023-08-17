using System.Security.Cryptography.X509Certificates;

public class Conta
{
    private string nome;
    private int agencia, conta;
    private double saldo;

    // Get
    public string GetNome()
    {
        return this.nome;
    }

    public int GetAgencia()
    {
        return this.agencia;
    }

    public int GetConta()
    {
        return this.conta;
    }

    public double GetSaldo()
    {
        return this.saldo;
    }

    // Set
    public void SetNome(string nome)
    {
        if (!String.IsNullOrWhiteSpace(nome))
        {
            this.nome = nome;
        }
    }

    public void SetConta(int conta)
    {
        this.conta = conta;
    }

    public void SetAgencia(int agencia)
    {
        this.agencia = agencia;
    }

    public void SetSaldo(double saldo)
    {
        this.saldo = saldo;
    }

    public Conta(string nome, int agencia, int conta, double saldo)
    {
        SetNome(nome);
        SetAgencia(agencia);
        SetConta(conta);
        SetSaldo(saldo);
    }

    public void Depositar(double valor)
    {
        double aux = GetSaldo();
        if (valor > 0)
        {
            aux += valor;
        }
        else
        {
            Console.WriteLine("Valor de incorreto\nVerifique o valor!");
            Console.ReadKey();
        }
    }

    public double Sacar(double valor)
    {
        double aux = GetSaldo();
        if (valor <= aux && valor > 0)
        {
            aux -= valor;
            return aux;
        }
        else
        {
            Console.WriteLine("Salso insuficiente\nVerifique o valor!");
            Console.ReadKey();
            return 0;
        }
    }

    public override string ToString()
    {
        return "Titular: " + GetNome() + ", Conta: " + GetConta() + ", Agência: " + GetAgencia() + ", Saldo: R$" + GetSaldo();
    }
}