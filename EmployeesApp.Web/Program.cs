using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<EmployeeService>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();

            //test
        }
    }
}