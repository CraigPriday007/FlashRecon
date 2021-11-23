using System;
namespace ReconApp.Domain
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAlternateName { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime LastDateTimeUpdated { get; set; }
    }
}
