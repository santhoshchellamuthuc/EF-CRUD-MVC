using SANTHOSHEFLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANTHOSHEFLibrary
{
    public class EFRepositry : IEFRepot
    {
        private readonly EFDbContext reference;
        public EFRepositry(EFDbContext referadding)
        {
            reference = referadding;
        }
       
       public  IEnumerable<ConstituteDetails> Showall()
        {
            return reference.ConstituteDetailsEF.ToList();
        }
    }
}
