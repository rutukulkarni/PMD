using System.Runtime.Serialization;

namespace  PMD.DataContracts
{

    [DataContract]
    public class DashboardItemTeam
    {
        [DataMember]
        public int ItemID { get; set; }

        [DataMember]
        public int TeamID { get; set; }


    }
}
