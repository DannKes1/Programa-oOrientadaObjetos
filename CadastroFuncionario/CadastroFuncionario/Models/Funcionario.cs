
using System.Runtime.CompilerServices;

namespace CadastroFuncionario.Models
{
    internal class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
