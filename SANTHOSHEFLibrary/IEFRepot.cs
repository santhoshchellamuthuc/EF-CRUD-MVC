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
        public void Insert(ConstituteDetails create);
        public void Edit(ConstituteDetails update);
        public ConstituteDetails Search(long ID);
        public void Delete(ConstituteDetails Remove);
        public IEnumerable<District> Show();
        public void Set(District set);


    }
}
