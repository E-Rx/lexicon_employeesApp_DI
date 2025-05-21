using EmployeesApp.Web.Services;
using TonProjet.Filters;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<MyLogFilterAttribute>();
            });

            builder.Services.AddScoped<MyLogFilterAttribute>();

            builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllers();
            app.Run();

            //test
        }
    }
}