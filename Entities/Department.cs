using System;
using System.Collections.Generic;

namespace WinFormsApp2.Entities
{
    public partial class Department
    {
        public Department()
        {
            EmployeeDepartments = new HashSet<EmployeeDepartment>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
