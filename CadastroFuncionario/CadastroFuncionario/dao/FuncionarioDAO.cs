using CadastroFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroFuncionario.Models;
using MySql.Data.MySqlClient;
using System.Runtime.ExceptionServices;
using System.Data;

namespace CadastroFuncionario.dao
{

    internal class FuncionarioDAO
    {
        public void Insert(Funcionario funcionario)
        {
            try
            {
                string dataNascimento = funcionario.DataNascimento.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO funcionarios(Nome, Cpf, Email, Telefone, DataNascimento)" +
                    "VALUES(@nome, @cpf, @email, @telefone, @dataNascimento)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                comando.ExecuteNonQuery();
                Console.WriteLine("Funcionario cadastrado com Sucesso!");

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar o aluno!{ex.Message}");
            }

            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Delete(Funcionario funcionario)
        {
            if (funcionario is null) { 
            throw new Exception($"Erro ao excluir o cliente");
            }
            try
            {

                string sql = "DELETE FROM Funcionarios WHERE IdFuncionario = @IdFuncionario";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);

                comando.ExecuteNonQuery();
                Console.WriteLine("Cliente excluido com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o cliente{ex.Message}");
            }

            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Funcionario> List()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            try
            {
                var sql = "SELECT * FROM funcionarios ORDER BY Nome";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionario funcionario = new Funcionario();
                        funcionario.IdFuncionario = dr.GetInt32("IdFuncionario");
                        funcionario.Nome = dr.GetString("Nome");
                        funcionario.Email = dr.GetString("email");
                        funcionario.Cpf = dr.GetString("Cpf");
                        funcionario.Telefone = dr.GetString("Telefone");
                        funcionario.DataNascimento = dr.GetDateTime("DataNascimento");
                        funcionarios.Add(funcionario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar na lista{ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();

            }
            return funcionarios;
        }
    }
}
