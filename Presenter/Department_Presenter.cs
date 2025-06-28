using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Context;
using WinFormsApp2.Entities;
using WinFormsApp2.Services;

namespace WinFormsApp2.Presenter {
  public class Department_Presenter {
    public readonly IDepartmentService _departmentService;
    public Department_Presenter() {
      var dbContext = new MyDbContext();
      _departmentService = new DepartmentService(dbContext);
    }
    public async Task<List<Department>> GetDepartmentsAsync() {
      return await _departmentService.GetDepartmentsAsync();
    }
  }
}
