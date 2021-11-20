using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Formas diferentes de gerar services que criam instancias
            // tempos de vida diferentes

            // Objetos transit�rios s�o sempre diferentes,
            // // uma nova inst�ncia � fornecida cada vez que o objeto � solicitado.
            //services.AddTransient<ICatalogo, Catalogo>();
            //services.AddTransient<IRelatorio, Relatorio>();

            // Objetos com escopo s�o os mesmos em uma requisi��es,
            // mas diferentes entre requisi��es diferentes.
            //services.AddScoped<ICatalogo, Catalogo>();
            //services.AddScoped<IRelatorio, Relatorio>();

            //Objetos singleton s�o os mesmos para todas as requisi��es.
            var catalogo = new Catalogo();
            services.AddSingleton<ICatalogo>(catalogo);
            services.AddSingleton<IRelatorio>(new Relatorio(catalogo));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            ICatalogo catalogo = serviceProvider.GetService <ICatalogo>();
            IRelatorio relatorio = serviceProvider.GetService<IRelatorio>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await relatorio.Imprimir(context);

                });
            });
        }
    }
}
