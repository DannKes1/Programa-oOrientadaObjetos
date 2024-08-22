using CadastroFuncionario;
using CadastroFuncionario.dao;
using CadastroFuncionario.Models;
using Org.BouncyCastle.Crypto.Fpe;

try
{
    Conexao.Conectar();
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao conectar" + ex.Message);
}

try
{
    Console.WriteLine("");
    Funcionario funcionario01 = new Funcionario();
    /* CADASTRANDO FUNCIONARIO
     * 
     * Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine("Cadastro de funcionarios");
     Console.ResetColor();

     Console.WriteLine("Digite o nome do funcionario: ");
     funcionario01.Nome = Console.ReadLine();
     Console.WriteLine("Digite o cpf: ");
     funcionario01.Cpf = Console.ReadLine();
     Console.WriteLine("Digite o email: ");
     funcionario01.Email = Console.ReadLine();
     Console.WriteLine("Digite o telefone: ");
     funcionario01.Telefone = Console.ReadLine();
     Console.WriteLine("Digite a data de nascimento: ");*/
    /*    funcionario01.DataNascimento = DateTime.Parse(Console.ReadLine());*/

    FuncionarioDAO f1 = new FuncionarioDAO();
    /*    f1.Insert(funcionario01);*/



    /* CHAMANDO A LISTA */
    List<Funcionario> lista = f1.List();
    foreach (var item in lista)
    {
        Console.WriteLine(item.IdFuncionario +". "+ item.Nome);
    }
    Console.ReadKey();

    /*  DELETANDO ALGUEM DO BANCO DE DADOS*/
    Console.WriteLine("Deseja deletar qual funcionario?");
    var idfunc = Convert.ToInt32(Console.ReadLine());
    f1.Delete(lista.Find(x => idfunc == x.IdFuncionario));
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro!{ex.Message}");
}


