using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace RMMSA.WebAPI.Fornecedores
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Removendo retorno formato XML
            //config.Formatters.Remove(config.Formatters.XmlFormatter);


            config.Formatters.JsonFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("tipo", "json", "applicatiion/json"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //routeTemplate: "api/{controller}/{id}",
                routeTemplate: "ServicoWebAPI/{controller}/{Action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
