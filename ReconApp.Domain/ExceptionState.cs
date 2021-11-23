using System;
namespace ReconApp.Domain
{
    // What happens if we receive a fixed file format from a supplier?
    public class ExceptionState
    {
        public int Id { get; set; }

        public string ExceptionStateName { get; set; }

        public string ExceptionStateDecriptuon { get; set; }

    }
}
