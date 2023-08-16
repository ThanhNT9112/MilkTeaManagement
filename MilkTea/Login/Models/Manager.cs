using System;
using System.Collections.Generic;

namespace Login.Models
{
    public partial class Manager
    {
        public Manager()
        {
            Branches = new HashSet<Branch>();
        }

        public int ManagerId { get; set; }
        public int? AccountId { get; set; }
        public string? Name { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public virtual Account? Account { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
