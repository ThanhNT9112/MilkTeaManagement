using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class Account
    {
        public Account()
        {
            Managers = new HashSet<Manager>();
        }

        public int AccountId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public int? BranchId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
