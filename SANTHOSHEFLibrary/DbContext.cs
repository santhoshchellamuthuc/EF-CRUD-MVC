using Microsoft.EntityFrameworkCore;
using SANTHOSHEFLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANTHOSHEFLibrary
{
   public  class EFDbContext:DbContext
    {
        public EFDbContext(DbContextOptions  reference ):base(reference)
        {

        }
        public virtual DbSet<District> DistrictsEF { get; set; }
    }
}
