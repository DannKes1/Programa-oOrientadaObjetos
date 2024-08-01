
    public class ContaEmpresarial : Conta
    {
    public double anuidade;
    public double LimiteEmprestimo;
    public double totalEmprestimo;


    public ContaEmpresarial(int nConta, string agencia, string titular, double saldo) : base(nConta, agencia, titular, saldo)
    {

    }
    public void FazerEmprestimo (double valor)
    {
        if (valor <= LimiteEmprestimo)
        {
            LimiteEmprestimo = LimiteEmprestimo - valor;
            totalEmprestimo = valor + Saldo;
            Console.WriteLine("Empréstimo realizado com sucesso");
            Console.WriteLine($"O seu saldo atual é o valor do emprestimo R${valor} + Saldo da sua conta R${Saldo}, ou seja o seu saldo atual é R$ {totalEmprestimo}");
        } 
  

        else
        {
            Console.WriteLine("Você não possui limites para isso");
        }

    }
    public override void Sacar(double valor)
    {
        if (totalEmprestimo > 5000)
        {
            totalEmprestimo = totalEmprestimo - 5;
            Console.WriteLine($"A taxa de emprestimo acima de 5k é de R$ 5,00. O seu emprestimo total é {totalEmprestimo}");
        }

    }

}

