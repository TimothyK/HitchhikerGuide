using System;
using System.Runtime.Serialization;

namespace PublisherService.Service
{

    [DataContract]
    public class Planet
    {
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool HasAtmosphere { get; set; }
        [DataMember]
        public string SkyColour { get; set; }
        [DataMember]
        public string Notes { get; set; }
    }
}