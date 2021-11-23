using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class ReconTreasurySourceSystem
    {
        public int Id { get; set; }

        public List<Recon> Recons { get; set; } = new List<Recon>();

        public List<SourceSystem> SourceSystems { get; set; } = new List<SourceSystem>();

        public List<Customer> Customers { get; set; } = new List<Customer>();

        public string BillingCodes { get; set; }

        public string CompletionCodes { get; set; }

        public string MatchingKeyColumn { get; set; }

        public string DateColumnName { get; set; }

        public string DateColumnFormat { get; set; }


     }
}
