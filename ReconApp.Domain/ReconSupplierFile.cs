using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class ReconSupplierFile
    {
        public int Id { get; set; }

        public List<Recon> Recons { get; set; } = new List<Recon>();

        public List<FileSpec> FileSpecs { get; set; } = new List<FileSpec>();

        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public Boolean HasUserDefinedColumns { get; set; }

        public Boolean HasMultipleCustomersData { get; set; }

        public string MatchingKeyColumn { get; set; }

        public string DateColumnName { get; set; }

        public string DateColumnFormat { get; set; }

        public string ExtractTableSchema { get; set; }

        public string ExtractTableName { get; set; }

        // Could this not be a join to multiple Table Columns? to match on? or are they concatenated when reconciled?
        public string ExtractTableColumns { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
