using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Company.Controllers
{
    public class CompanysController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Companys = new Company().List();

            return View();
        }

        public ActionResult Novo()
        {

            return View();
        }

        [HttpPost]
        public void Criar()
        {
            DateTime dataConvertida;
            DateTime.TryParse(Request["data_cadastro"], out dataConvertida);
            
            var company = new Company();
            company.CNPJ = Request["cnpj"];
            company.NomeFantasia = Request["nome_fantasia"];
            company.Telefone = Request["telefone"];
            company.Email = Request["email"];
            company.DataCadastro = dataConvertida;

            company.Save();

            Response.Redirect("/empresas");
        }

        public void Excluir(int id)
        {
            Company.Excluir(id);

            Response.Redirect("/empresas");
        }

        public ActionResult Editar(int id)
        {
            var company = Company.BuscarId(id);
            ViewBag.Company = company;
            return View();
        }

        [HttpPost]
        public void Alterar(int id)
        {
            try
            {
                var company = Company.BuscarId(id);

                DateTime dataConvertida;
                DateTime.TryParse(Request["data_cadastro"], out dataConvertida);

                company.CNPJ = Request["cnpj"];
                company.NomeFantasia = Request["nome_fantasia"];
                company.Telefone = Request["telefone"];
                company.Email = Request["email"];
                company.DataCadastro = dataConvertida;

                company.Save();

                TempData["sucesso"] = "Empresa alterada com sucesso!";
            }
            catch
            {
                TempData["erro"] = "Empresa não pode ser alterada!";
            }

            Response.Redirect("/empresas");
        }
    }
}