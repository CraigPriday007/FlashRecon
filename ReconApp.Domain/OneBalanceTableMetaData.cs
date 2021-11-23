using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class OneBalaneTableMetaData
    {
        public int Id { get; set; }

        public string SchemaName { get; set; }

        public string TableName { get; set; }

        public string ColumnName { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
