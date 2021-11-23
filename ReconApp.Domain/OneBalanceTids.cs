using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class OneBalanceTids
    {
        public int TransactionYear { get; set; }

        public int TransactionMonth { get; set; }

        public int TransactionDay { get; set; }

        public DateTime TransactionFullDate { get; set; }

        public int MinTid { get; set; }

        public DateTime DateTimeCreated { get; set; }
        
        public DateTime LastDateTimeUpdated { get; set; }

    }
}
