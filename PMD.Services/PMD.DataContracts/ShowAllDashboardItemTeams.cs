using System.Runtime.Serialization;

namespace  PMD.DataContracts
{
    public class ShowAllDashboardItemTeams
    {
        [DataMember]
        public int ItemID { get; set; }

        [DataMember]
        public string ItemName { get; set; }
        
        [DataMember]
        public int TeamID { get; set; }

        [DataMember]
        public string TeamName { get; set; }

    }
}
