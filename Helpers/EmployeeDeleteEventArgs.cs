using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Helpers {
    public class EmployeeDeleteEventArgs {
        public EmployeeView _employee { get; }
        public EmployeeDeleteEventArgs (EmployeeView employee) {
            _employee = employee;
        }
    }
}
