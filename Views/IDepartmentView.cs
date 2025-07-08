using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Views
{
    internal interface IDepartmentView
    {
        void DisplayDepartments(List<Department> departments);
    }
}
