using System;
using System.IO;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.SelfHost;


namespace ConsolePrinter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration(
                "http://192.168.1.105:60064");
            config.Routes.MapHttpRoute(
                name: "API",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new {id = RouteParameter.Optional});
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.Write("Web Api is Started Now.");
                Console.ReadLine();
            }
        }
    }
}
        
        
        
        
        
        
        
        
