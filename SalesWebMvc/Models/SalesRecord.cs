using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus MStatus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime date, double amount, SaleStatus mStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MStatus = mStatus;
            Seller = seller;
        }
    }
}
