using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class FileSpec 
    {
        public int Id { get; set; }

        public string FileNames { get; set; }

        public string FileNameFormat { get; set; }

        public string FileNameDateFormat { get; set; }

        public string FileNameExtension { get; set; }

        public string FileDelimiter { get; set; }

        public string SourceFolder { get; set; }

        public string ArchiveFolder { get; set; }

        public string DuplicateFolder { get; set; }

        public string FileServerName { get; set; }

        public DateTime DaysDelayedFileNameDate { get; set; }

        public DateTime DaysDelayedFileTransactionDate { get; set; }

        public int RowsToSkipAfterColumnHeader { get; set; }

        public int RowsToSkipColumnHeaderMissing { get; set; }

        public Boolean HasTrailerRow { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
