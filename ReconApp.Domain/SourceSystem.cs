using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class SourceSystem
    {
        public int Id { get; set; }

        public List<SourceSystemGroup> SourceSystemGroups { get; set; } = new List<SourceSystemGroup>();

        public string SourceSystemName { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
