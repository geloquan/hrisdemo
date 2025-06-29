using WinFormsApp2.Context;
using WinFormsApp2.Entities;
using WinFormsApp2.Models;
using WinFormsApp2.Services;

namespace WinFormsApp2.Presenter {
  public class Employee_Presenter : IEmployeeService {
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

    public async Task<List<EmployeeView>> EmployeeViews() {
      return await _employeeService.GetEmployeeViewAsync();
    }

    public async Task<EmployeeView> GetEmployeeByIdAsync(int id) {
      return await _employeeService.GetEmployeeByIdAsync(id);
    }

    public async Task<Employee> CreateEmployeeAsync(Employee employee, int departmentId = 0) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));
       
      return await _employeeService.CreateEmployeeAsync(employee, departmentId);
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

    public Task<List<EmployeeView>> GetEmployeeViewAsync() {
      throw new NotImplementedException();
    }
  }
}