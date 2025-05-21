using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class OtherEmployeeService : IEmployeeService
    {
        List<Employee> employees =
        [
            new Employee()
            {
                Id = 568,
                Name = "Louis Pottier",
                Email = "l.pottier@mail.com",
            },
            new Employee()
            {
                Id = 66,
                Name = "Stephane Maurand",
                Email = "admin.stef@mail.com",
            },
            
            new Employee()
            {
                Id = 444,
                Name = "Caroline Joly",
                Email = "caro.j@mail.com"
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];


        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
    }
}
