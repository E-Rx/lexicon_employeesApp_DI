using EmployeesApp.Web.Models;


namespace EmployeesApp.Web.Services
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        bool CheckIsVIP(Employee employee);
    }
}
