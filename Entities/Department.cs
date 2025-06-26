﻿using System;
using System.Collections.Generic;

namespace WinFormsApp2.Entities
{
    public partial class Department
    {
        public Department()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
