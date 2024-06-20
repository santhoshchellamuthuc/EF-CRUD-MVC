using SANTHOSHEFLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANTHOSHEFLibrary
{
  public  interface IEFRepot
    {
       
        public IEnumerable<ConstituteDetails> Showall();

    }
}
