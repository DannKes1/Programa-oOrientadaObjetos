
public class Conta
{
    public int nConta;
    public string Agencia;
    public string Titular;
    protected double Saldo;

    public Conta(int nConta, string agencia, string titular, double saldo)
    {
        this.nConta = nConta;
        Agencia = agencia;
        Titular = titular;
        Saldo = saldo;
    }

    

    public virtual void Sacar(double valor) 
    {
       if (valor <= Saldo)
        {
            Saldo = Saldo - valor;
            Console.WriteLine($"Você sacou R$ {valor} o seu saldo é R${Saldo}");
   
        }
        else
        {
            Console.WriteLine($"Você não possui saldo suficiente, o seu saldo em conta é R${Saldo}");
        }

    }

    public virtual void Depositar(double valor) 
    {
        Saldo = Saldo + valor;
        Console.WriteLine($"O seu saldo em conta agora é R${Saldo}");
    }

    }

