using System;
namespace ReconApp.Domain
{
    public class OneBalanceVendor
    {

        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorAlternateName { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime LastDateTimeUpdated { get; set; }

    }
}

