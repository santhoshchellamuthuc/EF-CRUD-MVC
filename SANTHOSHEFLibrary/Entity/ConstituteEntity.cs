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
        [Required]
        [Display(Name = "Constitue Name:")]
        [MaxLength(35)]
        public string ConstitueName { get; set; }
        [Required]
        [Range(1,999999999999,ErrorMessage = "Please Enter TotalNumberOfVoters")]
        [Display(Name = " TotalNo.Of Voters:")]
        public long TotalNumberOfVoters { get; set; }
        [Required]
        [Display(Name = "Total No.Of MaleVoters:")]
        public long TotalNoOfMaleVoters { get; set; }
        public long TotalNoOfFemaleVoters { get; set; }
        public long DistrictId { get; set; }
        public IEnumerable<District> District { get; set; }
    }
}
