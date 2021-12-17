using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Selle { get; set; }   

        public SalesRecords()
        {

        }

        public SalesRecords(int id, DateTime date, double amount, SalesStatus status, Seller selle)
        {
            Id = id;
            Date = date;
            this.amount = amount;
            Status = status;
            Selle = selle;
        }
    }
}
