using SANTHOSHEFLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SANTHOSHEFLibrary
{
    public class ConstituteDetails
    {

        [Key]
        public long ConstituteID { get; set; }
        public string ConstitueName { get; set; }
        public long TotalNumberOfVoters { get; set; }
        public long TotalNoOfMaleVoters { get; set; }
        public long TotalNoOfFemaleVoters { get; set; }
        public long DistrictId { get; set; }
        public IEnumerable<District> District { get; set; }
    }
}
