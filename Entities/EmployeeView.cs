using System;
using System.Collections.Generic;

namespace WinFormsApp2.Entities
{
    public partial class EmployeeView
    {
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; } = null!;
        public DateTime EmployeeDateOfBirth { get; set; }
        public string EmployeeGenerateCode { get; set; } = null!;
        public string? DepartmentName { get; set; }
    }
}
