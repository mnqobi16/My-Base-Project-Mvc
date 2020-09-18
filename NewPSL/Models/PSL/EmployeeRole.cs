using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewPSL.Models.PSL
{
    public class EmployeeRole
    {
        public int EmployeeRoleId { get; set; }
        public string RoleName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}