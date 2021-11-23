using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class ReconCustomerFile
    {
        public int Id { get; set; }

        public List<Recon> Recons { get; set; } = new List<Recon>();

        public List<FileSpec> FileSpecs { get; set; } = new List<FileSpec>();

        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Boolean HasUserDefinedColumns { get; set; }

        public Boolean HasMultipleSupplierData { get; set; }

        public string MatchingKeyColumn { get; set;}

        public string DateColumnName { get; set; }

        public string DateColumnFormat { get; set; }

        public string AmountColumnName { get; set; }

        public string AmountColumnFormat { get; set; }

        public string ExtractTableName { get; set; }
    }
}
