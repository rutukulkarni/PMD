using System.Runtime.Serialization;

namespace  PMD.DataContracts
{
    [DataContract]
    public class AccessRight
    {
        [DataMember]
        public string AccessRightName { get; set; }

    }
}
