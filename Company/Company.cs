using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Company
    {
        public string CNPJ { get; set; }
        public List<Company> Companys(string company)
        {
            var companys = new List<Company>();
            companys.Add(new Company() { CNPJ = "1234567890" });
            return companys;
        }
    }
}
