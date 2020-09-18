
using NewPSL.Models.PSL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewPSL.Data
{
    public class PSLContext: DbContext 
    {

        public PSLContext() : base("DefaultConnection")
            {}

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Purchase> Customer_Purchase { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
    }
}