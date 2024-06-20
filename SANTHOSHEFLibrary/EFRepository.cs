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
        public void Insert(ConstituteDetails create)
        {
            reference.Add<ConstituteDetails>(create);
            reference.SaveChanges();
        }
        public void Edit(ConstituteDetails update)
        {
            try
            {
                reference.Update<ConstituteDetails>(update);
                reference.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ConstituteDetails Search(long ID)
        {
            return reference.Find<ConstituteDetails>(ID);
        }
        public void Delete(ConstituteDetails Remove)
        {
            reference.Remove<ConstituteDetails>(Remove);
            reference.SaveChanges();
        }
        public IEnumerable<District>Show()
        {
            try
            {
                return reference.DistrictsEF.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
          
    }
}
