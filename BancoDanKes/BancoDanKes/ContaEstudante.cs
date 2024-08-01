
public class ContaEstudante : Conta
{
    public double LimiteChequeEspecial;
    public string Cpf;
    public string NomeInstituicao;

    public ContaEstudante(int nConta, string agencia, string titular, double saldo) : base(nConta, agencia, titular, saldo)
    {

    }
    public override void Sacar(double valor)
    {
        if (Saldo + LimiteChequeEspecial >= valor)
        {
            Saldo = Saldo - valor;
            Console.WriteLine("Saque realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }

}

