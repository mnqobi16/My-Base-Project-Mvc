using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewPSL.Models.PSL
{
    public class Customer_Purchase
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> LoyaltyPoints { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string RecieptNo { get; set; }
        public Nullable<System.DateTime> RecieptDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}