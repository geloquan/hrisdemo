using WinFormsApp2.Entities;

namespace WinFormsApp2.Services {
  public interface IEmployeeService {
    Task<List<Employee>> GetEmployeesAsync();
    Task<EmployeeView> GetEmployeeByIdAsync(int id);
    Task<Employee> CreateEmployeeAsync(Employee employee, int departmentId = 0);
    Task<EmployeeView> UpdateEmployeeAsync(EmployeeView employee, int departmentId = 0);
    Task<bool> DeleteEmployeeAsync(int id);
    Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids);
    Task<int> GetEmployeeCountAsync();
    Task<List<EmployeeView>> GetEmployeeViewAsync();
  }
}
