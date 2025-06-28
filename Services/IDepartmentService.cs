using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Services {
  public interface IDepartmentService {
    Task<List<Department>> GetDepartmentsAsync();
  }
}
