using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class OneBalaneOMTableMapping
    {
        public int CustomerId { get; set; }

        public int SupplierId { get; set; }

        public int OneBalanceUtilityID { get; set; }

        public string RoutingOMName { get; set; }

        public string OMTableName { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
