using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class ReconSummary
    {
        public int ReconSummaryId { get; set; }

        public List<Recon> Recons { get; set; } = new List<Recon>();

        public string ProductGroup { get; set; }

        public string ProductType { get; set; }

        public string ProductSubType { get; set; }

        public string Customer { get; set; }

        public int CustomerCount { get; set; }

        public decimal CustomerAmount { get; set; }

        public string Switch { get; set; }

        public int SwitchCount { get; set; }

        public decimal SwitchAmount { get; set; }

        public string Treasury { get; set; }

        public int TreasuryCount { get; set; }

        public decimal TreasuryAmount { get; set; }

        public string InternalSystem { get; set; }

        public int InternalSystemCount { get; set; }

        public decimal InternalSystemAmount { get; set; }

        public string Supplier { get; set; }

        public int SupplierCount { get; set; }

        public decimal SupplierAmount { get; set; }

        public int CustomerVSFlashCount { get; set; }

        public decimal CustomerVSFlashAmount { get; set; }

        public int FlashInternalCount { get; set; }

        public decimal FlashInternalAmount { get; set; }

        public int FlashVSSupplierCount { get; set; }

        public decimal FlashVSSupplierAmount { get; set; }

    }
}
