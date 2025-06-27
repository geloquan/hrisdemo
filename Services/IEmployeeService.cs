using System.Collections.Generic;
using System.Threading.Tasks;
using WinFormsApp2.Entities;
using WinFormsApp2.Models;

namespace WinFormsApp2.Services
{
    public interface IEmployeeService {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
        Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids);
        Task<int> GetEmployeeCountAsync();
    }
}
