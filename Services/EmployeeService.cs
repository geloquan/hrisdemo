using Microsoft.EntityFrameworkCore;
using WinFormsApp2.Context;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Services {
  public class EmployeeService : IEmployeeService {
    private readonly MyDbContext _context;

    public EmployeeService(MyDbContext context) {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<List<Employee>> GetEmployeesAsync( ) {
      // Exclude soft-deleted records
      return await _context.Employees
          .Where(e => e.DeleteAt == null)
          .ToListAsync();
    }

    public async Task<List<EmployeeView>> GetEmployeeViewAsync( ) {
      // Assuming EmployeeView includes a DeleteAt property
      return await _context.EmployeeViews
          .ToListAsync();
    }

    public async Task<int> GetEmployeeCountAsync( ) {
      return await _context.Employees
          .CountAsync(e => e.DeleteAt == null);
    }

    public async Task<EmployeeView> GetEmployeeByIdAsync(int id) {
      return await _context.EmployeeViews
          .FirstOrDefaultAsync(e => e.EmployeeId == id);
    }

    public async Task<Employee> CreateEmployeeAsync(Employee employee, int departmentId = 0) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));

      await _context.Employees.AddAsync(employee);
      await _context.SaveChangesAsync();

      if (departmentId != 0) {
        _context.EmployeeDepartments.Add(new EmployeeDepartment {
          DepartmentId = departmentId,
          EmployeeId = employee.Id
        });

        await _context.SaveChangesAsync();
      }

      return employee;
    }

    public async Task<EmployeeView> UpdateEmployeeAsync(EmployeeView employee, int departmentId = 0) {
      if (employee == null)
        throw new ArgumentNullException(nameof(employee));

      var existingEmployee = await _context.Employees.FindAsync(employee.EmployeeId);
      if (existingEmployee == null || existingEmployee.DeleteAt != null)
        return null;

      _context.Entry(existingEmployee).CurrentValues.SetValues(new {
        Id = employee.EmployeeId,
        FullName = employee.EmployeeFullName,
        EmployeeCode = employee.EmployeeGenerateCode,
        DateOfBirth = employee.EmployeeDateOfBirth
      });

      await _context.SaveChangesAsync();

      if (departmentId > 0) {
        var empDept = await _context.EmployeeDepartments
          .FirstOrDefaultAsync(ed => ed.EmployeeId == employee.EmployeeId);

        if (empDept != null) {
          if (empDept.DepartmentId != departmentId)
            empDept.DepartmentId = departmentId;
        } else {
          await _context.EmployeeDepartments.AddAsync(new EmployeeDepartment {
            EmployeeId = employee.EmployeeId,
            DepartmentId = departmentId
          });
        }

        await _context.SaveChangesAsync();
      }

      return await _context.EmployeeViews
          .AsNoTracking()
          .FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
    }

    public async Task<bool> DeleteEmployeeAsync(int id) {
      var employee = await _context.Employees.FindAsync(id);
      if (employee == null || employee.DeleteAt != null)
        return false;

      employee.DeleteAt = DateTime.Now;
      await _context.SaveChangesAsync();
      return true;
    }

    public async Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids) {
      if (ids == null || !ids.Any())
        return false;

      var employees = await _context.Employees
          .Where(e => ids.Contains(e.Id) && e.DeleteAt == null)
          .ToListAsync();

      if (!employees.Any())
        return false;

      foreach (var emp in employees) {
        emp.DeleteAt = DateTime.Now;
      }

      await _context.SaveChangesAsync();
      return true;
    }
  }
}
