using System.Data;
using System.Data.SqlClient;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionaCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection())
            {
                var commando = new SqlCommand();

                connection.ConnectionString = "MinhaConnectionString";
                commando.Connection = connection;
                commando.CommandType = CommandType.Text;
                commando.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                commando.Parameters.AddWithValue("nome", cliente.Nome);
                commando.Parameters.AddWithValue("email", cliente.Email);
                commando.Parameters.AddWithValue("cpf", cliente.Cpf);
                commando.Parameters.AddWithValue("dataCad", cliente.DataCadastro);

                connection.Open();
                commando.ExecuteNonQuery();
            }
        }
    }
}
