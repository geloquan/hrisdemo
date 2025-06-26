using System;
using System.Collections.Generic;

namespace WinFormsApp2.Entities
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string Concern { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
    }
}
