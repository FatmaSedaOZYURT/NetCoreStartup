using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //E�er Controller arac�l���yla servisimizi y�neteceksek, servisimize bunu eklememiz gerekmektedir.
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region Yaz�l�mc�ya detayl� hata f�rlatmak
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            #endregion
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //Art�k route lar controller lar arac�l���yla olu�acak. Bu �ekilde bunu s�ylemi� oluyoruz.
                endpoints.MapControllers();
            });
        }
    }
}
