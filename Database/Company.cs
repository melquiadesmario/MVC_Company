using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Company
    {
        private string sqlConn()
        {
            return ConfigurationManager.AppSettings["sqlConn"];
        }

        public DataTable List()
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {
                string queryString = "select * from companys";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void Salvar(int id, string cnpj, string nomeFantasia, string telefone, string email, DateTime dataCadastro)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {
                string queryString = "insert into companys(cnpj, nome_fantasia, telefone, email, data_cadastro) values('" + cnpj +"', '" + nomeFantasia +"', '" + telefone +"', '" + email +"', '" + dataCadastro +"')";

                if(id != 0)
                {
                    queryString = "update companys set cnpj='" + cnpj +"', nome_fantasia='" + nomeFantasia +"', telefone='" + telefone +"', email='" + email +"', data_cadastro='" + dataCadastro +"' where id=" + id;
                }

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {
                string queryString = "delete from companys where id=" + id;

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable BuscarId(int id)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {
                string queryString = "select * from companys where id=" + id;
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
