using WinFormsApp2.Context;
using WinFormsApp2.Entities;
using WinFormsApp2.Models;
using WinFormsApp2.Services;

namespace WinFormsApp2.Presenter {
  public class Employee_Presenter {
    private readonly IEmployeeService _employeeService;

    private int _currentPage = 1;
    private const int PageSize = 10;

    public Employee_Presenter() {
      var dbContext = new MyDbContext();
      _employeeService = new EmployeeService(dbContext);
    }

    public Employee_Presenter(IEmployeeService employeeService) {
      _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
    }

    public async Task<PaginatedList<Employee>> GetEmployeesAsync(int page = 1, int pageSize = PageSize) {
      _currentPage = page;
      return await _employeeService.GetEmployeesAsync(page, pageSize);
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
    public async Task<List<Employee>> GetEmployeesPagedAsync(int pageIndex, int pageSize) {
      return await _employeeService.GetEmployeesPagedAsync(pageIndex, pageSize);
    }

    public async Task<PaginatedList<Employee>> GetNextPageAsync() {
      var currentResult = await GetEmployeesAsync(_currentPage);
      if (!currentResult.HasNextPage)
        return null;

      return await GetEmployeesAsync(_currentPage + 1);
    }

    public async Task<PaginatedList<Employee>> GetPreviousPageAsync() {
      if (_currentPage <= 1)
        return null;

      return await GetEmployeesAsync(_currentPage - 1);
    }
  }
}