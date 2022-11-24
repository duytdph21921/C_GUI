using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class MauSacs : IMauSac
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(mauSac mauSac)
        {
            if (mauSac == null) return false;

            _dbcontext.MauSacs.Add(mauSac);
            _dbcontext.SaveChanges();
            return true;

        }

        public bool delete(mauSac mauSac)
        {
            if (mauSac.id == null) return false;
            var getidmauSac = _dbcontext.MauSacs.FirstOrDefault(c => c.id == mauSac.id);
            _dbcontext.MauSacs.Remove(getidmauSac);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<mauSac> GetAll()
        {
            return _dbcontext.MauSacs.ToList();
        }

        public bool update(mauSac mauSac)
        {
            if (mauSac.id == null) return false;
            var getidmauSac = _dbcontext.MauSacs.FirstOrDefault(c => c.id == mauSac.id);
            _dbcontext.MauSacs.Update(getidmauSac);
            _dbcontext.SaveChanges();
            return true;
        }

      
      
    }
}
