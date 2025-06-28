using WinFormsApp2.Entities;

namespace WinFormsApp2.Services {
  public interface IEmployeeService {
    Task<List<Employee>> GetEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(int id);
    Task<Employee> CreateEmployeeAsync(Employee employee, int departmentId = 0);
    Task<Employee> UpdateEmployeeAsync(Employee employee);
    Task<bool> DeleteEmployeeAsync(int id);
    Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids);
    Task<int> GetEmployeeCountAsync();
    Task<List<EmployeeView>> GetEmployeeViewAsync();
  }
}
