using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewPSL.Models.PSL
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<int> GenderID { get; set; }
        public string ID_No { get; set; }
        public string Email { get; set; }
        public string Cell_No { get; set; }
        public Nullable<decimal> Loyalty_Points { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }

        public virtual Gender Gender { get; set; }
    }
}