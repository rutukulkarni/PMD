using System.Runtime.Serialization;

namespace  PMD.DataContracts
{
    [DataContract]
    public class DashboardItemSource
    {
        [DataMember]
        public int DashboardItemID { get; set; }

        [DataMember]
        public int SourceID { get; set; }
    }
}
