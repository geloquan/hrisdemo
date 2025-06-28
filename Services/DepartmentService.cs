using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Context;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Services {
  public class DepartmentService : IDepartmentService {
    public readonly MyDbContext _context;
    public DepartmentService(MyDbContext myDbContext) {
      _context = myDbContext ?? throw new ArgumentNullException(nameof(myDbContext));
    }

    public async Task<List<Department>> GetDepartmentsAsync() {
      return await _context.Departments.ToListAsync();
    }

  }
}
