using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Company
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "sobre_melquiades_parametro",
                "sobre/{id}/melquiades",
                new { controller = "Home", action = "about", id = 0 }
            );

            routes.MapRoute(
                "sobre",
                "sobre",
                new { controller = "Home", action = "about" }
            );

            routes.MapRoute(
                "empresas",
                "empresas",
                new { controller = "Companys", action = "Index" }
            );

            routes.MapRoute(
                "empresas_criar",
                "empresas/criar",
                new { controller = "Companys", action = "Criar" }
            );

            routes.MapRoute(
                "empresas_novo",
                "empresas/novo",
                new { controller = "Companys", action = "Novo" }
            );

            routes.MapRoute(
                "empresas_editar",
                "empresas/{id}/editar",
                new { controller = "Companys", action = "Editar", id = 0 }
            );

            routes.MapRoute(
                "empresas_alterar",
                "empresas/{id}/alterar",
                new { controller = "Companys", action = "Alterar", id = 0 }
            );

            routes.MapRoute(
                "empresas_excluir",
                "empresas/{id}/excluir",
                new { controller = "Companys", action = "Excluir", id = 0 }
            );

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "contact"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
