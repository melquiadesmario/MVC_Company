using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Page
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Page> List()
        {
            var list = new List<Page>();
            var pageDB = new Database.Page();
            
            foreach(DataRow row in pageDB.List().Rows)
            {
                var page = new Page();

                page.Id = Convert.ToInt32(row["id"]);
                page.CNPJ = row["cnpj"].ToString();
                page.NomeFantasia = row["nome_fantasia"].ToString();
                page.Telefone = row["telefone"].ToString();
                page.Email = row["email"].ToString();
                page.DataCadastro = Convert.ToDateTime(row["data_cadastro"]);

                list.Add(page);
            }

            return list;
        }
    }
}
