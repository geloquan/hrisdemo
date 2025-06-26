using Microsoft.EntityFrameworkCore;
using WinFormsApp2.Context;
using WinFormsApp2.Entities;
using WinFormsApp2.Models;

namespace WinFormsApp2.Services {
  public class EmployeeService : IEmployeeService {
    private readonly MyDbContext _context;

    public EmployeeService(MyDbContext context) {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<PaginatedList<Employee>> GetEmployeesAsync(int pageIndex = 1, int pageSize = 10) {
      var totalCount = await GetEmployeeCountAsync();
      var items = await GetEmployeesPagedAsync(pageIndex, pageSize);
      return new PaginatedList<Employee>(items, totalCount, pageIndex, pageSize);
    }

    public async Task<int> GetEmployeeCountAsync() {
      return await _context.Employees.CountAsync();
    }

    public async Task<List<Employee>> GetEmployeesPagedAsync(int pageIndex, int pageSize) {
      return await _context.Employees
          .OrderBy(e => e.Id) // Ensure deterministic pagination
          .Skip((pageIndex - 1) * pageSize)
          .Take(pageSize)
          .ToListAsync();
    }
    public async Task<Employee> GetEmployeeByIdAsync(int id) {
      return await _context.Employees
          .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<Employee> CreateEmployeeAsync(Employee employee) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));

      await _context.Employees.AddAsync(employee);
      await _context.SaveChangesAsync();
      return employee;
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));

      var existingEmployee = await _context.Employees.FindAsync(employee.Id);
      if (existingEmployee == null)
        return null;

      _context.Entry(existingEmployee).CurrentValues.SetValues(employee);
      await _context.SaveChangesAsync();
      return existingEmployee;
    }

    public async Task<bool> DeleteEmployeeAsync(int id) {
      var employee = await _context.Employees.FindAsync(id);
      if (employee == null)
        return false;

      _context.Employees.Remove(employee);
      await _context.SaveChangesAsync();
      return true;
    }

    public async Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids) {
      if (ids == null || !ids.Any())
        return false;

      var employees = await _context.Employees
          .Where(e => ids.Contains(e.Id))
          .ToListAsync();

      if (!employees.Any())
        return false;

      _context.Employees.RemoveRange(employees);
      await _context.SaveChangesAsync();
      return true;
    }
  }
}
