using System;
namespace ReconApp.Domain
{
    public class Recon
    {
        public int Id { get; set; }

        public string ReconName { get; set; }

        public Boolean IsActive { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
