﻿using System.Runtime.Serialization;

namespace  PMD.DataContracts
{
    [DataContract]
    public class DashboardSource
    {
        [DataMember]
        public int SourceID { get; set; }

        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public int DashboardID { get; set; }
    }
}
