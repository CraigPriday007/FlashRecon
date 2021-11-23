using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class ReconSwitchSourceSystem
    {
        public int Id { get; set; }

        public List<Recon> Recons { get; set; } = new List<Recon>();

        public List<SourceSystem> SourceSystems { get; set; } = new List<SourceSystem>();

        public List<Customer> Customers { get; set; } = new List<Customer>();

        public string MathcingKeyColumn { get; set; }

        public string DateColumnName { get; set; }

        public string DateColumnFormat { get; set; }

        public string AmountColumnName { get; set; }

        public string AmountColumnFormat { get; set; }

        public string SourceSystemTableSchema { get; set; }

        public string SourceSystemTableName { get; set; }

        public string SourceSystemTableColumns { get; set; }

        public string ExtractTableSchema { get; set; }

        public string ExtractTableName { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
