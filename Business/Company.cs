using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Company
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Company> List()
        {
            var list = new List<Company>();
            var companyDB = new Database.Company();

            foreach (DataRow row in companyDB.List().Rows)
            {
                var company = new Company();

                company.Id = Convert.ToInt32(row["id"]);
                company.CNPJ = row["cnpj"].ToString();
                company.NomeFantasia = row["nome_fantasia"].ToString();
                company.Telefone = row["telefone"].ToString();
                company.Email = row["email"].ToString();
                company.DataCadastro = Convert.ToDateTime(row["data_cadastro"]);

                list.Add(company);
            }

            return list;
        }

        public static Company BuscarId(int id)
        {
            var company = new Company();
            var companyDB = new Database.Company();

            foreach (DataRow row in companyDB.BuscarId(id).Rows)
            {
                company.Id = Convert.ToInt32(row["id"]);
                company.CNPJ = row["cnpj"].ToString();
                company.NomeFantasia = row["nome_fantasia"].ToString();
                company.Telefone = row["telefone"].ToString();
                company.Email = row["email"].ToString();
                company.DataCadastro = Convert.ToDateTime(row["data_cadastro"]);
            }

            return company;
        }

        public void Save()
        {
            new Database.Company().Salvar(this.Id, this.CNPJ, this.NomeFantasia, this.Telefone, this.Email, this.DataCadastro);
        }

        public static void Excluir(int id)
        {
            new Database.Company().Excluir(id);
        }
    }
}