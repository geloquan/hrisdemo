using System;
using System.Collections.Generic;

namespace WinFormsApp2.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeDepartments = new HashSet<EmployeeDepartment>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string EmployeeCode { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime? DeleteAt { get; set; }

        public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
