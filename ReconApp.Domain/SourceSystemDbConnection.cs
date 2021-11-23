using System;
using System.Collections.Generic;

namespace ReconApp.Domain
{
    public class SourceSystemDbConnection
    {
        public int Id { get; set; }

        public List<SourceSystem> SourceSystems { get; set; } = new List<SourceSystem>();

        public string DbName { get; set; }

        public string SqlUser { get; set; }

        public string SqlPass { get; set; }

        public string SqlServerName { get; set; }

        public string SqlServerAddress { get; set; }

        public string SSISServerConnectionName { get; set; }

        public DateTime CreateDateTime { get; set;  }
    }
}
