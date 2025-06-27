using WinFormsApp2.Context;
using WinFormsApp2.Entities;
using WinFormsApp2.Models;
using WinFormsApp2.Services;

namespace WinFormsApp2.Presenter {
  public class Employee_Presenter {
    private readonly IEmployeeService _employeeService;

    public Employee_Presenter() {
      var dbContext = new MyDbContext();
      _employeeService = new EmployeeService(dbContext);
    }

    public Employee_Presenter(IEmployeeService employeeService) {
      _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
    }

    public async Task<List<Employee>> GetEmployeesAsync() {
      return await _employeeService.GetEmployeesAsync();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id) {
      return await _employeeService.GetEmployeeByIdAsync(id);
    }

    public async Task<Employee> CreateEmployeeAsync(Employee employee) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));

      return await _employeeService.CreateEmployeeAsync(employee);
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));

      return await _employeeService.UpdateEmployeeAsync(employee);
    }

    public async Task<bool> DeleteEmployeeAsync(int id) {
      return await _employeeService.DeleteEmployeeAsync(id);
    }

    public async Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids) {
      return await _employeeService.DeleteEmployeesAsync(ids);
    }

    public async Task<int> GetEmployeeCountAsync() {
      return await _employeeService.GetEmployeeCountAsync();
    }
  }
}