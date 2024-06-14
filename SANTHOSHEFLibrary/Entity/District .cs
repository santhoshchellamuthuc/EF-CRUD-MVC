using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANTHOSHEFLibrary.Entity
{
  public   class District
    {
        [Key]
        public long Id { get; set; }
        public string Districtname { get; set; }
    }
}
