﻿using System;
using System.Runtime.Serialization;

namespace WcfServicesApp.DataLayer.DataContract
{
    [DataContract]
    public class StaffDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public DateTime BirthOfDay { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Descriptions { get; set; }
        [DataMember]
        public string ExternalLink { get; set; }

        [DataMember]
        public DateTime? Modified { get; set; }

        [DataMember]
        public DateTime? Created { get; set; }
    }
}
