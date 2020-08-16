using SalesWeb.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MyProperty { get; set; }
        public double Amount { get; set; }
        public SallesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord ()
        {
        }

        public SalesRecord (int id, DateTime date, int myProperty, double amount, SallesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            MyProperty = myProperty;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
