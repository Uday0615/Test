using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bookstore.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services here
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            // TODO: Implement logging configuration
            // LoggingSetup.ConfigureLogging();

            // TODO: Implement configuration setup
            // ConfigurationSetup.ConfigureConfiguration();

            // TODO: Implement dependency injection setup
            // DependencyInjectionSetup.ConfigureDependencyInjection(app);

            // TODO: Implement authentication configuration
            // AuthenticationConfig.ConfigureAuthentication(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}