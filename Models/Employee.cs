using System;
using System.Collections.Generic;

#nullable disable

namespace DockerSQLAPI.Models
{
    public partial class Employee
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public decimal? Salary { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
