
Funcionario funcionario1 = new Funcionario();
Console.WriteLine("Cadastro de funcionário");
Console.WriteLine("Digite a matricula do funcinario");
funcionario1.matricula = Console.ReadLine();
Console.WriteLine("Digite o nome do funcinario");
funcionario1.nome = Console.ReadLine();
Console.WriteLine("Digite o cpf do funcinario");
funcionario1.cpf = Console.ReadLine();
Console.WriteLine("Digite o salário do funcinario");
funcionario1.salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Funcionario funcionario2 = new Funcionario();
Console.WriteLine("Cadastro de funcionário");
Console.WriteLine("Digite a matricula do funcinario");
funcionario2.matricula = Console.ReadLine();
Console.WriteLine("Digite o nome do funcinario");
funcionario2.nome = Console.ReadLine();
Console.WriteLine("Digite o cpf do funcinario");
funcionario2.cpf = Console.ReadLine();
Console.WriteLine("Digite o salário do funcinario");
funcionario2.salario = Convert.ToDouble(Console.ReadLine());


// maior salario
string funcionarioComMaiorSalario = funcionario1.MaiorSalario(funcionario2);

// Imprimir resultados
Console.WriteLine($"O funcionário com o maior salário é: {funcionarioComMaiorSalario}");