using Microsoft.EntityFrameworkCore;
using WinFormsApp2.Context;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly MyDbContext _context;

        public EmployeeService(MyDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        public async Task<List<EmployeeView>> GetEmployeeViewAsync()
        {
            return await _context.EmployeeViews.ToListAsync();
        }

        public async Task<int> GetEmployeeCountAsync()
        {
            return await _context.Employees.CountAsync();
        }

        public async Task<EmployeeView> GetEmployeeByIdAsync(int id)
        {
            return await _context.EmployeeViews
                .FirstOrDefaultAsync(e => e.EmployeeId == id);
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee, int departmentId = 0)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();


            if (departmentId != 0)
            {
                _context.EmployeeDepartments.Add(new EmployeeDepartment
                {
                    DepartmentId = departmentId,
                    EmployeeId = employee.Id
                });

                await _context.SaveChangesAsync();
            }

            return employee;
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee, int departmentId = 0)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            var existingEmployee = await _context.Employees.FindAsync(employee.Id);
            if (existingEmployee == null)
                return null;

            _context.Entry(existingEmployee).CurrentValues.SetValues(employee);
            await _context.SaveChangesAsync();

            if (departmentId > 0)
            {
                var empDept = await _context.EmployeeDepartments
                    .FirstOrDefaultAsync(ed => ed.EmployeeId == employee.Id);

                if (empDept != null)
                {
                    if (empDept.DepartmentId != departmentId)
                    {
                        empDept.DepartmentId = departmentId;
                    }
                }
                else
                {
                    // Create a new relation if not found
                    empDept = new EmployeeDepartment
                    {
                        EmployeeId = employee.Id,
                        DepartmentId = departmentId
                    };
                    await _context.EmployeeDepartments.AddAsync(empDept);
                }

                await _context.SaveChangesAsync();
            }

            return await _context.Employees
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == employee.Id);
        }


        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return false;

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteEmployeesAsync(IEnumerable<int> ids)
        {
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
