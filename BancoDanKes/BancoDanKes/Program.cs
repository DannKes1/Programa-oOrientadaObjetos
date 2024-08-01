

Console.WriteLine("Digite o número da conta: ");
int nConta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o número da agência: ");
string Agencia = Console.ReadLine();
Console.WriteLine("Digite o nome do titular da conta: ");
string Titular = Console.ReadLine();
Console.WriteLine("Qual o saldo você tem na conta? ");
double Saldo = Convert.ToDouble(Console.ReadLine());

Conta daniel = new Conta(nConta, Agencia, Titular, Saldo);

Console.WriteLine("Qual valor você deseja sacar? ");
double valor = Convert.ToDouble(Console.ReadLine());
daniel.Sacar(valor);

Console.WriteLine("Qual valor você deseja depositar? ");
double deposito = Convert.ToDouble(Console.ReadLine());
daniel.Depositar(deposito);


Console.Clear();

Console.WriteLine("Digite o número da conta: ");
int ContaPJ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o número da agência: ");
string AgenciaPJ = Console.ReadLine();
Console.WriteLine("Digite o nome do titular da conta: ");
string TitularPJ = Console.ReadLine();
Console.WriteLine("Qual o saldo você tem na conta? ");
double SaldoPJ = Convert.ToDouble(Console.ReadLine());


ContaEmpresarial Gontijo = new ContaEmpresarial(ContaPJ, AgenciaPJ, TitularPJ, SaldoPJ);

Console.WriteLine("Qual valor você do empréstimo a ser realizado? ");
double emprestimo = Convert.ToDouble(Console.ReadLine());
Gontijo.FazerEmprestimo(emprestimo);

Console.WriteLine("Qual valor do limite do emprestimo? ");
Gontijo.LimiteEmprestimo = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Qual valor você deseja sacar da sua conta empresarial?");
double SaqueEmpresarial = Convert.ToDouble(Console.ReadLine());
Gontijo.Sacar(SaqueEmpresarial);

Console.Clear();


Console.WriteLine("Digite o número da conta: ");
int ContaEstudante = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o número da agência: ");
string AgenciaEstudante = Console.ReadLine();
Console.WriteLine("Digite o nome do titular da conta: ");
string TitularEstudante = Console.ReadLine();
Console.WriteLine("Qual o saldo você tem na conta? ");
double SaldoEstudante = Convert.ToDouble(Console.ReadLine());

ContaEstudante Estudante01 = new ContaEstudante (ContaEstudante, AgenciaEstudante, TitularEstudante, SaldoEstudante);

Console.WriteLine("Qual o cpf do esudante?");
Estudante01.Cpf = Console.ReadLine();

Console.WriteLine("Qual o nome da Instituição de ensino? ");
Estudante01.NomeInstituicao = Console.ReadLine();

Console.WriteLine("Qual valor o estudante deseja sacar? ");
double saqueEstudante = Convert.ToDouble(Console.ReadLine());
Estudante01.Sacar(saqueEstudante);
