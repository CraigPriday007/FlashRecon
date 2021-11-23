using System;

namespace ReconApp.Domain
{
    public class Supplier
    {
        public int Id { get; set; }

        public string SupplierName { get; set; }

        public string SupplierAlternateName { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
