using MySql.Data.MySqlClient;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace CadastroFuncionario
{
    /*classes staticas não criamos objetos, somente metodos.
    esses metodos podemos utilizar em qualquer lugar, por exemplo: um validador de cpf. Ele sempre vai ser algo padrão para todos*/
    public static class Conexao
    {

        static MySqlConnection conexao; // atributo responsavel por controlar a conexao com a base

        public static MySqlConnection Conectar()
        {
            try
            {
                string strconexao = "server=localhost;port=3360;uid=root;pwd=root;database=CadastroFuncionario";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar" + ex.Message);
            }
            return conexao;
        }
        public static void FecharConexao()
        {
            conexao.Close();
        }

    }

}