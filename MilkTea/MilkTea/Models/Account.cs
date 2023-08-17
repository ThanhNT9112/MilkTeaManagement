using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
