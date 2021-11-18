﻿using Alura.ListaLeitura.App.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;


namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // injeta roteamento
            services.AddRouting();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {

            app.UseMvcWithDefaultRoute();
      
        }

       
        


    }
}