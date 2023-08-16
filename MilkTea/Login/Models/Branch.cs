using System;
using System.Collections.Generic;

namespace Login.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Orders = new HashSet<Order>();
        }

        public int BranchId { get; set; }
        public string? BranchName { get; set; }
        public int? ManagerId { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual Manager? Manager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
