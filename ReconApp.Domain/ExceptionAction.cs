using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class ExceptionAction
    {
        public int Id { get; set; }

        public string ExceptionActionName { get; set; }

        public string ExceptionActionDecriptuon { get; set; }

    }
}
