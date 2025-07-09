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

        public async Task<EmployeeView> UpdateEmployeeAsync(EmployeeView employee, int departmentId = 0)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            var existingEmployee = await _context.Employees.FindAsync(employee.EmployeeId);
            if (existingEmployee == null)
                return null;

            // Update only the fields that exist in both Employee and EmployeeView
            _context.Entry(existingEmployee).CurrentValues.SetValues(new
            {
                Id = employee.EmployeeId,
                FullName = employee.EmployeeFullName,
                EmployeeCode = employee.EmployeeGenerateCode,
                DateOfBirth = employee.EmployeeDateOfBirth
            });

            await _context.SaveChangesAsync();

            // Handle Department assignment
            if (departmentId > 0)
            {
                var empDept = await _context.EmployeeDepartments
                    .FirstOrDefaultAsync(ed => ed.EmployeeId == employee.EmployeeId);

                if (empDept != null)
                {
                    if (empDept.DepartmentId != departmentId)
                        empDept.DepartmentId = departmentId;
                }
                else
                {
                    await _context.EmployeeDepartments.AddAsync(new EmployeeDepartment
                    {
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
