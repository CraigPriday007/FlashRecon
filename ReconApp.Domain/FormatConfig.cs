using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class FormatConfig
    {
        public int Id { get; set; }

        public string FormatName { get; set; }

        public string FormatType { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
